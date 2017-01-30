using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using FirstEPiServerSite.Models.Blocks;

namespace FirstEPiServerSite.Controllers
{
    public class ProductTeaserBlockController : BlockController<ProductTeaserBlock>
    {
        public override ActionResult Index(ProductTeaserBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
