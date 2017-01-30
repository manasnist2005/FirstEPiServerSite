using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace FirstEPiServerSite.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "741928a9-b3e5-4d48-b36d-91d2d54657c3", Description = "")]
    [ImageUrlAttribute(Global.StaticGraphicsFolderPath + "page-type-thumbnail-standard.png")]
    public class StartPage : PageData
    {
        [Display(
                  Name = "Header",
                  Description = "Heading of the article",
                  GroupName = SystemTabNames.Content,
                  Order = 1)]
        public virtual XhtmlString Header { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
           GroupName = SystemTabNames.Content,
           Order = 3)]
        public virtual ContentArea MainContentArea { get; set; }

    }
}