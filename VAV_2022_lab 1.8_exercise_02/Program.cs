using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VAV_2022_lab_1._8_exercise_02
{
    class Program
    {
        /* Программно создайте текстовый файл и запишите в него 10 случайных чисел. Затем программнооткройте созданный файл,
рассчитайте сумму чисел в нем, ответ выведите на консоль.*/

        static void Main(string[] args)
        {
            string path = "F:/new.txt";
            if (!Directory.Exists(path))
            {
                File.Create(path);
            }
            Random rnd = new Random();
            StreamWriter sw = new StreamWriter(path);

            for (int i = 0; i < 10; i++)
            {
                sw.WriteLine(rnd.Next(10));
            }
            sw.Close();
            StreamReader sr = new StreamReader(path);
            int sum = 0;
            string str;
            while ((str = sr.ReadLine()) != null)
            {
                sum += Convert.ToInt32(str);
            }
            Console.WriteLine("Сумма чисел в файле равна {0}", sum);
            Console.ReadKey();



        }
    }
}
