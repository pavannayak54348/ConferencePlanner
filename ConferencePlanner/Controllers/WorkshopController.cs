using ConferencePlanner.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferencePlanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkshopController : ControllerBase
    {
        private ApplicationDbContext _context;
        public WorkshopController(ApplicationDbContext context)
        {

            _context = context;
            if (!_context.Workshops.Any())
            {
                _context.Workshops.Add(new Workshop
                { Name = "Event Management", Speaker = "Shweta" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<Workshop> GetWorkshops()
        {
            return _context.Workshops;
        }
    }
}
