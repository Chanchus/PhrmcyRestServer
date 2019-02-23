using System;
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
    [Route("api/Farmacia/{Farmacia}/Medicamento")]
    public class MedicamentoController : Controller
    {
        private readonly ApplicationDBContext context;

        public MedicamentoController(ApplicationDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Medicamento> GetMedicamentos()
        {
            return context.Medicamentos.ToList();
        }


        [HttpGet("{nombre}", Name = "medicamentoCreado")]
        public IActionResult GetById(string nombre)
        {
            var medicamento = context.Medicamentos.FirstOrDefault(x => x.nombre == nombre);

            if (medicamento == null)
            {
                return NotFound();
            }

            return Ok(medicamento);

        }


        [HttpPost]
        public IActionResult Post([FromBody] Medicamento medicamento)
        {



            if (ModelState.IsValid)
            {
                context.Medicamentos.Add(medicamento);
                context.SaveChanges();
                return new CreatedAtRouteResult("medicamentoCreado", new { nombre = medicamento.nombre }, medicamento);
            }



            return BadRequest(ModelState);
        }


        [HttpPut("{nombre}")]
        public IActionResult Put([FromBody] Medicamento medicamento, string nombre)
        {
            if (medicamento.nombre != nombre)
            {
                return BadRequest();
            }

            context.Entry(medicamento).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }


        [HttpDelete("{nombre}")]
        public IActionResult Delete(string nombre)
        {
            var medicamento = context.Medicamentos.FirstOrDefault(x => x.nombre == nombre);

            if (medicamento == null)
            {
                return NotFound();
            }

            context.Medicamentos.Remove(medicamento);
            context.SaveChanges();
            return Ok(medicamento);

        }

    }
}