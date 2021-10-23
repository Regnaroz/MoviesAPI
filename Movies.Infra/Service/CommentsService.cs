using Movies.Core.Data;
using Movies.Core.Repository;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Infra.Service
{
    public class CommentsService : ICommentsService
    {
        private readonly ICommentsRepository commentsRepository;
        public CommentsService(ICommentsRepository commentsRepository)
        {
            this.commentsRepository = commentsRepository;
        }

        public bool DeleteComments(int id)
        {
            return commentsRepository.DeleteComments(id);
        }

        public List<Comments> GetComments()
        {
            return commentsRepository.GetComments();
        }

        public bool InsertComments(Comments comments)
        {
            return commentsRepository.InsertComments(comments);
        }

        public bool UpdateComments(Comments comments)
        {
            return commentsRepository.UpdateComments(comments);
        }
    }
}
