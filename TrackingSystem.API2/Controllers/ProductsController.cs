using TrackingSystem.Common.Contracts;
using Trackingsystem.Common.Filters;
using Trackingsystem.Model;
using Trackingsystem.Service.Contracts;
using System.Linq;
using System.Web.Http;

namespace TrackingSystem.API.Controllers
{
    public class ProductsController : ApiController
    {
        ILogService loggerService;
        IProductService _productservice;

        public ProductsController(ILogService loggerService, IProductService productService)
        {
            this.loggerService = loggerService;
            this._productservice = productService;
        }

        /// <summary>
        /// To fetch Product by Category ID
        /// </summary>
        /// <returns></returns>
        [EnableCors]
        public IQueryable<Product> GetProductByProductCategoryID(int id)
        {
            loggerService.Logger().Info("Calling with null parameter as : id : " + id);
            return _productservice.GetProductByProductCategoryID(id).AsQueryable<Product>();
        }

        /// <summary>
        /// To fetch all Product Categories
        /// </summary>
        /// <returns></returns>
        [EnableCors]
        public IQueryable<ProductCategory> GetProductCategories()
        {
            loggerService.Logger().Info("Calling with null parameter");
            return _productservice.GetProductCategories().AsQueryable<ProductCategory>();
        }

    }
}
