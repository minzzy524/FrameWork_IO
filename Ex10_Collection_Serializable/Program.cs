using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ex10_Collection_Serializable
{

    // File >> 하나의 파일에 여러 개의 객체를 직렬화 하면 

    [Serializable] // 직렬화 대상
    class Emp
    {

        public int empno;
        public string ename;


        public Emp(int empno, string ename)
        {
            this.empno = empno;
            this.ename = ename;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Stream stream = new FileStream("semp.txt",FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            List<Emp> empList = new List<Emp>();
            empList.Add(new Emp(1000, "김씨"));
            empList.Add(new Emp(2000, "지씨"));
            empList.Add(new Emp(3000, "박씨"));

            formatter.Serialize(stream, empList);
            stream.Close();

            Stream rs = new FileStream("semp.txt", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            List<Emp> list = (List<Emp>)bf.Deserialize(rs); // list나 dic에 넣어놓고 한번에 deserialize

            foreach (var Emp in list)
            {
                Console.WriteLine($"empno:{Emp.empno}, ename:{Emp.ename}");
            }

        }
    }
}
