namespace Objeto
{
    internal class Cachorro : ISer_Vivo
    {
        public void nascer() { Console.WriteLine("Meu pinscher nasceu, ele é muito pequeno"); }
        public void crescer() { Console.WriteLine("Ele não vai crescer mais do que isso não"); }
        public void reproduzir() { Console.WriteLine("Que lindo os filhotes que nasceu"); }
        public void morrer() { Console.WriteLine("Ele morreu"); }
    }
}
