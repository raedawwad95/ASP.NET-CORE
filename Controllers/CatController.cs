using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myFirstProject.Models;
using Microsoft.Extensions.Configuration;

namespace firstProjectWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/cat")]
    [ApiController]
	public class CatController : Controller
	{	
		//cats List
		//public static List <Cat> cats = new List<Cat>();

        private readonly CatInterface _CatInterfaceImplement;
        private readonly IConfiguration _config;

        public CatController(IConfiguration configuration, CatInterface CatInterfaceImplement)
        {
            _CatInterfaceImplement = CatInterfaceImplement;
            _config = configuration;
        }

        // GET api/cat/
        //your code is here uncomment this method and write the required code to handle get request
        [HttpGet]
		 public async Task<IEnumerable<Cat>> GetAll()
		 {
            return await _CatInterfaceImplement.GetAll();
        }

        
        // POST api/cat
		[HttpPost]
        public async Task<IActionResult> Post([FromBody] Cat newCat)
        {
            try
            {
                await _CatInterfaceImplement.insertCat(new Cat
                {
                    Name = newCat.Name,
                    CreatedOn = DateTime.Now,
                    Age = newCat.Age
                });
                return Ok("Your Cat has been added successfully");
            }
                
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // PUT api/cat/name
		[HttpPut("{name}")]
		public void Put(string id, [FromBody] string name)
		{
            _CatInterfaceImplement.UpdateCat(id, name);
		}

        // DELETE api/cat/1

		[HttpDelete("{name}")]
		public void Delete(string name)
		{
            _CatInterfaceImplement.RemoveCat(name);
		}


	}
}