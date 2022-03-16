using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework_Lotto
{
    class Lotto
    {
        int[] number;
        Random random;

        public Lotto()
        {
            number = new int[6];
            random = new Random();
        }

        public void getnumber()
        {
            int temp;

            for (int i = 0; i < 6; i++)
            {
                int a = random.Next(1, 46);
                number[i] = a;
                for (int j = 0; j < i; j++)
                {
                    if (i == 0) break;
                    number[i] = (number[i] == number[j]) ? i-- : number[i];
                }
            }
            for (int i = 0; i < number.Length - 1; i++)
            {
                for (int j = i + 1; j < number.Length; j++)
                {
                    if (number[i] > number[j])
                    {
                        temp = number[i];
                        number[i] = number[j];
                        number[j] = temp;
                    }
                }
            }
        }
        public void OpenOrCreateFile()
        {
            string path = @"D:\Ecount\Labs\FrameWork_IO\Ex06-01_LottoIO\bin\Debug\LottoHistory.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(new FileStream("LottoHistory.txt", FileMode.OpenOrCreate)))
                {
                    sw.Write($"정렬된 로또 번호 : ");
                    foreach (int item in number)
                    {
                        sw.Write($" [{item}] ");
                    }
                    sw.WriteLine();
                }
                Console.WriteLine("파일에 내용을 저장했습니다.");
            }
            else
            {
                using (StreamWriter sw = File.AppendText("LottoHistory.txt"))
                {
                    sw.Write($"정렬된 로또 번호 : ");
                    foreach (int item in number)
                    {
                        sw.Write($" [{item}] ");
                    }
                    sw.WriteLine();
                }
                Console.WriteLine("파일에 내용을 저장했습니다.");
            }

        }
        public void OpenFile()
        {
            using (StreamReader sr = new StreamReader("LottoHistory.txt"))
            {
                string lottoHistory = File.ReadAllText("LottoHistory.txt");
                Console.WriteLine(lottoHistory);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lotto lotto = new Lotto();
            lotto.getnumber();
            lotto.OpenOrCreateFile();
            lotto.OpenFile();
        }
    }
}