using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UpsellPageAPI.Entities;
using UpsellPageAPI.Interfaces;

namespace UpsellPageAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityService _activityService;

        public ActivityController(IActivityService activityService)
        {
            _activityService = activityService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_activityService.GetAllActivities());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var activity = _activityService.GetActivityById(id);
            if (activity == null)
                return NotFound();

            return Ok(activity);
        }

        [HttpPost]
        public IActionResult Create(Activity activity)
        {
            _activityService.AddActivity(activity);
            return CreatedAtAction(nameof(Get), new { id = activity.Id }, activity);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Activity activity)
        {
            if (id != activity.Id)
                return BadRequest();

            _activityService.UpdateActivity(activity);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _activityService.DeleteActivity(id);
            return NoContent();
        }
    }
}
