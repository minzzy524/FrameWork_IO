using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex02_File_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\temp2"; // 새로운 폴더 생성
            Directory.CreateDirectory(path);

            Console.WriteLine(Directory.Exists(path)); // true or false
            string defaultDir = Directory.GetCurrentDirectory(); // 현재 실행되고 있는 파일 위치
            Console.WriteLine($"defaultDir : {defaultDir}");

            Directory.GetDirectories(@"C:\"); // C 드라이브의 모든 파일 경로 가져와봐
            string[] dirs = Directory.GetDirectories(@"C:\");
            Console.WriteLine("C 드라이브 폴더 목록");
            foreach (string dir in dirs)
            {
                Console.WriteLine($"dir : {dir}");
            }

            Console.WriteLine("---------------------------------");

            // C드라이브의 windows 폴더 안에 있는 파일 목록 출력

            
            string[] files = Directory.GetFiles(@"C:\");
            Console.WriteLine("C 드라이브 파일 목록");
            foreach (string file in files)
            {
                Console.WriteLine($"file : {file}");
            }

            // 문제 : 
            //
        }
    }
}
