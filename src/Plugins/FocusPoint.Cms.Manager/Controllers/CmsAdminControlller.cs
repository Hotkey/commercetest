using FocusPoint.Cms.Manager.Models;
using Microsoft.AspNetCore.Mvc;
using Nop.Web.Areas.Admin.Controllers;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;

namespace FocusPoint.Cms.Manager.Controllers
{
    [AutoValidateAntiforgeryToken]
    [AuthorizeAdmin]
    [Area(AreaNames.Admin)]
    public class CmsAdminControlller : BasePluginController
    {
        #region Private Fields
        private IProductService _productService;
        #endregion

        #region Ctor
        public CmsAdminControlller(IProductService productService)
        {
            _productService = productService;
        }
        #endregion

        #region Methods
        public virtual async Task<IActionResult> GetAllProducts()
        {
            var products = await _productService.GetAllProductsDisplayedOnHomepageAsync();
            return Json(products);
        }

        [Obsolete]
        public async Task<IActionResult> DesignCreator()
        {
            var model = new DesignCreatorMasterModel();

            return View("~/Plugins/FocusPoint.Cms.Manager/Views/CmsAdmin/DesignCreator.cshtml", model);
        }

        #endregion
    }
}
