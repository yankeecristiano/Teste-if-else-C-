// See https://aka.ms/new-console-template for more information
using System.Globalization;



Console.WriteLine("Que horas são ?");
Double x = double.Parse(Console.ReadLine());

if (x>=3 && x<12) // CONDIÇÃO
{

    Console.WriteLine("Bom dia!"); // COMANDO
}   // executa esse 

else
{
    if (x >= 12 && x < 18)
    {
        Console.WriteLine("Boa Tarde!");  
    }
   
    if (x >= 18 && x < 24 )
    {
        Console.WriteLine("Boa noite!");
    }

    {
        if (x >=0 && x < 3)
        {
            Console.WriteLine("Boa Madrugada!");
        }
    }
}    // Se não esse 






// Detalhe : Se o bloco de comandos possuir apenas um comando, as chaves( {} )
// são opcionais

