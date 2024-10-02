namespace Objeto
{
    internal class Gato : ISer_Vivo
    {
        public void nascer() { Console.WriteLine("Meu nasceu bem branquinho"); }
        public void crescer() { Console.WriteLine("Ele esta crescendo com cor diferente"); }
        public void reproduzir() { Console.WriteLine("Lindos filhotes mais não pode mexer"); }
        public void morrer() { Console.WriteLine("Ele morreu em baixo do sofa"); }
    }
}
