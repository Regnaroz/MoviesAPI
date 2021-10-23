using Movies.Core.Data;
using Movies.Core.Repository;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Infra.Service
{
    public class WebSiteService : IWebSiteService
    {
        private readonly IWebSiteRepository WebSiteRepository;
        public WebSiteService(IWebSiteRepository WebSiteRepository)
        {
            this.WebSiteRepository = WebSiteRepository;
        }
        public bool DeleteWebSite(int id)
        {
            return WebSiteRepository.DeleteWebSite(id);
        }

        public List<WebSite> GetWebSite()
        {
            return WebSiteRepository.GetWebSite();
        }

        public bool InsertWebSite(WebSite WebSite)
        {
            return WebSiteRepository.InsertWebSite(WebSite);
        }

        public bool UpdateWebSite(WebSite WebSite)
        {
            return WebSiteRepository.UpdateWebSite(WebSite);
        }
    }
}
