using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Ex08_FileStream_TextReader_Write
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"D:\temp\aa.txt";
            using (StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write)))
            {
                sw.WriteLine("Text 쓰기작업");
                sw.WriteLine("오늘도 이렇게");
                sw.WriteLine("하루가 지나가네요");
            }

            using (StreamReader sr = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read)))
            {
                while (!sr.EndOfStream) // 읽은 게 빈 문자가 아니면 라인 단위로 읽겠다.
                {
                    Console.WriteLine(sr.ReadLine());
                }

                Console.WriteLine("[위치를 통한 출력]");

                sr.BaseStream.Seek(3, SeekOrigin.Begin); // 시작 index값 정의 Seek(3, <- 3번 인덱스부터 읽으면 "t 쓰기작업")

                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }



        }
    }
}