using System.Reflection.Metadata;

public class Program
{
    public static void Main()
    {
        int contador = 0;
        int n;
        int[] abundantes = new int[20];

        while(contador < 20)
        {
            Console.Write("Insira Um numero: ");
            n = int.Parse(Console.ReadLine());

            if (EhAbundante(n))
            {
                abundantes[contador] = n;
                contador ++;
            }
            else
                Console.WriteLine($"{n} não é abundante!");
        }

        Console.WriteLine("20 numeros abundantes encontrados");
    }

    public static bool EhAbundante(int n)
    {
        int soma = 0;

        for(int i=0 ; i < n; i++)
        {
            soma += i;
        }

        if(soma > n)
            return true;
        else
            return false;
    }
}