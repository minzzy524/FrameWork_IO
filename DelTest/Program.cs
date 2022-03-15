using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DelTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\MAC\source\repos\minzzy524\FrameWork_IO\DelTest\bin\Debug\aaa.txt";
            FileInfo fi1 = new FileInfo(path);

            FileInfo fi = new FileInfo("asd.txt");

            try
            {
                using (StreamWriter sw = fi1.CreateText()) { }
                string path2 = path + "temp";
                FileInfo fi2 = new FileInfo(path2);

                fi2.Delete();

                Console.WriteLine("{0} 은 삭제 되었습니다.", path2);
            }
            catch (Exception e)
            {
                Console.WriteLine("실행 실패 : {0}", e.ToString());
            }
        }
    }
}
