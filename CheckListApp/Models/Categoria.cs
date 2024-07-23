using System;
namespace CheckListApp.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<ChecklistItem> ChecklistItens { get; set; }
    }
}

