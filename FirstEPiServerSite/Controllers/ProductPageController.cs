using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using FirstEPiServerSite.Models.Pages;
using FirstEPiServerSite.Business;
using EPiServer.Search;
using System.Web;
using EPiServer.Web;
using EPiServer.Web.Routing;
using System;
using EPiServer.Globalization;
using FirstEPiServerSite.Models.Blocks;
using FirstEPiServerSite.Helpers;

namespace FirstEPiServerSite.Controllers
{
    public class ProductPageController : PageController<ProductPage>
    {

        public ActionResult Index(ProductPage currentPage, string pGuId)
        {
            //Go to Product/index view to fetch all the Product block of a particular category eg: Mobile,Laptop etc
            if (pGuId == null)
            {
                Session["ProductCategoryId"] = currentPage.Category.FirstOrDefault().ToString();
                return View(currentPage);
            }
            else // Go to Product/Productdetails view to render the content of a single product based on content GuId
            {
                Session["ProductGuiD"] = pGuId;
                ProductTeaserBlock product = QueryHelper.GetProductBlockDetails((Session["ProductGuiD"].ToString()));
                return View("ProductDetails", product);
            }
        }

    }
}