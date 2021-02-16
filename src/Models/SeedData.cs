using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SisGerenciador.src.Data;
using SisGerenciador.src.Models;

namespace SisGerenciador.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MeuContexto(
                    serviceProvider.GetRequiredService<
                        DbContextOptions<MeuContexto>>()))
            {
                if (!context.Departamentos.Any())
                {
                    var departamentos = new List<Departamento>
                    {
                        new Departamento { Sigla = "DP1", Descricao = "Descrição do Departamento1"},
                        new Departamento { Sigla = "DP2", Descricao = "Descrição do Departamento2"},
                        new Departamento { Sigla = "DP3", Descricao = "Descrição do Departamento3"}
                    };

                    context.Departamentos.AddRange(departamentos);
                    context.SaveChanges();
                }
            }
        }
    }
}
