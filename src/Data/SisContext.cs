using SisGerenciador.src.Models;
using Microsoft.EntityFrameworkCore;

namespace SisGerenciador.src.Data
{
    public class SisContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<DisciplinaOfertada> DisciplinaOfertadas { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<GradeCurricular> GradeCurriculars { get; set; }
        public DbSet<HoraAula> HoraAulas { get; set; }
        public DbSet<Horario> Horarios { get; set; }
        public DbSet<Instituicao> Instituicoes { get; set; }
        public DbSet<MatriculaTurma> MatriculaTurmas { get; set; }
        public DbSet<PeriodoCurricular> PeriodoCurriculares { get; set; }
        public DbSet<PeriodoLetivo> PeriodoLetivos { get; set; }
        public DbSet<PreRequisito> PreRequisitos { get; set; }
        public DbSet<Restricao> Restricoes { get; set; }
        public DbSet<SugestaoMatricula> SugestaoMatriculas { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<TurmaHorario> TurmaHorarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;User ID=ITSOLVED;Initial Catalog=HeroApp;Data Source=LAPTOP-DP2K66C3\SQLEXPRESS");
        }
    }
}