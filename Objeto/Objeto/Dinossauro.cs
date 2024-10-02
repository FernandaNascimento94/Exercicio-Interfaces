namespace Objeto
{
    internal class Dinossauro: ISer_Vivo
    {
        public void nascer() { Console.WriteLine("Dinossaura nasceu"); }
        public void crescer() { Console.WriteLine("Dinossauro esta enorme"); }
        public void reproduzir() { Console.WriteLine("Que lindo os filhotes que nasceu, cuidado pra não morder"); }
        public void morrer() { Console.WriteLine("Ele morreu"); }
    }
}
