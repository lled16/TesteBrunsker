namespace locamais.Models
{
    public class cadImovel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string ValorAluguel { get; set; }
        public string Endereco { get; set; }
        public string Disponibilidade { get; set; }
        public int QtdQuartos {get; set; }
        public int QtdBanheiros { get; set; }
        public string InfoAdicionais { get; set; }
        public string NomeLocatario { get; set; }
        public string NumeroLocatario { get; set; }
        public string CpfLocatario { get; set; }
    }
}
