namespace AppConHilos;
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("[Tristan Eduardo Suarez Santiago] : Desarrlo de sistemas en red");
        
        Console.WriteLine("EL main thread comienza aqui.");
        Thread background = new Thread(new ThreadStart(Program.DoTrabajoPesado));
        background.Start();
        Program.DoAlgo();
        Console.WriteLine("El main thread termina aqui.");
       
    }

    public static void DoTrabajoPesado(){
        Console.WriteLine("DoTrabajoPesado: Estoy levantando un camion!!");
        Console.WriteLine("DoTrabajoPesado: Necesito un siesta de 3 segundos!!");
        Console.WriteLine("DoTrabajoPesado: 1....");
        Thread.Sleep(1000);
        Console.WriteLine("DoTrabajoPesado: 2....");
        Thread.Sleep(1000);
        Console.WriteLine("DoTrabajoPesado: 3...");
         Console.WriteLine("DoTrabajoPesado: Ya desperte");
    }
    public static void DoAlgo(){
         Console.WriteLine("DoAlgo: Oue haciendo algo aqui!!");
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"{i} ");
        }
        Console.WriteLine();
        Console.WriteLine("DoAlgo: Ya termine.");
    }

}
