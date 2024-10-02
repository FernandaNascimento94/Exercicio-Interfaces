namespace Objeto
{
    internal class Passarinhos : IVoador, ISer_Vivo
    {
        public void nascer() { Console.WriteLine("Passarinho Nasceu"); }
        public void crescer() { Console.WriteLine("Passarinho ta crescendo, que cores lindas"); }
        public void reproduzir() { Console.WriteLine("Passarinho teve filhotes carecas "); }
        public void morrer() { Console.WriteLine("Passarinho morreu, que trite"); }
        public void Voar() { Console.WriteLine("Passarinho Voou"); }
        public void decolar() { Console.WriteLine("Passarinho decolou"); }
        public void pousar() { Console.WriteLine("O passarinho vai parar para comer"); }
    }
}
