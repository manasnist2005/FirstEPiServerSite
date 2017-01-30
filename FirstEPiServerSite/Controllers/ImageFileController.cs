using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;
using FirstEPiServerSite.Models.Media;
using FirstEPiServerSite.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstEPiServerSite.Controllers
{
    public class ImageFileController : PartialContentController<ImageFile>
    {
        private readonly UrlResolver _urlResolver;

        public ImageFileController(UrlResolver urlResolver)
        {
            _urlResolver = urlResolver;
        }

        /// <summary>
        /// The index action for the image file. Creates the view model and renders the view.
        /// </summary>
        /// <param name="currentContent">The current image file.</param>
        public override ActionResult Index(ImageFile currentContent)
        {
            var model = new ImageViewModel
            {
                Url = _urlResolver.GetUrl(currentContent.ContentLink),
                Name = currentContent.Name,
                Copyright = currentContent.Copyright
            };
            return PartialView(model);
        }
    }
}