// See https://aka.ms/new-console-template for more information
Console.WriteLine("Pratica con estrura de control (if,else y else if)");

// Un programa que pida dos números y diga cuál es mayor.

//Console.WriteLine("Introduce el primer numero");
//int num1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Introduce el segundo numero");
//int num2 = int.Parse(Console.ReadLine());

//if (num1 >= num2)
//{
//    Console.WriteLine("El primer número es mayor que el segundo");
//}
//else
//{
//    Console.WriteLine("El segundo número es mayor que el primer número");
//}


// Un programa que diga si un número es par o impar.


//Console.WriteLine("Introduce un numero");
//float num1 = float.Parse(Console.ReadLine());
//float var = num1 / 2;
////Console.WriteLine(var);

//if (var %2 == 0)
//{
//    Console.WriteLine("Este numero es par");
//}
//else
//{
//    Console.WriteLine("Este numero es impar");
//}



// O uno en el que el usuario escriba su edad y el programa le diga si es menor o mayor de edad. 

//Console.WriteLine("Introduce una edad ");
//int edad = int.Parse(Console.ReadLine());

//if (edad >= 18 )
//{
//    Console.WriteLine("Es mayor de edad");
//}
//else
//{
//    Console.WriteLine("Es menor de edad");
//}



Console.WriteLine("======================>Conversor de unidades:<======================");
Console.WriteLine("1 - Kilómetros a millas");
Console.WriteLine("2 - Celsius a Fahrenheit");
Console.WriteLine("3 - Libras a kilogramos");
Console.WriteLine("4 - Salir");


int opciones = int.Parse(Console.ReadLine());


switch(opciones)
{
    case 1:
        Console.WriteLine("Convertir Kilómetros a millas");
        Console.WriteLine("Introduce los kilometros");
        double kilometro  = double.Parse(Console.ReadLine());
        double milla = kilometro * (1.0/ 1.609);
        Console.WriteLine($"Son aproximadamente...: {milla} millas ");
        break;
   
    case 2:
        Console.WriteLine("Convertir celsius a fahrenheit");
        Console.WriteLine("Introduce los celsius");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius*9/5)+32;
        Console.WriteLine($"Son aproximadamente...: {fahrenheit} fahrenheit ");
        break;

    case 3:
        Console.WriteLine("Convertir libras a kilogramos");
        Console.WriteLine("Introduce las libras");
        double libras = double.Parse(Console.ReadLine());
        double kilogramos = libras * (1.0/2.2046);
        Console.WriteLine($"Son aproximadamente...: {kilogramos} kilogramos");
        break;
    
    case 4:
        Console.WriteLine("Saliste del programa");
        break;
}




