using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using taskMangerment.Models;

namespace taskMangerment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskItemsController : ControllerBase
    {
        private static List<TaskItem> TaskItmes = new List<TaskItem>() 
        {
            new TaskItem{ id =1, Title = "Website Redesign", Description = "redsigning test"},
            new TaskItem{ id =2, Title = "test", Description = "test"}
        };

        [HttpGet]
        public IEnumerable<TaskItem> Get() 
        {
            return TaskItmes;
        }
    }
}
