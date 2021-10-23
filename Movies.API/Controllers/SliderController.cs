using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Core.Data;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderController : Controller
    {
        private readonly ISliderService SliderService;
        public SliderController(ISliderService SliderService)
        {
            this.SliderService = SliderService;
        }
        [ProducesResponseType(typeof(List<Slider>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Slider), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("GetSlider")]//sub route
        public List<Slider> GetSlider()
        {
            return SliderService.GetSlider();
        }
        [ProducesResponseType(typeof(List<Slider>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Slider), StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("InsertSlider")]//sub route
        public bool InsertSlider([FromBody] Slider Slider)
        {
            return SliderService.InsertSlider(Slider);
        }
        [ProducesResponseType(typeof(List<Slider>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Slider), StatusCodes.Status400BadRequest)]
        [HttpDelete]
        [Route("DeleteSlider/{id}")]//sub route
        public bool DeleteSlider(int id)
        {
            return SliderService.DeleteSlider(id);
        }
        [ProducesResponseType(typeof(List<Slider>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Slider), StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Route("UpdateSlider")]//sub route
        public bool UpdateSlider([FromBody] Slider Slider)
        {
            return SliderService.UpdateSlider(Slider);
        }
    }
}
