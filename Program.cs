﻿using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 3
            // 1. Hacer un programa para ingresar un número y luego se emita por pantalla un cartel
            // aclaratorio si “Es mayor a 10” o “No es mayor a 10”.

            // int n1;
            // Console.WriteLine("Ingrese un numero");
            // n1 = int.Parse(Console.ReadLine());

            // if(n1 > 10){
            //     Console.WriteLine("SI, su numero es mayor a 10");
            // }else{
            //     Console.WriteLine("NO, su numero no es mayor a 10");
            // }

            // Console.WriteLine("FIN DEL PROGRAMA");

            // .......................................................................

            // 2. Hacer un programa para ingresar un número y luego se emita un cartel por pantalla
            // “Positivo” si el número es mayor a cero, “Negativo” si el número es menor a cero o
            // “Cero” si el número es igual a cero.

            // int n1;

            // Console.WriteLine("Ingrese un numero");
            // n1 = int.Parse(Console.ReadLine());

            // if(n1 == 0){
            //     Console.WriteLine("CERO"); 
            // }else if(n1 > 0){
            //     Console.WriteLine("POSITIVO");
            // }else{
            //      Console.WriteLine("NEGATIVO");
            // }
            // Console.WriteLine("FIN DEL PROGRAMA");

            // .......................................................................

            // 3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra
            // realizada según los siguientes valores:
            // Si el importe es menor a ARS 1000, no hay descuento.
            // Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            // Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            // Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el 
            // importe final con el descuento que corresponda.

            // int importe;

            // Console.WriteLine("Ingrese el importe de venta");
            // importe = int.Parse(Console.ReadLine());

            // if(importe < 1000){
            //     Console.WriteLine("NO HAY DESCUENTO");
            // }else if(importe >= 1000 & importe < 5000){
            //     importe = importe * 0.90F;
            //     Console.WriteLine("DESCUENTO 10%");
                
            // }else if(importe >= 5000){ 
            //     importe = importe * 0.82F;
            //     Console.WriteLine("DESCUENTO 18%");
               

            // }

            // .......................................................................
            

            // 4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por 
            // pantalla el menor de ellos.

            // int n1, n2, n3, n4, menor;

            // Console.WriteLine("Ingrese el primer numero:");
            // n1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el segundo numero:");
            // n2 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el tercer numero:");
            // n3 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el cuarto numero");
            // n4 = int.Parse(Console.ReadLine());

            // if(n1 < n2){
            //     menor = n1;
            // }else{
            //     menor = n2;
            // }
            // if(n3 < menor){
            //     menor = n3;
            // }
            // if(n4 < menor){
            //     menor = n4;
            // }
            
            // Console.WriteLine("El numero menos es:" + menor);


            // .......................................................................

            // 5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla 
            // cuáles son mayores a 100.
           
        //     int n1, n2, n3, n4;
        //     int acumulador = 0;
        //     int contador = 0;

        //     Console.WriteLine("Ingrese el primer numero:");
        //     n1 = int.Parse(Console.ReadLine());
        //     Console.WriteLine("Ingrese el segundo numero:");
        //     n2 = int.Parse(Console.ReadLine());
        //     Console.WriteLine("Ingrese el tercer numero:");
        //     n3 = int.Parse(Console.ReadLine());
        //     Console.WriteLine("Ingrese el cuarto numero");
        //     n4 = int.Parse(Console.ReadLine());

        //   if(n1 > 100){
        //     contador ++;
        //     acumulador += n1;
        //     Console.WriteLine("El numero " + n1 + " es mayor a 100");
        //   }
        //   if(n2 > 100){
        //     contador ++;
        //     acumulador += n2;
        //     Console.WriteLine("El numero " + n2 + " es mayor a 100");
        //   }
        //   if(n3 > 100){
        //     contador ++;
        //     acumulador += n3;
        //     Console.WriteLine("El numero " + n3 + " es mayor a 100");
        //   }
        //   if(n4 > 100){
        //     contador ++;
        //     acumulador += n4;
        //     Console.WriteLine("El numero " + n4 + " es mayor a 100");
        //   }

        //   Console.WriteLine("La cantidad de numeros mayor a 100 son:" + contador + " y la suma de todos ellos es: " + acumulador);

        }
    }
}

