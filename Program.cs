using System;

namespace ConversaoMaiuscula
{
    class Program
    {
        static void Main(string[] args)
        
        {
           var texto = "Este texto é um aMiGo teste";
            Console.WriteLine(texto.ToLower());//Converte texto para minusculo
            Console.WriteLine(texto.ToUpper());//Converte texto para MAIUSCULO
            Console.WriteLine(texto.Insert(5, "AQUI"));//Inserir um Caracter dentro do texto
            Console.WriteLine(texto.Remove(5, 5));//Remnove um Caracter dentro do texto
            Console.WriteLine(texto.Length);//Informa a Quantidade de caracteres que possui a String
            
           
        }
    }
}
