namespace Aula02
{
    public class Mamifero
    {
        public string Nome { get; set; }
        public int IdadeMedia { get; set; }
        public Mamifero(string nome, int idadeMedia)
        {
            Nome = nome;
            IdadeMedia = idadeMedia;
        }

        public void Dormir()
        {
            Console.WriteLine($"{Nome} está dormindo.");
        }

        public void Comer()
        {
            Console.WriteLine($"{Nome} está comendo.");
        }

        public virtual void EmitirSom()
        {
            Console.WriteLine($"{Nome} está emitindo um som genérico de mamífero.");
        }
    }
}
