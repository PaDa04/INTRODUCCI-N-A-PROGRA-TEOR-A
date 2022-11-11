using System;

class Program
{
    
    //funcion
    public static int Suma3digitos()
    {
        int num;
        int num1;
        int num2;
        int res;
        
        Console.WriteLine("ingrese el numero");
        num = Int32.Parse(Console.ReadLine());
        Console.WriteLine("ingrese el numero");
        num1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("ingrese el numero");
        num2 = Int32.Parse(Console.ReadLine());
        res = num + num1 + num2;
        
        return res;
    }
    
    // recibir de parametro el numero a evaluar
    public static int Suma3digitos(int num, int num1, int num2)
    {
        int res;
        res = num + num1 + num2;
        
        return res;   
    }
    
    public static void esPar(int num)
    {
        if (num % 2 == 0)
        {
            Console.WriteLine("El resultado es par");
        }
        else
        {
            Console.WriteLine("El resultado es impar");
        }
        
    }
 
    
    //bloque que se ejecuta
    static void Main() {
        
        int valor;
        Console.WriteLine("Ingrese numero a evaluar");
        valor = Int32.Parse(Console.ReadLine());
        esPar(valor);
      //1
       int num;
       int num1;
       int num2;
       int res;
       
       Console.WriteLine("Ingresar numero a evaluar");
       num = Int32.Parse(Console.ReadLine());
       Console.WriteLine("Ingresar numero a evaluar");
       num1 = Int32.Parse(Console.ReadLine());
       Console.WriteLine("Ingresar numero a evaluar");
       num2 = Int32.Parse(Console.ReadLine());
       res = Suma3digitos(num, num1, num2);
       Console.WriteLine("El resultado es  "+ res);
       
       //2
       Console.WriteLine("Ingrese el numero");
       num1 = Int32.Parse(Console.ReadLine());
       res = Suma3digitos(num, num1, num2);
       Console.WriteLine("El resultado es  "+res);
       
      //3
       res = Suma3digitos(num, num1, num2);
       Console.WriteLine("El resultado es  "+res);
       
       
       
       
       
    }
}