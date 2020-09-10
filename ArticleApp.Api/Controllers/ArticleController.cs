using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ArticleApp.Business.Abstract;
using ArticleApp.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArticleApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleServices _service;
        public int GetWriterID()
        {
            return int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
        }
        public ArticleController(IArticleServices service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("list")]
        public IActionResult Get()
        {
            var list = _service.GetAll();

            if (list.Count() > 0)
            {
                return Ok(list);
            }
            else
            {
                return NotFound();
            }
        }


        [HttpGet]
        [Route("CategoryById")]
        public IActionResult GetCategoriById(int id)
        {
            var articles = _service.GetAll().Where(a => a.CategoryID == id);

            if (articles != null)
            {
                return Ok(articles);
            }
            else
            {
                return NotFound();
            }
        }


        [HttpGet]
        [Route("Search")]
        public IActionResult Search(string text)
        {
            var search = _service.Search(text);

            if (search.Count() > 0)
            {
                return Ok(search);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [Route("AddEntity")]
        public IActionResult Add([FromBody] Article article)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                article.CreatedDate = DateTime.Now;
                article.WriterID = GetWriterID();
                article.IsActive = true;
                article.IsDeleted = false;

                _service.Add(article);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update(int articleID, [FromBody] Article article)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                try
                {
                    var model = _service.GetById(articleID);
                    if (model == null)
                    {
                        return NotFound();
                    }

                    else
                    {
                        if (model.WriterID != GetWriterID())
                        {
                            return BadRequest("Bu Makale Başka Bir yazarımıza aittir.");
                        }
                        article.WriterID = GetWriterID();
                        article.UpdatedDate = DateTime.Now;
                        article.ModifiedUser = GetWriterID();
                        _service.Update(article);
                        return Ok();
                    }
                }
                catch (Exception ex)
                {

                    return BadRequest(ex.Message);
                }
            }

        }

        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(Article entity)
        {
            try
            {

                _service.Delete(entity);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        
    }
}
