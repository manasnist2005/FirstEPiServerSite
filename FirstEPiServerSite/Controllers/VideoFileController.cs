using EPiServer.Core;
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
    public class VideoFileController : PartialContentController<VideoFile>
    {
        private readonly UrlResolver _urlResolver;

        public VideoFileController(UrlResolver urlResolver)
        {
            _urlResolver = urlResolver;
        }

        /// <summary>
        /// The index action for the video file. Creates the view model and renders the view.
        /// </summary>
        /// <param name="currentContent">The current video file.</param>
        public override ActionResult Index(VideoFile currentContent)
        {
            var model = new VideoViewModel
            {
                Url = _urlResolver.GetUrl(currentContent.ContentLink),
                PreviewImageUrl = ContentReference.IsNullOrEmpty(currentContent.PreviewImage) ? String.Empty : _urlResolver.GetUrl(currentContent.PreviewImage),
            };
            return PartialView(model);
        }
    }
}
