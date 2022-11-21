using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Reflection;

namespace PetAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers().AddNewtonsoftJson(c =>
            {
                c.SerializerSettings.Converters.Add(new StringEnumConverter
                {
                    NamingStrategy=new CamelCaseNamingStrategy()
                });
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            builder.Services.AddEndpointsApiExplorer()
                            .AddSwaggerGen(c =>
                                            {
                                                c.SwaggerDoc("v1", new OpenApiInfo
                                                {
                                                    Title = "Pet Store API",
                                                    Version = "v1",
                                                    Contact = new OpenApiContact
                                                    {
                                                        Email = "testemail@email.me",
                                                        Name = "Rachel Breeze"
                                                    },
                                                    Description = "This is a sample Pet Store Server based on the OpenAPI 3.0 specification.",
                                                    License = new OpenApiLicense
                                                    {
                                                        Name = "Apache 2.0",
                                                        Url =new Uri("http://www.apache.org/licenses/LICENSE-2.0.html")
                                                    }
                                                });
                                                c.IncludeXmlComments(xmlPath, includeControllerXmlComments: true);
                                                c.UseInlineDefinitionsForEnums();
                                            })
                            .AddSwaggerGenNewtonsoftSupport();


            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();
            app.Run();
        }
    }
}