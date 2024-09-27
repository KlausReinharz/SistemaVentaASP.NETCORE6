using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaVenta.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
//using SistemaVenta.DAL.Implementacion;
//using SistemaVenta.DAL.Interfaces;
//using SistemaVenta.BLL.Implementacion;
//using SistemaVenta.Bll.Interfaces;


namespace SistemaVenta.IOC
{
    public static class Dependencia
    {
        public static void InyectarDependecia(this IServiceCollection service, IConfiguration configuration){
            service.AddDbContext<dbVentasContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("CadenaSql"));
            });
        }
    }
}
