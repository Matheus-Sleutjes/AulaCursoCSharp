// Introducao a Programacao Orientada a Objetos - POO

// Quais os 4 pilares da POO?
// 1. Abstração
// 2. Encapsulamento
// 3. Herança
// 4. Polimorfismo

using Aula02;

Mamifero cachorro = new Mamifero("Cachorro", 15);
cachorro.Comer();
cachorro.Dormir();
cachorro.EmitirSom();


Cachorro doguinho = new Cachorro("Rex", 12, "Labrador");
doguinho.Dormir();
doguinho.Comer();
doguinho.EmitirSom();
doguinho.Buscar();


Vaca vacaMimosa = new Vaca("Mimosa", 20, true);
vacaMimosa.Dormir();
vacaMimosa.Comer();
vacaMimosa.EmitirSom();
vacaMimosa.ProduzirLeite();

Console.Read();
