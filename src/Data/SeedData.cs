using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SisGerenciador.src.Models;

namespace SisGerenciador.src.Data
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
                        new Departamento { Sigla = "BSI", Descricao = "Bacharelado de Sistema de Informação"}
                    };

                    context.Departamentos.AddRange(departamentos);
                    context.SaveChanges();
                }
                if (!context.Instituicoes.Any())
                {
                    var instituicoes = new List<Instituicao>
                    {
                        new Instituicao { Sigla = "IFS", Descricao = "Instituto Federal de Ciência e Tecnologia de Sergipe"},
                        new Instituicao { Sigla = "UFS", Descricao = "Universidade Federal de Sergipe"}
                    };

                    context.Instituicoes.AddRange(instituicoes);
                    context.SaveChanges();
                }
            }
        }
    }
}
