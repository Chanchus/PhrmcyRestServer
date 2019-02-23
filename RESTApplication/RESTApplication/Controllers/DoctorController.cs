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
    [Route("api/Farmacia/{Farmacia}/Doctor")]
    public class DoctorController : Controller
    {
        private readonly ApplicationDBContext context;

        public DoctorController(ApplicationDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Doctor> GetDoctores()
        {
            return context.Doctores.ToList();
        }


        [HttpGet("{cedula}", Name = "doctorCreado")]
        public IActionResult GetById(string cedula)
        {
            var doctor = context.Doctores.FirstOrDefault(x => x.cedula == cedula);

            if (doctor == null)
            {
                return NotFound();
            }

            return Ok(doctor);

        }


        [HttpPost]
        public IActionResult Post([FromBody] Doctor doctor)
        {



            if (ModelState.IsValid)
            {
                context.Doctores.Add(doctor);
                context.SaveChanges();
                return new CreatedAtRouteResult("doctorCreado", new { cedula = doctor.cedula }, doctor);
            }



            return BadRequest(ModelState);
        }


        [HttpPut("{cedula}")]
        public IActionResult Put([FromBody] Doctor doctor, string cedula)
        {
            if (doctor.cedula != cedula)
            {
                return BadRequest();
            }

            context.Entry(doctor).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }


        [HttpDelete("{cedula}")]
        public IActionResult Delete(string cedula)
        {
            var doctor = context.Doctores.FirstOrDefault(x => x.cedula == cedula);

            if (doctor == null)
            {
                return NotFound();
            }

            context.Doctores.Remove(doctor);
            context.SaveChanges();
            return Ok(doctor);

        }

    }
}