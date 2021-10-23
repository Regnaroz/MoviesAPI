using Movies.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Repository
{
    public interface IWebSiteRepository
    {
        public List<WebSite> GetWebSite();
        public bool InsertWebSite(WebSite WebSite);
        public bool UpdateWebSite(WebSite WebSite);
        public bool DeleteWebSite(int id);
    }
}
