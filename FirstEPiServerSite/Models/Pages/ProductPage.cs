using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace FirstEPiServerSite.Models.Pages
{
    [ContentType(DisplayName = "ProductPage", GUID = "5e01f78a-abcf-4116-ae79-7bd18607607e",
        GroupName = Global.GroupNames.Products,
        Description = "")]
    [ImageUrlAttribute(Global.StaticGraphicsFolderPath + "page-type-thumbnail-product.png")]
    public class ProductPage : StartPage
    {
        //[Display(
        //         Name = "Header1",
        //         Description = "Heading of the article",
        //         GroupName = Global.GroupNames.Test,
        //         Order = 1)]
        //public virtual XhtmlString Header1 { get; set; }
    }
}