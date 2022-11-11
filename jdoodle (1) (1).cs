using System;

class Program
{
    public static double CalcularPrecio(string tipoHelado, int topping) {
        double precio = 0;
        if (tipoHelado == "chocolate" || tipoHelado == "pistacho"){
            precio = 5;
        } else if (tipoHelado == "napolitano" || tipoHelado == "pistacho"){
            precio = 7;
        }
        switch (topping){
            case 1: precio = precio +1;
            break;
            case 2: precio = precio +2;
            break;
            case 3: precio = precio +1;
            break;
            //Error del programa
            default:
            Console.WriteLine("Error: Numero de topping mal ingresado");
            break; 
        }

        return precio;
    }
    static void Main () {
        // función correctamente
        int cant=1;
        for (int tooping = 1; tooping < 4; tooping++)
        {
            Console.WriteLine("Helado de chocolate con topping: " + cant);
            Console.WriteLine(CalcularPrecio("chocolate", tooping));
            cant++;
        }
        cant = 1;
        for (int tooping = 1; tooping < 4; tooping++)
        {
            Console.WriteLine("Helado de napolitano con topping: " + cant);
            Console.WriteLine(CalcularPrecio("napolitano", tooping));
            cant++;
        }
        Console.WriteLine("No se eligio correctamente el topping:");
        Console.WriteLine("Helado chocolate con el topping: 0");
        Console.WriteLine(CalcularPrecio("chocolate", 0));
        Console.ReadKey();
      
    }
}