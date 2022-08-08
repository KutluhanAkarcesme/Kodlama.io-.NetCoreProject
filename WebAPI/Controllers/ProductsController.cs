using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramewrok;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase 
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _productService.GetAll();
            if (result.Succes == true)
            {
                return Ok(result);
            }
            return BadRequest(result.Message); 
        }
        [HttpGet("getbyid")]
        public IActionResult GetListById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Succes)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpGet("getlistbycategory")]
        public IActionResult GetListByCategory(int categoryId)
        {
            var result = _productService.GetAllByCategoryId(categoryId);
            if (result.Succes)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Succes == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Product product)
        {
            var result = _productService.Update(product);
            if (result.Succes)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Product product)
        {
            var result = _productService.Delete(product);
            if (result.Succes)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("transaction")]
        public IActionResult TransactionTest(Product product)
        {
            var result = _productService.TransactionalTest(product);
            if (result.Succes)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
