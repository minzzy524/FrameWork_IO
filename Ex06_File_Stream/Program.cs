using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Ex06_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            //read
            /*
            FileStream fs = new FileStream("hello3.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            // Console.WriteLine(sr.ReadLine()); //text
            // Console.WriteLine(sr.ReadLine()); //text
            // Console.WriteLine(sr.ReadLine()); //

            int data = int.Parse(sr.ReadLine());
            float fdata = float.Parse(sr.ReadLine());   
            string strdata = sr.ReadLine();
            sr.Close();
            fs.Close();
            Console.WriteLine("{0}-{1}-{2}",data,fdata,strdata);
            */
            //using() {}
            /*
            using (StreamReader sr = new StreamReader(new FileStream("hello3.txt", FileMode.Open, FileAccess.Read))) {
                int data = int.Parse(sr.ReadLine());
                float fdata = float.Parse(sr.ReadLine());
                string strdata = sr.ReadLine();
                Console.WriteLine("{0}-{1}-{2}", data, fdata, strdata);

            }
            */

            using (StreamReader sr = new StreamReader("hello3.txt")) //read만 FileStream 옵션 없으면 생성 
            {
                int data = int.Parse(sr.ReadLine());
                float fdata = float.Parse(sr.ReadLine());
                string strdata = sr.ReadLine();
                Console.WriteLine("{0}-{1}-{2}", data, fdata, strdata);

            }
        }
    }
}
