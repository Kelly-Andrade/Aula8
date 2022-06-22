namespace Exercicio3
{
    public class MundoAnimal
    {
        Peixe peixe = new Peixe("Nemo", 0, "laranja e branco", "mar", 5, "Peixe palhaço");
        Mamifero mamifero = new Mamifero("Cavalo", 4, "preto", "terrestre", 30, "Capim");

        public MundoAnimal()
        {
            peixe.Imprimir();
            mamifero.Imprimir();
        }
        
    }
}
