using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using AutoMapper;
using BookingBoss.Domain;
using BookingBoss.Service;
using BookingBossTest.Model;

namespace BookingBossTest
{
    [Authorize]
    public class ProductController : ApiController
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            var products = await _productService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<ProductModel>>(products));
        }

        [HttpPut]
        public async Task<IHttpActionResult> Put(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                var product = _mapper.Map<ProductEntity>(model);

                await _productService.CreateAsync(product);
                return Ok("Done.");
            }

            return BadRequest(ModelState);
        } 
    }
}