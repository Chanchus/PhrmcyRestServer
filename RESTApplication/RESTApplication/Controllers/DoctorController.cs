using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RESTApplication.Models;

/*namespace RESTApplication.Controllers
{
    [Produces("application/json")]
    [Route("api/Doctor")]
    public class DoctorController : Controller
    {
        private readonly PhischelDB context;

        public DoctorController(PhischelDB context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Doctor> GetClientes()
        {
            return context.Doctores.ToList();
        }


        [HttpGet("{nombre}", Name = "doctorCreado")]
        public IActionResult GetById(string nombre)
        {
            var cliente = context.Doctores.FirstOrDefault(x => x.nombre == nombre);

            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);

        }


        [HttpPost]
        public IActionResult Post([FromBody] Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                context.Doctores.Add(doctor);
                context.SaveChanges();
                return new CreatedAtRouteResult("doctorCreado", new { id = doctor.id }, doctor);
            }

            return BadRequest(ModelState);
        }


        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Cliente cliente, int id)
        {
            if (cliente.id != id)
            {
                return BadRequest();
            }

            context.Entry(cliente).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var cliente = context.Doctores.FirstOrDefault(x => x.id == id);

            if (cliente == null)
            {
                return NotFound();
            }

            context.Doctores.Remove(cliente);
            context.SaveChanges();
            return Ok(cliente);

        }

    }
}*/