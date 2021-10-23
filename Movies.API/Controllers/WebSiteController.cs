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
    public class WebSiteController : Controller
    {
        private readonly IWebSiteService WebSiteService;
        public WebSiteController(IWebSiteService WebSiteService)
        {
            this.WebSiteService = WebSiteService;
        }
        [ProducesResponseType(typeof(List<WebSite>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(WebSite), StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Route("GetWebSite")]//sub route
        public List<WebSite> GetWebSite()
        {
            return WebSiteService.GetWebSite();
        }
        [ProducesResponseType(typeof(List<WebSite>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(WebSite), StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("InsertWebSite")]//sub route
        public bool InsertWebSite([FromBody] WebSite WebSite)
        {
            return WebSiteService.InsertWebSite(WebSite);
        }
        [ProducesResponseType(typeof(List<WebSite>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(WebSite), StatusCodes.Status400BadRequest)]
        [HttpDelete]
        [Route("DeleteWebSite/{id}")]//sub route
        public bool DeleteWebSite(int id)
        {
            return WebSiteService.DeleteWebSite(id);
        }
        [ProducesResponseType(typeof(List<WebSite>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(WebSite), StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Route("UpdateWebSite")]//sub route
        public bool UpdateWebSite([FromBody] WebSite WebSite)
        {
            return WebSiteService.UpdateWebSite(WebSite);
        }
    }
}
