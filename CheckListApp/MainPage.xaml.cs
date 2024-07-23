using Microsoft.EntityFrameworkCore;
using CheckListApp.Data;

namespace CheckListApp
{
    public partial class MainPage : ContentPage
    {
        public readonly AppDbContext _dbContext;

        public MainPage(AppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            CarregarChecklist();
        }

        private void CarregarChecklist()
        {
            var itens = _dbContext.ChecklistItens.Include(ci => ci.Categoria).ToList();
            var itensAgrupados = itens
                .GroupBy(item => item.Categoria)
                .Select(group => new
                {
                    Categoria = group.Key,
                    Itens = group.ToList()
                });

            ChecklistCollectionView.ItemsSource = itensAgrupados;
        }
    }

}
