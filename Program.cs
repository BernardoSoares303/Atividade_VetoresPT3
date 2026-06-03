using System.Reflection.Metadata;

public class Program
{
    public static void Main()
    {
        int horas, minutos, segundos;

        Console.Write("Insira as horas: ");
        horas = int.Parse(Console.ReadLine());    

        Console.Write("Insira as minutos: ");
        minutos = int.Parse(Console.ReadLine()); 

        Console.Write("Insira as segundos: ");
        segundos = int.Parse(Console.ReadLine()); 

        Console.WriteLine($"Total em Segundos: {TotalSegs(horas, minutos, segundos)}");
    }

    public static int TotalSegs(int h, int m, int s)
    {
        return (h * 60 * 60) + (m * 60) + s;
    }
}