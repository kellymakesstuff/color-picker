using System;
using ColorPicker.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Newtonsoft.Json.Serialization;


namespace ColorPicker
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }


    public void ConfigureServices(IServiceCollection services)
    {

      services.AddEntityFrameworkNpgsql().AddDbContext<ColorPickerContext>(opt =>
            opt.UseNpgsql(Configuration.GetConnectionString("ColorPickerConnection")));

      services.AddControllers().AddNewtonsoftJson(s =>
      {
        s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
      });

      services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

      services.AddScoped<IColorPickerRepo, SqlColorPickerRepo>();

    }


    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();

      }

      app.UseHttpsRedirection();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}

