namespace Aula02
{
    public class Cachorro : Mamifero
    {
        public string Raca { get; set; }
        public Cachorro(string nome, int idadeMedia, string raca) : base(nome, idadeMedia)
        {
            Raca = raca;
        }
        public override void EmitirSom()
        {
            Console.WriteLine($"AU AU AU");
        }
        public void Buscar()
        {
            Console.WriteLine($"{Nome} está buscando a bola.");
        }
    }
}
