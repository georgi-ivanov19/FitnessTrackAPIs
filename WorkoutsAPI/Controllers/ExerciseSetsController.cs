using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkoutsAPI.Models;
using WorkoutsAPI.Context;
using Microsoft.EntityFrameworkCore;

namespace WorkoutsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseSetsController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public ExerciseSetsController(DatabaseContext context)
        {
            _context = context;
        }

        //[HttpGet("GetExerciseSets/{id}")]
        //public async Task<ActionResult<List<ExerciseSet>>> GetExerciseSetsForExercise(int id)
        //{
        //    var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == User.FindFirstValue(ClaimTypes.NameIdentifier));

        //    if (user == null)
        //    {
        //        return NotFound("User not found");
        //    }

        //    var tw = await _context.TrackedWorkouts.FirstOrDefaultAsync(e => e.Id == id);
        //    if (tw == null)
        //    {
        //        return NotFound("Workout not found");
        //    }
        //    return Ok(tw.ExerciseSetsCompleted);
        //}

        //[HttpGet("GetExerciseSet/{id}")]
        //public async Task<ActionResult<ExerciseSet>> GetSingleExerciseSet(int id)
        //{
        //    var exerciseSet = await _context.ExerciseSets.FirstOrDefaultAsync(e => e.Id == id);
        //    if (exerciseSet == null)
        //    {
        //        return NotFound("Set not found");
        //    }
        //    return Ok(exerciseSet);
        //}

        //[HttpPost]
        //public async Task<ActionResult<ExerciseSet>> CreateExerciseSet(ExerciseSet exerciseSet)
        //{
        //    _context.ExerciseSets.Add(exerciseSet);
        //    await _context.SaveChangesAsync();

        //    return Ok(exerciseSet);
        //}

        [HttpPost("range")]
        public async Task<ActionResult<ExerciseSet>> CreateExerciseSetRange(List<ExerciseSet> exerciseSets)
        {
            _context.ExerciseSets.AddRange(exerciseSets);
            await _context.SaveChangesAsync();

            return Ok(exerciseSets);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ExerciseSet>> UpdateExerciseSet(ExerciseSet exerciseSet, int id)
        {
            var dbExerciseSet = await _context.ExerciseSets.FirstOrDefaultAsync(e => e.Id == id);
            if (dbExerciseSet == null)
            {
                return NotFound("Workout Not Found");
            }
            dbExerciseSet.Reps = exerciseSet.Reps;
            dbExerciseSet.Weight = exerciseSet.Weight;
            dbExerciseSet.IsWarmup = exerciseSet.IsWarmup;
            dbExerciseSet.ExerciseId = exerciseSet.ExerciseId;
            dbExerciseSet.ExerciseName = exerciseSet.ExerciseName;
            dbExerciseSet.IsComplete = exerciseSet.IsComplete;
            await _context.SaveChangesAsync();

            return Ok(dbExerciseSet);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteExerciseSet(int id)
        {
            var dbExerciseSet = await _context.ExerciseSets.FirstOrDefaultAsync(ex => ex.Id == id);
            if (dbExerciseSet == null)
            {
                return NotFound("ExerciseSet Not Found");
            }

            _context.ExerciseSets.Remove(dbExerciseSet);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
