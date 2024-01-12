using HomeWork34.Dbdata;
using HomeWork34.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork34.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class Odev10Controller : ControllerBase
    {
        private readonly RdmLevelSession _context;

        public Odev10Controller(RdmLevelSession context)
        {
            _context = context;
        }

        [HttpGet]
       public List<Customers> Banagetir()
        {
            List<Customers> data = _context.Customers.ToList();
            return data;
        }

        [HttpPost]
        public IActionResult ByidGetir(Customers model) //Burada Sorun var hocam bir türlü baslatamadım. 
        {
            var finduser = _context.Customers.FirstOrDefault(p=> p.CustomerID == model.CustomerID);

            if(finduser == null)
            {
                return NotFound();
            }
            

            return Ok(finduser);

        }

       
    }
}
