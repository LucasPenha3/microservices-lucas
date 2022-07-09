using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository ??
                throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductVO>> FindById(long id)
        {
            var product = await _repository.FindByID(id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductVO>>> FindAll()
        {
            IEnumerable<ProductVO> products = await _repository.FindAll();
            
            return Ok(products);
        }

        [HttpPost]
        public async Task<ActionResult<ProductVO>> Create(ProductVO produtoVO)
        {
            if(produtoVO == null)
                return BadRequest();

            var product = await _repository.Create(produtoVO);
            return Ok(product);

        }

        [HttpPut]
        public async Task<ActionResult<ProductVO>> Update(ProductVO produtoVO)
        {
            if (produtoVO == null)
                return BadRequest();

            var product = await _repository.Update(produtoVO);
            return Ok(product);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var status = await _repository.Delete(id);
            if (!status)
                return BadRequest();

            return Ok(status);
        }
            
    }
}
