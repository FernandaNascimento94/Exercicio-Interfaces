namespace Objeto
{
    internal class Helicoptero: IPairador, IMaquina
    {
        public void pairar() { Console.WriteLine("O helicoptero esta parado"); }
        public void pousar() { Console.WriteLine("O helicoptero pousou"); }
        public void Voar() { Console.WriteLine("O helicoptero esta sobrevoando"); }
        public void decolar() { Console.WriteLine("O helicoptero esta"); }
        public void ligar() { Console.WriteLine("O helicoptero esta ligando, ora de decolar"); }
        public void desligar() { Console.WriteLine("o helicoptero esta desligando"); }
    }
}
