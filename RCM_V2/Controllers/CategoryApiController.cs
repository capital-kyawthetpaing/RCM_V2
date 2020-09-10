using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;
using Category_BL;

namespace RCM_V2.Controllers
{
    public class CategoryApiController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
        [ActionName("MallCategory_Select")]
        public IHttpActionResult MallCategory_Select(MallCategoryModel mallCategoryModel)
        {
            CategoryBL bl = new CategoryBL();
            return Ok(bl.MallCategory_Select(mallCategoryModel));
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("Category_CUD")]
        public IHttpActionResult Category_CUD([FromBody] CategoryEntryModel categoryModel)
        {
            CategoryBL categoryBL = new CategoryBL();
            return Ok(categoryBL.Category_CUD(categoryModel));
        }

    }
}
