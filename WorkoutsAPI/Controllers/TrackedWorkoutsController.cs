using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WorkoutsAPI.Models;
using Microsoft.EntityFrameworkCore;
using WorkoutsAPI.Context;
using Microsoft.AspNetCore.Cors;

namespace WorkoutsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackedWorkoutsController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public TrackedWorkoutsController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<TrackedWorkout>>> GetTrackedWorkouts(int id)
        {
            var workout = await _context.Workouts.FirstOrDefaultAsync(w => w.Id == id);
            if (workout == null)
            {
                return NotFound("Workout not found");
            }
            return Ok(workout.TrackedWorkouts);
        }

        [HttpPost]
        public async Task<ActionResult<Workout>> CreateTrackedWorkout(TrackedWorkout workout)
        {
            _context.TrackedWorkouts.Add(workout);

            await _context.SaveChangesAsync();

            return Ok(workout);
        }

        [HttpGet("GetWorkout/{id}")]
        public async Task<ActionResult<TrackedWorkout>> GetSingleWorkout(int id)
        {
            var workout = await _context.TrackedWorkouts.FirstOrDefaultAsync(w => w.Id == id);
            if (workout == null)
            {
                return NotFound("Workout not found");
            }
            return Ok(workout);
        }

        [HttpGet("GetLatestCompleted/{id}")]
        public async Task<ActionResult<TrackedWorkout>> GetLatestCompleted(int id)
        {
            var workout = await _context.Workouts.FirstOrDefaultAsync(w => w.Id == id);
            if (workout == null)
            {
                return NotFound("Parent Workout not found");
            }
            var latestCompleted = workout.TrackedWorkouts.Where(w => w.IsCompleted).OrderByDescending(w => w.EndTime).First();
            if (workout == null)
            {
                return NotFound("Workout not found");
            }
            return Ok(workout);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Workout>> UpdateWorkout(TrackedWorkout workout, int id)
        {
            var dbWorkout = await _context.TrackedWorkouts.FirstOrDefaultAsync(w => w.Id == id);
            if (dbWorkout == null)
            {
                return NotFound("Workout Not Found");
            }
            dbWorkout.TotalVolume = workout.TotalVolume;
            dbWorkout.IsCompleted = workout.IsCompleted;
            dbWorkout.StartTime = workout.StartTime;
            dbWorkout.WorkoutId = workout.WorkoutId;
            dbWorkout.ExerciseSetsCompleted = workout.ExerciseSetsCompleted;
            dbWorkout.EndTime = workout.EndTime;
            dbWorkout.Notes = workout.Notes;
            await _context.SaveChangesAsync();

            return Ok(dbWorkout);
        }

        [HttpGet("GetAverages")]
        public async Task<ActionResult<Dictionary<int, List<AverageResults>>>> GetAverages([FromQuery]string userId, [FromQuery] DateTime date)
        {
            var userWorkouts = await _context.Workouts.Where(w => w.ApplicationUserId == userId).ToListAsync();

            if (userWorkouts == null && userWorkouts.Count == 0)
            {
                return NotFound("User has no workouts");
            }

            var result = new Dictionary<int, List<AverageResults>>();
            foreach (var workout in userWorkouts)
            {
                // all complete tracked workouts for the past 30 days
                var trackedWorkouts = _context.TrackedWorkouts.Where(w => w.WorkoutId == workout.Id && w.IsCompleted && w.EndTime >= date.AddDays(-60) && w.EndTime <= date).ToList();
                result.Add(workout.Id, CalculateAverages(date, trackedWorkouts));
            }

            return result;
        }

        private List<AverageResults> CalculateAverages(DateTime date, List<TrackedWorkout> trackedWorkouts)
        {
            var currentWorkouts = trackedWorkouts.Where(m => m.EndTime >= date.AddDays(-30)).ToList();
            var previousWorkouts = trackedWorkouts.Where(m => m.EndTime < date.AddDays(-30)).ToList();


            double? averageCurrentVolume = null;
            double? averageCurrentDuration = null;

            double? averagePrevVolume = null;
            double? averagePrevDuration = null;

            if (currentWorkouts.Any())
            {
                averageCurrentVolume = currentWorkouts.Sum(w => w.TotalVolume) / currentWorkouts.Count;
                TimeSpan totalTimeSpan = TimeSpan.Zero;
                foreach (var w in currentWorkouts)
                {
                    var duration = w.EndTime - w.StartTime;
                    totalTimeSpan += (TimeSpan)duration;
                }
                averageCurrentDuration = currentWorkouts.Count != 0 ? totalTimeSpan.TotalMicroseconds / currentWorkouts.Count : null;
            }

            if (previousWorkouts.Any())
            {
                averagePrevVolume = previousWorkouts.Sum(w => w.TotalVolume) / previousWorkouts.Count;
                TimeSpan totalTimeSpan = TimeSpan.Zero;
                foreach (var w in previousWorkouts)
                {
                    var duration = w.EndTime - w.StartTime;
                    totalTimeSpan += (TimeSpan)duration;
                }

                averagePrevDuration = previousWorkouts.Count != 0 ? totalTimeSpan.TotalMicroseconds / previousWorkouts.Count : null;
            }

            return new List<AverageResults> {
                new AverageResults(averageCurrentVolume, currentWorkouts.Count, averagePrevVolume),
                new AverageResults(averageCurrentDuration, currentWorkouts.Count, averagePrevDuration),
            };
        }
    }
}
