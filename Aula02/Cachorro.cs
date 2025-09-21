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
            Console.WriteLine($" o cachorro da raça {Raca}, está latindo.");
        }
        public void Buscar()
        {
            Console.WriteLine($"{Nome} está buscando a bola.");
        }
    }
}
