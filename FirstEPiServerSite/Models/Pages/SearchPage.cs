using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace FirstEPiServerSite.Models.Pages
{
    [ContentType(DisplayName = "SearchPage", GUID = "2b53bed4-b7b5-49e6-bca1-7966030f81be", Description = "")]
    public class SearchPage : PageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 310)]
        [CultureSpecific]
        [AllowedTypes(new[] { typeof(IContentData) })]
        public virtual ContentArea RelatedContentArea { get; set; }
    }
}