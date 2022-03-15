using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex03_FIleInfo_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Program Files (x86)\Internet Explorer"); // 이 안의 자세한 정보를 나에게 줘
            if (dirInfo.Exists)
            {
                Console.WriteLine("전체경로 : {0}", dirInfo.FullName);
                Console.WriteLine("디렉토리 이름 : {0}", dirInfo.Name);
                Console.WriteLine("생성일 : {0}", dirInfo.CreationTime);
                Console.WriteLine("디렉토리 속성 : {0}", dirInfo.Attributes);
                Console.WriteLine("루트경로 : {0}", dirInfo.Root);
                Console.WriteLine("부모 디렉토리 : {0}", dirInfo.Parent);
            }
            else {
                Console.WriteLine("잘못된 경로입니다.");
            }

            Console.WriteLine("-------------------------");


            FileInfo fInfo = new FileInfo(@"C:\temp\test.txt");
            if (fInfo.Exists)
            {
                Console.WriteLine("폴더 이름 : {0}", fInfo.Directory);
                Console.WriteLine("파일 이름 : {0}", fInfo.Name);
                Console.WriteLine("확장자 : {0}", fInfo.Extension);
                Console.WriteLine("생성일 : {0}", fInfo.CreationTime);
                Console.WriteLine("파일크기 : {0}byte", fInfo.Length);
                Console.WriteLine("속성 : {0}", fInfo.Attributes);
            }
            else
            {
                Console.WriteLine("잘못된 경로입니다.");
            }

        }
    }
}
