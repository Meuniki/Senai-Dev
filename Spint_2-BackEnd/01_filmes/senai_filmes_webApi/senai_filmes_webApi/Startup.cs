using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
//using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webApi
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Define o uso de Controllers
            services.AddControllers();

            //services
            //    // Define a forma de autenticação
            //    .AddAuthentication(options =>
            //    {
            //        options.DefaultAuthenticateScheme = "JwtBearer";
            //        options.DefaultChallengeScheme = "JwtBearer";
            //    })

                //// Define os parâmetros de validação do token
                //.AddJwtBearer("JwtBearer", options =>
                //{
                //    options.TokenValidationParameters = new TokenValidationParameters
                //    {
                //        //quem está emitindo
                //        ValidateIssuer = true,

                //        // quem está recebendo
                //        ValidateAudience = true,

                //        // o tempo de expiração
                //        ValidateLifetime = true,

                //        // forma de criptografia e a chave de autenticação
                //        IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("filmes-chave-autenticacao")),

                //        // tempo de expiração do token
                //        ClockSkew = TimeSpan.FromMinutes(30),

                //        // nome do issuer, de onde está vindo
                //        ValidIssuer = "Filmes.webApi",

                //        // nome do audience, para onde está indo
                //        ValidAudience = "Filmes.webApi"
                //    };
                //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // Habilita a autenticação
            app.UseAuthentication();

            // Habilita a autorização
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                // Define o mapeamento dos controles
                endpoints.MapControllers();
            });
        }
    }
}
