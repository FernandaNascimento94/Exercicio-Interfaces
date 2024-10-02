namespace Objeto
{
    public class Avião : IVoador, IMaquina
    {
        public void ligar() { Console.WriteLine("Ovni esta ligado"); }
        public void pousar() { Console.WriteLine("Ovni estar pronto pra decolar"); }
        public void desligar() { Console.WriteLine("Ovni esta deslinado, Ora de descansar"); }
        public void Voar() { Console.WriteLine("Ovni esta voando"); }
        public void decolar() { Console.WriteLine("Ovni vamos viajar"); }
    }
}