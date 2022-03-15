using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // 추가

namespace Ex04_File_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            //Console.WriteLine(args[0]);
                   if (args.Length < 1)
                   {
                       Console.WriteLine("사용법 : 파일.exe [디렉토리 경로]");
                       return; // 함수 바로 빠지기
                   }
                   DirectoryInfo dirinfo = new DirectoryInfo(args[0]);
                   if (dirinfo.Exists)
                   {
                       DirectoryInfo[] dirs = dirinfo.GetDirectories();
                       foreach (DirectoryInfo item in dirs) // C:window\temp > 파일 존재
                       {
                           FileInfo[] files = item.GetFiles();
                           Console.WriteLine($"디렉토리 : {item.FullName}, 파일 수 : {files.Length}");

                           int index = 0;
                           foreach (FileInfo file in files) // test.txt or a.jpg
                           {
                               string str = string.Format("[{0}] : Name : {1}, Extention : {2} , size : {3}", ++index, file.Name, file.Extension, file.Length);
                               Console.WriteLine(str);
                           }

                       }*/

            if (args.Length < 2)
            {
                Console.WriteLine("사용법: 파일.exe [옵션] [디렉토리명] [파일명]");
                Console.WriteLine("[옵션] : -del 하나 이상의 파일을 지웁니다.");
                return;
            }

            DirectoryInfo dir = new DirectoryInfo(args[1]);
            FileInfo files = new FileInfo(args[2]);
            if (args[0].Trim() == "del")
            {
                files.Delete();
            }
        }
    }
}
