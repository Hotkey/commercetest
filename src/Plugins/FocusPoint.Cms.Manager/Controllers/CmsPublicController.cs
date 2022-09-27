using Microsoft.AspNetCore.Mvc;
using Nop.Web.Controllers;

namespace FocusPoint.Cms.Manager.Controllers
{
    public class CmsPublicController : BasePublicController
    {
        #region Private Fields
        private IProductService _productService;
        #endregion

        #region Ctor
        public CmsPublicController(IProductService productService)
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
        #endregion
    }
}
