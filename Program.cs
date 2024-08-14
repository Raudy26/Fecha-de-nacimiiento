using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Por favor, ingresa tu fecha de nacimiento.");

        Console.Write("Día (dd): ");
        int dia;
        while (!int.TryParse(Console.ReadLine(), out dia) || dia < 1 || dia > 31)
        {
            Console.WriteLine("Día no válido, intenta nuevamente.");
            Console.Write("Día (dd): ");
        }

        Console.Write("Mes (mm): ");
        int mes;
        while (!int.TryParse(Console.ReadLine(), out mes) || mes < 1 || mes > 12)
        {
            Console.WriteLine("Mes no válido, intenta nuevamente.");
            Console.Write("Mes (mm): ");
        }

        Console.Write("Año (yyyy): ");
        int anio;
        while (!int.TryParse(Console.ReadLine(), out anio) || anio < 1)
        {
            Console.WriteLine("Año no válido, intenta nuevamente.");
            Console.Write("Año (yyyy): ");
        }

        try
        {
            DateTime fechaNacimiento = new DateTime(anio, mes, dia);
            string diaSemana = fechaNacimiento.ToString("dddd", new System.Globalization.CultureInfo("es-ES"));

            Console.WriteLine($"Naciste un día {diaSemana}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine("Verifica que la fecha ingresada sea válida.");
        }
    }
}
