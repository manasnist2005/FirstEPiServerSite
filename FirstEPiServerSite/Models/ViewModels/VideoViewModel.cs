using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstEPiServerSite.Models.ViewModels
{
    public class VideoViewModel
    {
        /// <summary>
        /// Gets or sets the URL to the video.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the URL to a preview image for the video.
        /// </summary>
        public string PreviewImageUrl { get; set; }
    }
}