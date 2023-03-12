using WorkoutsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using WorkoutsAPI.Context;
using Microsoft.EntityFrameworkCore;

namespace WorkoutsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutsController : ControllerBase
    {

        private readonly DatabaseContext _context;

        public WorkoutsController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Workout>>> GetWorkouts(string userId)
        {        
            if (userId == null)
            {
                return NotFound("UserId is a required query parameter");
            }          
            var workouts = await _context.Workouts.Where(w => w.ApplicationUserId == userId).ToListAsync();          
            return Ok(workouts);
        }

        [HttpGet("GetWorkout/{id}")]
        public async Task<ActionResult<Workout>> GetSingleWorkout(int id)
        {
            var workout = await _context.Workouts.FirstOrDefaultAsync(w => w.Id == id);
            if (workout == null)
            {
                return NotFound("Workout not found");
            }
            return Ok(workout);
        }

        [HttpPost]
        public async Task<ActionResult<Workout>> CreateWorkout(Workout workout)
        {
            _context.Workouts.Add(workout);
            await _context.SaveChangesAsync();

            return Ok(workout);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Workout>> UpdateWorkout(Workout workout, int id)
        {
            var dbWorkout = await _context.Workouts.FirstOrDefaultAsync(w => w.Id == id);
            if (dbWorkout == null)
            {
                return NotFound("Workout Not Found");
            }
            dbWorkout.Name = workout.Name;
            dbWorkout.DayOfWeek = workout.DayOfWeek;
            dbWorkout.DateLastCompleted = workout.DateLastCompleted;
            await _context.SaveChangesAsync();

            return Ok(dbWorkout);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteWorkout(int id)
        {
            var dbWorkout = await _context.Workouts.FirstOrDefaultAsync(w => w.Id == id);
            if (dbWorkout == null)
            {
                return NotFound("Workout Not Found");
            }

            _context.Workouts.Remove(dbWorkout);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
