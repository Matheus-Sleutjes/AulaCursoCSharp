namespace Aula02
{
    public class Vaca : Mamifero
    {
        public string Nome { get; set; }
        public int IdadeMedia { get; set; }
        public bool TemChifre { get; set; }
        public Vaca(string nome, int idadeMedia, bool temChifre) : base(nome, idadeMedia)
        {
            TemChifre = temChifre;
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"MUUUUUUU");
        }

        public void ProduzirLeite()
        {
            Console.WriteLine($"{Nome} está produzindo leite.");
        }
    }
}
