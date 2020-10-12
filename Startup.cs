using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ColorPicker.data;
using ColorPicker.Data;
using ColorPicker.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

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

      services.AddControllers();

      services.AddScoped<IColorPickerRepo, MockColorPickerRepo>();



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
