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
    [Route("api/Farmacia/{Farmacia}/Cliente")]
    public class PedidoController : Controller
    {
        private readonly ApplicationDBContext context;

        public PedidoController(ApplicationDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Pedido> GetPedidos()
        {
            return context.Pedidos.ToList();
        }


        [HttpGet("{id}", Name = "pedidoCreado")]
        public IActionResult GetById(int id)
        {
            var pedido = context.Pedidos.FirstOrDefault(x => x.id == id);

            if (pedido == null)
            {
                return NotFound();
            }

            return Ok(pedido);

        }


        [HttpPost]
        public IActionResult Post([FromBody] Pedido pedido)
        {



            if (ModelState.IsValid)
            {
                context.Pedidos.Add(pedido);
                context.SaveChanges();
                return new CreatedAtRouteResult("pedidoCreado", new { id = pedido.id }, pedido);
            }



            return BadRequest(ModelState);
        }


        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Pedido pedido, int id)
        {
            if (pedido.id != id)
            {
                return BadRequest();
            }

            context.Entry(pedido).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pedido = context.Pedidos.FirstOrDefault(x => x.id == id);

            if (pedido == null)
            {
                return NotFound();
            }

            context.Pedidos.Remove(pedido);
            context.SaveChanges();
            return Ok(pedido);

        }

    }
}