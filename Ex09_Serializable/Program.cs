using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ex09_Serializable
{

    [Serializable] // 직렬화 대상
    class Emp
    {

        public int empno;
        public string ename;
        
        [NonSerialized] // 직렬화 대상에서 제외
        public string job = "IT";

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
            // 직렬화 한 객체를 파일에 write
            Stream stream = new FileStream("Emp.txt",FileMode.Create); // Emp.txt 가 여자친구
            BinaryFormatter formatter = new BinaryFormatter(); // 직렬화, 객체를 줄을 세워서 보내는 역할
            Emp emp = new Emp(9000, "홍길동");

            // 직렬화
            formatter.Serialize(stream, emp); // emp.txt파일에 emp객체 직렬화 해서 write
            stream.Close();
            // 단점 : 직렬화 한 자원은 반드시 역직렬화를 통해서만 read가 가능하다

            // 반드시 역직렬화
            Stream rs = new FileStream("emp.txt", FileMode.Open);
            BinaryFormatter br = new BinaryFormatter();
            Emp empdata = (Emp)br.Deserialize(rs); // emp.txt 파일에 쓰여진 자원을 다시 조립하는 것(원본으로 다시 만듦)


            Console.WriteLine("{0}, {1}", empdata.empno, empdata.ename);
            // Console.WriteLine(empdata.job); // 이건 안나와 직렬화 대상이 아니니까

        }
    }
}
