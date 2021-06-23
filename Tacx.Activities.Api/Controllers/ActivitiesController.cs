using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tacx.Activities.Api.Models;
using Tacx.Activities.Api.Repository;
using Tacx.Activities.Api.Services;

namespace Tacx.Activities.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitiesController : ControllerBase
    {
        private readonly ActivitiesRepository _activitiesRepository;
        private readonly FilesStorageService _filesStorageService;
        public ActivitiesController()
        {
            _activitiesRepository = new ActivitiesRepository();
            _filesStorageService = new FilesStorageService();
        }

        [HttpPost]
        public IActionResult Create()
        {            
            var newActivity = new ActivityDto();

            return Ok(newActivity);
        }

        [HttpGet("{id}")]
        public IActionResult GetActivityById(int id)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteActivity(int id)
        {
            throw new NotImplementedException();
        }
    }
}