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
    public class CommentsController : Controller
    {
        private readonly ICommentsService commentsService;
        public CommentsController(ICommentsService commentsService)
        {
            this.commentsService = commentsService;
        }
        [ProducesResponseType(typeof(List<Comments>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Comments), StatusCodes.Status400BadRequest)]
        [Route("DeleteComments/{id}")]
        [HttpDelete]
        public bool DeleteComments(int id)
        {
            return commentsService.DeleteComments(id);
        }
        [Route("GetComments")]
        [HttpGet]
        public List<Comments> GetComments()
        {
            return commentsService.GetComments();
        }
        [Route("InsertComments")]
        [HttpPost]
        public bool InsertComments(Comments comments)
        {
            return commentsService.InsertComments(comments);
        }
        [Route("UpdateComments")]
        [HttpPut]
        public bool UpdateComments(Comments comments)
        {
            return commentsService.UpdateComments(comments);
        }
    }
}
