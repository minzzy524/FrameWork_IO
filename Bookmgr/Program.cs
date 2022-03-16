using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMgr
{

    [Serializable]
    public class Book
    {

        private readonly string isbn;
        private string title;
        private int price;


        public Book(string isbn, string title, int price)
        {
            this.isbn = isbn;
            this.title = title;
            this.price = price;
        }


        public override string ToString()
        {
            return string.Format($"ISBN :{isbn},이름 : {title}, 가격 : {price}");

        }

        public string ISBN()
        {
            return isbn;
        }

        public string getTitle()
        {
            return title;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public int getPrice()
        {
            return price;
        }

        public void setPrice(int price)
        {
            this.price = price;
        }

        public string getIsbn()
        {
            return isbn;
        }
    }

    class BookManager
    {
        public BookManager()
        {
            //Dictionary<string, Book> books = new Dictionary<string, Book>();    
            //book.txt 파일이 존재하면 값을 읽어와서 Dictionary 저장

        }

        public void Run()
        {
            int key = 0;
            while ((key = selectMenu()) != 0)
            {
                switch (key)
                {
                    case 1:
                        addBook();
                        break;
                    case 2:
                        removeBook();
                        break;
                    case 3:
                        searchBook();
                        break;
                    case 4:
                        listBook();
                        break;
                    case 5:
                        listISBN();
                        break;
                    case 6:
                        save();
                        break;
                    case 7:
                        load();
                        break;
                    default:
                        Console.WriteLine("잘못 선택하였습니다.");
                        break;
                }
            }
            Console.WriteLine("종료합니다...");
        }
        private int selectMenu()
        {
            Console.WriteLine("1:추가 2:삭제 3:검색 4:도서 목록 5:ISBN 목록 6:저장 7:불러오기 0:종료");
            int key = int.Parse(Console.ReadLine());
            return key;
        }

        public void addBook()
        { 
            //기존에 책이 존재하는 확인 하고
            //ISBN , title , price 정보를 받아서 Dictionary 추가
            //(ISBN , book) 추가
            // new Dictionary<1902, new Book()>;

        }
        public void removeBook()
        {
            //삭제도서 입력 ISBN 받아서 
            // Dictionary 에서 삭제
        }
        public void searchBook()
        {
            //ISBN 정보 입력 받아
            //책정보 조회
        }
        public void listBook()
        {
            //모든 도서 목록 조회
        }
        public void listISBN()
        {
            //총 도서수와
            //ISBN 출력
        }

        public void save() // 
        {
            // book.txt 에 책 정보를 담고 있는 객체 저장 (직렬화) : Dictionary
        }
        public void load()
        {
            // 책 정보를 담고 있는 book.txt 에 객체 읽어서 화면에 출력 (역직렬화)
            // Emp empdata = (Emp)br.Deserialize(rs); 
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}