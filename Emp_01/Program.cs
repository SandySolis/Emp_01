//Una empresa de carga realiza el transporte de frutas, el precio por la carga
//está en función al tipo de fruta a transportar y la distancia en kilómetros
//que debe recorrer, los precios que se muestran en la tabla es por cada caja de frutas:


using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el tipo de fruta: ");
        Console.WriteLine("Naranja (N)");
        Console.WriteLine("Fresa (F)");
        Console.WriteLine("Mango (M)");
        char tipoFruta = char.Parse(Console.ReadLine());

        Console.Write("Ingrese la distancia en km: ");
        float distancia = float.Parse(Console.ReadLine());

        int costoenvio = 0;

        switch (tipoFruta)
        {
            case 'N':
                if (distancia <= 30f)
                {
                    costoenvio = 2;
                }
                else
                {
                    costoenvio = 4;
                }
                break;

            case 'F':
                if (distancia <= 30f)
                {
                    costoenvio = 6;
                }
                else
                {
                    costoenvio = 9;
                }   
                break;

            case 'M':
                if (distancia <= 30f)
                {
                    costoenvio = 3;
                }
                else
                {
                    costoenvio = 5;
                }
                break;

            default:
                Console.WriteLine("Opción inválida");
                break;
        }

        Console.WriteLine("El pago por carga es de: " + costoenvio);
    }
}
