using CheckListApp.Models;
using Microsoft.EntityFrameworkCore;
using CheckListApp.Data;

namespace CheckListApp.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                context.Database.Migrate();

                if (!context.Categorias.Any())
                {
                    context.Categorias.AddRange(
                        new Categoria { Id = 1, Nome = "Documentação" },
                        new Categoria { Id = 2, Nome = "Pintura" },
                        new Categoria { Id = 3, Nome = "Vidros" });
                }

                context.SaveChanges();

                if (!context.ChecklistItens.Any())
                {
                    context.ChecklistItens.AddRange(
                        new ChecklistItem { Id = 1, Descricao = "Conferência do número da placa dianteira", CategoriaId = 1 },
                        new ChecklistItem { Id = 2, Descricao = "Conferência do número da placa traseira", CategoriaId = 1 },
                        new ChecklistItem { Id = 3, Descricao = "Número de chassi no assoalho do carro", CategoriaId = 1 },
                        new ChecklistItem { Id = 4, Descricao = "Etiquetas ETA no motor", CategoriaId = 1 },
                        new ChecklistItem { Id = 5, Descricao = "Verificação do capô", CategoriaId = 2 },
                        new ChecklistItem { Id = 6, Descricao = "Verificação do teto", CategoriaId = 2 },
                        new ChecklistItem { Id = 7, Descricao = "Verificação dos paralamas dianteiros", CategoriaId = 2 },
                        new ChecklistItem { Id = 8, Descricao = "Verificação dos paralamas traseiros", CategoriaId = 2 },
                        new ChecklistItem { Id = 9, Descricao = "Verificação das portas dianteiras", CategoriaId = 2 },
                        new ChecklistItem { Id = 10, Descricao = "Verificação das portas traseiras", CategoriaId = 2 },
                        new ChecklistItem { Id = 11, Descricao = "Verificação da tampa do porta-malas", CategoriaId = 2 },
                        new ChecklistItem { Id = 12, Descricao = "Ano e mês de fabricação do parabrisa", CategoriaId = 3 },
                        new ChecklistItem { Id = 13, Descricao = "Janela da porta dianteira", CategoriaId = 3 },
                        new ChecklistItem { Id = 14, Descricao = "Janela da porta traseira", CategoriaId = 3 },
                        new ChecklistItem { Id = 15, Descricao = "Vidro traseiro", CategoriaId = 3 }
                    );

                    context.SaveChanges();
                }
            }
        }
    }
}

