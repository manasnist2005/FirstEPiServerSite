using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.ServiceLocation;
using FirstEPiServerSite.Models.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstEPiServerSite.Helpers
{
    public class QueryHelper
    {
        public static List<ProductTeaserBlock> GetProductBlocks(int categoryId)
        {
            List<ProductTeaserBlock> lstPoducts = new List<ProductTeaserBlock>();
            try
            {
                //Gets instances from Service Locator
                var contentTypeRepository = ServiceLocator.Current.GetInstance<IContentTypeRepository>();
                var contentModelUsage = ServiceLocator.Current.GetInstance<IContentModelUsage>();
                var contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();

                //Loads the ProductTeaserBlock Type 
                var contentType = contentTypeRepository.Load<ProductTeaserBlock>();

                //Gets all the content references based on Product teaser block with all the versions
                var contentUsages = contentModelUsage.ListContentOfContentType(contentType);

                //Removes the duplicate version block content references
                var distinctContent = new List<ContentUsage>();
                List<int> lstcontId = new List<int>();
                foreach (var contUsage in contentUsages)
                {
                    if (!lstcontId.Contains(contUsage.ContentLink.ID))
                    {
                        lstcontId.Add(contUsage.ContentLink.ID);
                        distinctContent.Add(contUsage);
                    }
                }

                //Get the contents from the content references and filters based on category     

                foreach (var contUsage in distinctContent)
                {
                    ProductTeaserBlock prd = contentLoader.Get<IContent>(contUsage.ContentLink.ToReferenceWithoutVersion()) as ProductTeaserBlock;
                    if ((prd as ICategorizable).Category.Contains(categoryId))
                    {
                        lstPoducts.Add(prd);

                    }
                }
                foreach (var aa in lstPoducts)
                {

                }
                return lstPoducts;
            }
            catch (Exception ex)
            {
                return lstPoducts;
            }

        }

        public static ProductTeaserBlock GetProductBlockDetails(string guId)
        {
            ProductTeaserBlock productContent = new ProductTeaserBlock();
            try
            {
                var contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();
                productContent = contentLoader.Get<IContent>(new System.Guid(guId)) as ProductTeaserBlock;
                return productContent;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}