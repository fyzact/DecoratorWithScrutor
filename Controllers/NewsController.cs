using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DecoratorWithScrutor.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DecoratorWithScrutor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        INewsService _newsService;
        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }
        // GET: api/News
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _newsService.GetNewsAsync());
        }
    }
}
