namespace ProjetoGracieBarraCamargos.Models
{
    public class Presenca
    {
        public int Id { get; set; }
        public int TreinoId { get; set; }
        public int AlunoId { get; set; }
        public bool Confirmado { get; set; }

        public Treino Treino { get; set; }
    }
}
