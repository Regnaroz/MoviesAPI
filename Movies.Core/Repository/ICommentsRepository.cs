using Movies.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Repository
{
    public interface ICommentsRepository
    {
        public List<Comments> GetComments();
        public bool InsertComments(Comments comments);
        public bool UpdateComments(Comments comments);
        public bool DeleteComments(int id);
    }
}
