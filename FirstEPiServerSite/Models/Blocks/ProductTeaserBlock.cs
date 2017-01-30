using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer;
using EPiServer.Web;

namespace FirstEPiServerSite.Models.Blocks
{
    [ContentType(DisplayName = "ProductTeaserBlock", GUID = "db320133-2c46-4587-94c3-57e8bd26381e", Description = "")]
    public class ProductTeaserBlock : BlockData
    {
     
        [CultureSpecific]
        [Display(
            Name = "Header",
            Description = "Enter header for a block",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        [Required]
        public virtual string Header { get; set; }

        [CultureSpecific]
        [Display(
                    Name = "Description",
                    Description = "Enter description for a block",
                    GroupName = SystemTabNames.Content,
                    Order = 2)]
        [Required]
        public virtual XhtmlString Description { get; set; }
        
        [Display(
                Name = "Image", Description = "Add an image (optional)",
                GroupName = SystemTabNames.Content,
                Order = 3)]
        [Required]
        public virtual Url Image { get; set; }

        [CultureSpecific]
        [Display(
                    Name = "Url",
                    Description = "Choose an Url to redirect on click",
                    GroupName = SystemTabNames.Content,
                    Order = 4)]
        [Required]
        public virtual Url Url { get; set; }
        
    }
}