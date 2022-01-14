using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            var meses = new string[]
           {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
           };

            //Com array o foreach deixa modificar o valor pq é como se ele transformasse num laço for
            foreach (var mes in meses)
            {
                meses[0] = meses[0].ToUpper();
                Console.WriteLine(mes);
            }

            //for (int i = 0; i < meses.Length; i++)
            //{
            //    var mes = meses[i];
            //    ....
            //}
        }
    }
}
