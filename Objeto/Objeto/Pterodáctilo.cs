namespace Objeto
{
    internal class Pterodáctilo : Dinossauro, IVoador
    {
        public void Voar() { Console.WriteLine("Cuidado, com o Pterodáctilo, ele esta voando atras de você"); }
        public void pousar() { Console.WriteLine("O Pterodáctilo esta pousando"); }
        public void decolar() { Console.WriteLine("O Pterodáctilo decolou"); }
    }
}
