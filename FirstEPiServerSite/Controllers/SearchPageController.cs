using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using FirstEPiServerSite.Models.Pages;
using EPiServer.Globalization;
using EPiServer.Search;
using FirstEPiServerSite.Business;
using System;
using System.Web;
using EPiServer.Web;

namespace FirstEPiServerSite.Controllers
{
    public class SearchPageController : PageController<SearchPage>
    {
        public ActionResult Index(SearchPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            var hits = Search("mobile",
                    new[] { SiteDefinition.Current.StartPage, SiteDefinition.Current.GlobalAssetsRoot, SiteDefinition.Current.SiteAssetsRoot, SiteDefinition.Current.RootPage },
                    ControllerContext.HttpContext,
                    currentPage.LanguageID);

            return View(currentPage);
        }

        /// <summary>
        ///  For search functionality
        /// </summary>
        /// <param name="searchText"></param>
        /// <param name="searchRoots"></param>
        /// <param name="context"></param>
        /// <param name="languageBranch"></param>
        /// <returns></returns>
        private SearchResults Search(string searchText, IEnumerable<ContentReference> searchRoots, HttpContextBase context, string languageBranch)
        {           

            try
            {
                SearchService ss = new SearchService();
                //ss.GetProductBlocks(3);
                //SearchResults searchResults = _searchService.Search(searchText, searchRoots, context, languageBranch, MaxResults);
                var query = ss.CreateQuery("Mobiles", searchRoots, context, languageBranch);
                SearchResults searchResults = SearchHandler.Instance.GetSearchResults(query, 1, 20);

                return searchResults;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return null;
            }
        }
    }
}