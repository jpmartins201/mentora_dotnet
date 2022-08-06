using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Cronômetro");
        Menu();
    }

    static void PreStart(){
        int contagem=2;
        while(contagem >= 0) {
            Thread.Sleep(1000);
            Console.WriteLine("\rCronometro iniciando contagem em {0} " + "segundos...", contagem);
            contagem--;
        }
    }
    static void Start(int quantidade, string medida){
        PreStart();
        while(quantidade >= 0) {
            Thread.Sleep(1000);
            Console.Write("\r" + quantidade + "...");
            quantidade--;
        }
        Console.WriteLine("\n F I M ");
    }
    static void Menu()
    {
        int quantidade = 0;
        string medida = "";
        int achei = 0;
        Console.WriteLine("10m -> 10 minutos");
        Console.WriteLine("10s -> 10 segundos");
        Console.WriteLine("Digite o tempo desejado: \n");
        string? tempo = Console.ReadLine();
        if(tempo.IndexOf("m") != -1)
        {
            achei = tempo.IndexOf("m");
            medida = tempo.Substring(tempo.IndexOf("m"));
            quantidade = Convert.ToInt32(tempo.Substring(0, achei))*60;
        }
        if(tempo.IndexOf("s") != -1){
            achei = tempo.IndexOf("s");
            medida = tempo.Substring(tempo.IndexOf("s"));
            quantidade = Convert.ToInt32(tempo.Substring(0, achei));
        }
        Start(quantidade, medida);    
    }
}