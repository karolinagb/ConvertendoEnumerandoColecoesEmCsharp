using System;
using System.Collections.Generic;

namespace Covariancia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("string para object");
            string titulo = "meses";
            object obj = titulo;
            Console.WriteLine(obj);

            Console.WriteLine("List<string> para List<object>");
            IList<string> listaMeses = new List<string>
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };
            //IList<object> listaObj = listaMeses;
            Console.WriteLine();

            Console.WriteLine("string[] para object[]?");
            string[] arrayMeses = new string[]
           {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
           };
            object[] arrayObj = arrayMeses; //Covariância = conversão implicita
            Console.WriteLine(arrayObj);
            foreach (var item in arrayObj)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            arrayObj[0] = "PRIMEIRO MÊS";
            Console.WriteLine(arrayObj[0]);
            Console.WriteLine();

            //arrayObj[0] = 12345;
            //Console.WriteLine(arrayObj[0]); = A covariância do array deve ser evitada porque agora o array de object so aceita string, se tentar
            //Console.WriteLine();  //inserir valor de outro tipo vai dar uma exceção

            Console.WriteLine("List<string> para IEnumerable<object>");
            IEnumerable<object> enumObj = listaMeses; //COVARIÂNCIA
            foreach (var item in enumObj)
            {
                Console.WriteLine(item);
            }
            //enumObj[0] = 12345; == Essa convariância é segura porque ele não possui identificador em lista pra atibuir diretamente valores.

            //Exato! O programa vai compilar, porque o array no.NET Framework é covariante(permite conversão de string[] para object[])
            //mas o array objArray só poderá armazenar strings, apesar de ser um array de object.O programa irá gerar uma exceção caso você
            //tente armazenar números ou datas ou outros objetos nesse array de object.
        }
    }
}
