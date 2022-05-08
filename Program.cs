using System.Net.WebSockets;
using System;
using System.Text.RegularExpressions;

namespace SSN;

public class Progran
{
    public static void Main() 
    {
        Console.Write("Favor Ingrese un Número de Seguridad Social: ");
        string SSN = Console.ReadLine();

        //Creating the Regex:
        string pattern = @"^(?!000|666|(.)*0000)([0-8][0-9]{2})-([0-9][1-9])-([0-9]){4}";
        Regex regex = new Regex(pattern);

        MatchCollection matchedSSN = regex.Matches(SSN);

        if(matchedSSN.Count() == 1){
            Console.WriteLine("Número de Seguridad Social válido");
            return;
        }

        //Edge cases:

        if(string.IsNullOrEmpty(SSN) || string.IsNullOrWhiteSpace(SSN))
        {
            Console.WriteLine("No puede dejar el campo vacío");
            return;
        }

        if(matchedSSN.Count() > 1){
            Console.WriteLine("Favor, solo ingresar un número de seguridad social.");
            return;
        }

        string[] regexGroups = SSN.Split('-');

        if(regexGroups.Count() > 3)
        {
            Console.WriteLine("El Número de Seguridad Social debe tener el formato xxx-xx-xxxx");
            return;
        }

        if(regexGroups[0] == "000" || regexGroups[0] == "666" || regexGroups[0][0] == '9'){
            Console.WriteLine("El Número de Seguridad Social no puede empezr con 000, 666 o entre 900 y 999.");
            return;
        }

        if(regexGroups[1] == "00")
        {
            Console.WriteLine("El número que se encuentra entre '-' no puede ser 00"); 
            return;
        }

        if(regexGroups[2] == "0000")
            Console.WriteLine("La tercera parte del Número de Seguridad Social no puede ser 000");
    }
}
