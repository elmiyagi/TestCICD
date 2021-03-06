using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCICD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MopsikController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult Get()
        {
            return Ok("Ok");
        }

        [HttpGet]
        [Route("dane")]
        public IActionResult Get(int tlow, int klatka, int waga)
        {
            return Ok(tlow + klatka + waga);
        }

        [HttpGet]
        [Route("newget")]
        public IActionResult NewGet()
        {
            return Ok("newget");
        }

        [HttpGet]
        [Route("jebacpis")]
        public IActionResult JebacPis()
        {
            return Ok("iks de");
        }

        [HttpGet]
        [Route("golfik")]
        public IActionResult Golfik()
        {
            return Ok("Golfiątko :D");
        }

        [HttpGet]
        [Route("cuper")]
        public IActionResult Cuper()
        {
            return Ok("Jest cuper jest cuper więc o co Ci chodzi ?");
        }

    }
}
