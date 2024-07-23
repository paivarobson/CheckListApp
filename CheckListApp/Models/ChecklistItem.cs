namespace CheckListApp.Models
{
    public class ChecklistItem
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria{ get; set; }
    }
}

