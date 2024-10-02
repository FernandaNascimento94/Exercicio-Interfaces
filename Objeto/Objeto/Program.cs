// See https://aka.ms/new-console-template for more information
using Objeto;

Console.WriteLine("Hello, World!");

List<object> meusObjetos = new List<object>();

meusObjetos.Add(new Passarinhos());
meusObjetos.Add(new Avião());
meusObjetos.Add(new Super_man());
meusObjetos.Add(new Fantasma());
meusObjetos.Add(new Helicoptero());
meusObjetos.Add(new Beija_flor());
meusObjetos.Add(new Disco_voador());
meusObjetos.Add(new Cachorro());
meusObjetos.Add(new Gato());
meusObjetos.Add(new Dinossauro());
meusObjetos.Add(new Carro());
meusObjetos.Add(new Trem());
meusObjetos.Add(new Zumbi());
meusObjetos.Add(new Pterodáctilo());


Console.WriteLine("Listando os objetos e chamando seus métodos... baseado nas interfaces que eles implementam...");
foreach (object o in meusObjetos)
{
    Console.WriteLine("------------------------------------------------------------");
    Console.WriteLine("O tipo do objeto é: " + o.GetType());
    if (o is IVoador)
    {
        Console.WriteLine("O objeto é voador...");
        (o as IVoador).Voar();
        (o as IVoador).pousar();
        (o as IVoador).decolar();
    }
    if (o is IPairador)
    {
        Console.WriteLine("O objeto é pairador...");
        (o as IPairador).pairar();
    }
    if (o is ISer_Vivo)
    {
        Console.WriteLine("O objeto é um ser vivo...");
        (o as ISer_Vivo).nascer();
        (o as ISer_Vivo).crescer();
        (o as ISer_Vivo).reproduzir();
        (o as ISer_Vivo).morrer();
    }
    if (o is IMaquina)
    {
        Console.WriteLine("O objeto é uma maquina...");
        (o as IMaquina).ligar();
        (o as IMaquina).desligar();
    }
    Console.WriteLine("------------------------------------------------------------");
}