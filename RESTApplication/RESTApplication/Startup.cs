using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RESTApplication.Models;

namespace RESTApplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDBContext>(options =>
            options.UseInMemoryDatabase("FarmaciasDB"));



            services.AddMvc().AddJsonOptions(ConfigureJson);
                //.SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        private void ConfigureJson(MvcJsonOptions obj)
        {
            obj.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ApplicationDBContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();

            }

            app.UseHttpsRedirection();
            app.UseMvc();

            if (!context.Farmacias.Any())
            {
                context.Farmacias.AddRange(
                    new Farmacia() {

                        empresa = "Bomba Tica",
                        clientes = new List<Cliente>()
                    {
                        new Cliente(){nombre = "Pablo", apellidos = "esq mor", cedula = "2348489", nacimiento = "hoy", telefono = "89898898"},
                        new Cliente(){nombre = "marquito", apellidos = "riv", cedula = "2456679", nacimiento = "ayer", telefono = "89876598"}


                    },
                        doctores = new List<Doctor>()
                    {
                        new Doctor() { nombre = "marco", apellidos = "rivera", cedula = "2432423"},
                        new Doctor() { nombre = "Doctor1", apellidos = "esq mor", cedula = "2348489"}

                    },
                        pedidos = new List<Pedido>()
                    {
                        new Pedido() { medicamentos = "acetaminofen, tabcin",
                                        sucursal = "cartago", horaRecojo = "manana", receta =" el doctor dijo acetaminofen master race",
                                        cedulaCliente = "2348489" }

                    },
                    sucursales = new List<Sucursal>() { },

                    medicamentos = new List<Medicamento>()
                    {
                        new Medicamento() { farmaceutica = "fabricante??", nombre = "acetaminofen", prescripcion = "no", stock = 500},
                        new Medicamento() { farmaceutica = "fabricante??", nombre = "tabcin", prescripcion = "no", stock = 500}

                    }


                    });

                context.SaveChanges();
            }

  

        }
    }
}
