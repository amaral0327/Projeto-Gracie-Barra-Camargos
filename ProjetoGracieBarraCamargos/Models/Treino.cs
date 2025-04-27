namespace ProjetoGracieBarraCamargos.Models
{
    public class Treino
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public string Tipo { get; set; } //No Gi ou Kimono
        public string Categoria { get; set; } //GB1, GB Kids, GB2
    }
}
