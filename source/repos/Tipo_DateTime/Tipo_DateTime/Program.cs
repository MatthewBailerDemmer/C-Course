using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipo_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime time = new DateTime(2020, 09, 26);
            DateTime timeAndHour = new DateTime(2020, 09, 26, 14, 12, 45);

            Console.WriteLine("Ano: " + timeAndHour.Year);
            Console.WriteLine("Mes: " + timeAndHour.Month);
            Console.WriteLine("Dia: " + timeAndHour.Day);
            Console.WriteLine("Hora: " + timeAndHour.Hour);
            Console.WriteLine("Minutos: " + timeAndHour.Minute);
            Console.WriteLine("Segunos: " + timeAndHour.Second);
            Console.WriteLine("Dia da semana : " + timeAndHour.DayOfWeek);
            Console.WriteLine("----------------------");
            Console.WriteLine(time.ToString());
            Console.WriteLine(timeAndHour.ToString());

            //Pegando a data e a hora atual
            DateTime dataHoraAtual = DateTime.Now;
            Console.WriteLine(dataHoraAtual.ToString());

            //Convertendo uma string em uma variável DateTime
            DateTime dataConvertida = Convert.ToDateTime("22/11/2030");
            DateTime dataHoraConvertida = Convert.ToDateTime("22/11/2030 14:10:23");
            Console.WriteLine(Convert.ToString(dataConvertida));
            Console.WriteLine(Convert.ToString(dataHoraConvertida));

            Console.WriteLine("----------------------");
            //Formatando a data e a hora impressa
            Console.WriteLine(dataHoraConvertida.ToString("yyyy/MM"));
            Console.WriteLine(dataHoraConvertida.ToString("yyyy/MM/dd"));

            Console.WriteLine(dataHoraConvertida.ToString("HH:mm:ss")); // HH -> relogio 24hrs , hh -> relogio 12 horas

            //Operacoes com as variavies DateTime
            DateTime dataHora2 = new DateTime(2020, 09, 27, 14, 05, 20);
            dataHora2 = dataHora2.AddDays(4);
            /*
            dataHora2 = dataHora2.AddMonths();
            dateHora2 = dataHora2.AddYears();
            */
            Console.WriteLine(dataHora2.ToString("dd/Mm/yyyy"));

            dataHora2 = dataHora2.Add(new TimeSpan(4, 1, 55, 30));
            Console.WriteLine(dataHora2.ToString("dd:HH:mm:ss"));
            Console.WriteLine("----------------------");
            
            //Subtraindo datas
            DateTime dataHora3 = new DateTime(2022, 3, 1, 14, 5, 20);
            dataHora3 = dataHora3.Subtract(new TimeSpan(1, 5, 20));
            Console.WriteLine(dataHora3.ToString("HH:mm:ss"));

            dataHora3 = dataHora3.AddDays(-1);
            Console.WriteLine(dataHora3.ToString("dd/MM/yyyy"));

            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();

        }
    }
}
