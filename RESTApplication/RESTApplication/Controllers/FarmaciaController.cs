﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RESTApplication.Models;

namespace RESTApplication.Controllers
{
    [Produces("application/json")]
    [Route("api/farmacia")]
    public class FarmaciaController : Controller
    {
        private readonly BombaTicaDBContext context;

        public FarmaciaController(BombaTicaDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Farmacia> GetFarmacias()
        {
            return context.bombaTicaDB.ToList();
        }


        [HttpGet("{empresa}", Name = "farmaciaCreada")]
        public IActionResult GetById(string empresa)
        {
            var farmacia = context.bombaTicaDB.Include(x => x.clientes).FirstOrDefault(x => x.empresa == empresa);

            if (farmacia == null)
            {
                return NotFound();
            }

            return Ok(farmacia);

        }


        [HttpPost]
        public IActionResult Post([FromBody] Farmacia farmacia)
        {



            if (ModelState.IsValid)
            {
                context.bombaTicaDB.Add(farmacia);
                context.SaveChanges();
                return new CreatedAtRouteResult("farmaciaCreada", new { nombre = farmacia.empresa }, farmacia);
            }



            return BadRequest(ModelState);
        }


        [HttpPut("{nombre}")]
        public IActionResult Put([FromBody] Farmacia farmacia, string nombre)
        {
            if (farmacia.empresa != nombre)
            {
                return BadRequest();
            }

            context.Entry(farmacia).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }


        [HttpDelete("{nombre}")]
        public IActionResult Delete(string nombre)
        {
            var farmacia = context.bombaTicaDB.FirstOrDefault(x => x.empresa == nombre);

            if (farmacia == null)
            {
                return NotFound();
            }

            context.bombaTicaDB.Remove(farmacia);
            context.SaveChanges();
            return Ok(farmacia);

        }

    }
}