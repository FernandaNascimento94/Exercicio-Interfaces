namespace Objeto
{
    internal class Disco_voador:IPairador,IMaquina
    {
        public void pairar() { Console.WriteLine("Disco voador esta parado"); }
        public void pousar() { Console.WriteLine("Disco Voador pronto para pousar"); }
        public void ligar() { Console.WriteLine("Estou ligando o Disco Voador"); }
        public void desligar() { Console.WriteLine("Disco voador desligando, hora de dormir"); }
        public void decolar() { Console.WriteLine("Disco voador,vamos decolar"); }
        public void Voar() { Console.WriteLine("Disco voador, vamos voar"); }
    }
}