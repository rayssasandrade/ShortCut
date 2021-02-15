using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SisGerenciador.src.Data;

namespace SisGerenciador.Migrations
{
    [DbContext(typeof(MeuContexto))]
    partial class MeuContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("SisGerenciador.src.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime>("DtMatricula")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DtNasc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Endereco")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("InstituicaoId")
                        .HasColumnType("int");

                    b.Property<int>("Matricula")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Telefone")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("InstituicaoId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("InstituicaoId")
                        .HasColumnType("int");

                    b.Property<int>("LimiteQtdPeriodoCurricular")
                        .HasColumnType("int");

                    b.Property<int>("QtdPeriodo")
                        .HasColumnType("int");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.HasIndex("InstituicaoId");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Credito")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Disciplinas");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.DisciplinaOfertada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("int");

                    b.Property<int>("PeriodoLetivoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DisciplinaId");

                    b.HasIndex("PeriodoLetivoId");

                    b.ToTable("DisciplinaOfertadas");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.Docente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CPF")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime>("DtMatricula")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Endereco")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("InstituicaoId")
                        .HasColumnType("int");

                    b.Property<int>("Matricula")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("InstituicaoId");

                    b.ToTable("Docentes");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.GradeCurricular", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("int");

                    b.Property<int>("PeriodoCurricularId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("DisciplinaId");

                    b.HasIndex("PeriodoCurricularId");

                    b.ToTable("GradeCurriculars");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.HoraAula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("DtFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DtInicio")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("HoraAulas");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.Horario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("DiaSemana")
                        .HasColumnType("int");

                    b.Property<int>("HoraAulaId")
                        .HasColumnType("int");

                    b.Property<int>("Turno")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HoraAulaId");

                    b.ToTable("Horarios");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.Instituicao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.ToTable("Instituicoes");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.MatriculaDisciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("MatriculaTurmas");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.PeriodoCurricular", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("NumOrdinal")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PeriodoCurriculares");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.PeriodoLetivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("DtFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DtInicio")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PeriodoLetivos");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.PreRequisito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("LiberadaId")
                        .HasColumnType("int");

                    b.Property<int>("LiberadoraId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LiberadaId");

                    b.HasIndex("LiberadoraId");

                    b.ToTable("PreRequisitos");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.Restricao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int>("HorarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("HorarioId");

                    b.ToTable("Restricoes");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.Turma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("DisciplinaOfertadaId")
                        .HasColumnType("int");

                    b.Property<int>("DocenteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DisciplinaOfertadaId");

                    b.HasIndex("DocenteId");

                    b.ToTable("Turmas");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.TurmaHorario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("HorarioId")
                        .HasColumnType("int");

                    b.Property<int>("TurmaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HorarioId");

                    b.HasIndex("TurmaId");

                    b.ToTable("TurmaHorarios");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.Aluno", b =>
                {
                    b.HasOne("SisGerenciador.src.Models.Instituicao", "Instituicao")
                        .WithMany("Alunos")
                        .HasForeignKey("InstituicaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instituicao");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.Curso", b =>
                {
                    b.HasOne("SisGerenciador.src.Models.Departamento", "Departamento")
                        .WithMany("Cursos")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SisGerenciador.src.Models.Instituicao", "Instituicao")
                        .WithMany()
                        .HasForeignKey("InstituicaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");

                    b.Navigation("Instituicao");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.DisciplinaOfertada", b =>
                {
                    b.HasOne("SisGerenciador.src.Models.Disciplina", "Disciplina")
                        .WithMany("DisciplinaOfertadas")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SisGerenciador.src.Models.PeriodoLetivo", "PeriodoLetivo")
                        .WithMany("DisciplinasOfertadas")
                        .HasForeignKey("PeriodoLetivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disciplina");

                    b.Navigation("PeriodoLetivo");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.Docente", b =>
                {
                    b.HasOne("SisGerenciador.src.Models.Instituicao", "Instituicao")
                        .WithMany("Docentes")
                        .HasForeignKey("InstituicaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instituicao");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.GradeCurricular", b =>
                {
                    b.HasOne("SisGerenciador.src.Models.Curso", "Curso")
                        .WithMany("GradesCurriculares")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SisGerenciador.src.Models.Disciplina", "Disciplina")
                        .WithMany("GradeCurriculares")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SisGerenciador.src.Models.PeriodoCurricular", "PeriodoCurricular")
                        .WithMany("GradesCurriculares")
                        .HasForeignKey("PeriodoCurricularId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Disciplina");

                    b.Navigation("PeriodoCurricular");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.Horario", b =>
                {
                    b.HasOne("SisGerenciador.src.Models.HoraAula", "HoraAula")
                        .WithMany("Horarios")
                        .HasForeignKey("HoraAulaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoraAula");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.MatriculaDisciplina", b =>
                {
                    b.HasOne("SisGerenciador.src.Models.Aluno", "Aluno")
                        .WithMany("MatriculaDisciplinas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SisGerenciador.src.Models.Disciplina", "Disciplina")
                        .WithMany("MatriculaDisciplinas")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Disciplina");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.PreRequisito", b =>
                {
                    b.HasOne("SisGerenciador.src.Models.Disciplina", "Liberada")
                        .WithMany("Liberadas")
                        .HasForeignKey("LiberadaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SisGerenciador.src.Models.Disciplina", "Liberadora")
                        .WithMany("Liberadoras")
                        .HasForeignKey("LiberadoraId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Liberada");

                    b.Navigation("Liberadora");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.Restricao", b =>
                {
                    b.HasOne("SisGerenciador.src.Models.Aluno", "Aluno")
                        .WithMany("Restricoes")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SisGerenciador.src.Models.Horario", "Horario")
                        .WithMany("Restricoes")
                        .HasForeignKey("HorarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Horario");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.Turma", b =>
                {
                    b.HasOne("SisGerenciador.src.Models.DisciplinaOfertada", "DisciplinaOfertada")
                        .WithMany("Turmas")
                        .HasForeignKey("DisciplinaOfertadaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SisGerenciador.src.Models.Docente", "Docente")
                        .WithMany("Turmas")
                        .HasForeignKey("DocenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DisciplinaOfertada");

                    b.Navigation("Docente");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.TurmaHorario", b =>
                {
                    b.HasOne("SisGerenciador.src.Models.Horario", "Horario")
                        .WithMany("TurmaHorarios")
                        .HasForeignKey("HorarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SisGerenciador.src.Models.Turma", "Turma")
                        .WithMany("TurmaHorarios")
                        .HasForeignKey("TurmaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Horario");

                    b.Navigation("Turma");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.Aluno", b =>
                {
                    b.Navigation("MatriculaDisciplinas");

                    b.Navigation("Restricoes");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.Curso", b =>
                {
                    b.Navigation("GradesCurriculares");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.Departamento", b =>
                {
                    b.Navigation("Cursos");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.Disciplina", b =>
                {
                    b.Navigation("DisciplinaOfertadas");

                    b.Navigation("GradeCurriculares");

                    b.Navigation("Liberadas");

                    b.Navigation("Liberadoras");

                    b.Navigation("MatriculaDisciplinas");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.DisciplinaOfertada", b =>
                {
                    b.Navigation("Turmas");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.Docente", b =>
                {
                    b.Navigation("Turmas");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.HoraAula", b =>
                {
                    b.Navigation("Horarios");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.Horario", b =>
                {
                    b.Navigation("Restricoes");

                    b.Navigation("TurmaHorarios");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.Instituicao", b =>
                {
                    b.Navigation("Alunos");

                    b.Navigation("Docentes");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.PeriodoCurricular", b =>
                {
                    b.Navigation("GradesCurriculares");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.PeriodoLetivo", b =>
                {
                    b.Navigation("DisciplinasOfertadas");
                });

            modelBuilder.Entity("SisGerenciador.src.Models.Turma", b =>
                {
                    b.Navigation("TurmaHorarios");
                });
#pragma warning restore 612, 618
        }
    }
}