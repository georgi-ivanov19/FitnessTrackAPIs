using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkoutsAPI.Context;
using WorkoutsAPI.Models;

namespace WorkoutsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExercisesController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public ExercisesController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Exercises
        [HttpGet("GetExercises/{id}")]
        public async Task<ActionResult<List<Exercise>>> GetExercisesForWorkout(int id)
        {
            var workout = await _context.Workouts.FirstOrDefaultAsync(w => w.Id == id);
            if (workout == null)
            {
                return NotFound("Workout not found");
            }
            return Ok(workout.Exercises);
        }

        // GET: api/Exercises/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Exercise>> GetExercise(int id)
        {
            if (_context.Exercises == null)
            {
                return NotFound();
            }
            var exercise = await _context.Exercises.FindAsync(id);
            if (exercise == null)
            {
                return NotFound("Exercise not found");
            }

            return Ok(exercise);
        }

        // PUT: api/Exercises/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Exercise>> PutExercise(int id, Exercise exercise)
        {
            var dbExercise = await _context.Exercises.FirstOrDefaultAsync(ex => ex.Id == id);
            if (dbExercise == null)
            {
                return NotFound("Exercise Not Found");
            }
            dbExercise.WorkoutId = exercise.WorkoutId;
            dbExercise.DefaultNumberOfSets = exercise.DefaultNumberOfSets;
            dbExercise.Name = exercise.Name;
            dbExercise.TargetMuscle = exercise.TargetMuscle;
            await _context.SaveChangesAsync();

            return Ok(dbExercise);
        }

        // POST: api/Exercises
        [HttpPost]
        public async Task<ActionResult<Exercise>> PostExercise(Exercise exercise)
        {
          if (_context.Exercises == null)
          {
              return Problem("Entity set 'DatabaseContext.Exercises'  is null.");
          }
            _context.Exercises.Add(exercise);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExercise", new { id = exercise.Id }, exercise);
        }

        // DELETE: api/Exercises/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExercise(int id)
        {
            if (_context.Exercises == null)
            {
                return NotFound();
            }
            var exercise = await _context.Exercises.FindAsync(id);
            if (exercise == null)
            {
                return NotFound();
            }

            _context.Exercises.Remove(exercise);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
