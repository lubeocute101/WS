using System;

namespace CS10_OOP
{
    /*
    <Access Modifiers> class Class_Name{
        //Khai báo các thành viên dữ liệu (thuộc tính, . . . )
        //Khai báo các thành viên hàm (Phương thức)
    }
    */
    
    class Vukhi
    {
        public string name = "Tên vũ khí";

        int doSatThuong = 0;

        //Thuộc tính
        public int Satthuong
        {
            set
            {
                doSatThuong = value;
            }
            get
            {
                return doSatThuong;
            }
        }
        public int Noisanxuat { get; set; }
        public Vukhi()
        {
            doSatThuong = 1;
            name = "Vũ khí mới";
            System.Console.WriteLine("Constructor không tham số");
        }

        public Vukhi(string name, int _doSatThuong)
        {
            doSatThuong = _doSatThuong;
            this.name = name;
        }

        // Phuong thuc
        public void ThietLapDoSatThuong(int doSatThuong)
        {
            this.doSatThuong = doSatThuong;
        }

        public void Tancong()
        {
            Console.Write(this.name + ": \t");
            for (int i = 0; i < doSatThuong; i++)
            {
                System.Console.Write("* ");
            }
            System.Console.WriteLine();
        }
    }
}
