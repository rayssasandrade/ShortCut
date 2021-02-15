using SisGerenciador.src.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace SisGerenciador.src.Data
{
    public class ShortCutInitializer
    {
        public static void SeedInstituicao(MeuContexto context)
        {
            if (!context.Instituicoes.Any())
            {
                var instituicoes = new List<Instituicao>
            {
                new Instituicao { Id = 1, Sigla = "IFS", Descricao = "Instituto Federal de Ciência e Tecnologia de Sergipe"},
                new Instituicao { Id = 2, Sigla = "UFS", Descricao = "Universidade Federal de Sergipe"}
            };
                context.AddRange(instituicoes);
                context.SaveChanges();
            }
        }
    }
}
