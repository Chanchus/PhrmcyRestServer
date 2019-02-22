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
    [Route("api/Cliente")]
    public class ClienteController : Controller
    {
        private readonly BombaTicaDB context;

        public ClienteController(BombaTicaDB context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Cliente> GetClientes()
        {
            return context.Clientes.ToList();
        }


        [HttpGet("{cedula}", Name = "clienteCreado")]
        public IActionResult GetById(string cedula)
        {
            var cliente = context.Clientes.FirstOrDefault(x => x.cedula == cedula);

            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);

        }


        [HttpPost]
        public IActionResult Post([FromBody] Cliente cliente)
        {


            
            if (ModelState.IsValid)
            {
                context.Clientes.Add(cliente);
                context.SaveChanges();
                return new CreatedAtRouteResult("clienteCreado", new { nombre = cliente.nombre }, cliente);
            }



            return BadRequest(ModelState);
        }


        [HttpPut("{cedula}")]
        public IActionResult Put([FromBody] Cliente cliente, string cedula)
        {
            if (cliente.cedula != cedula)
            {
                return BadRequest();
            }

            context.Entry(cliente).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }


        [HttpDelete("{cedula}")]
        public IActionResult Delete(string cedula)
        {
            var cliente = context.Clientes.FirstOrDefault(x => x.cedula == cedula);

            if (cliente == null)
            {
                return NotFound();
            }

            context.Clientes.Remove(cliente);
            context.SaveChanges();
            return Ok(cliente);

        }

    }
}*/