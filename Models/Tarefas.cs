namespace Minha_API.Models
{
    public class Tarefas
    {
        public int id { get; set; }
        public int Id { get; internal set; }
        public string Titulo { get; set; }
        public bool Concluida { get; set; }
    }
}
