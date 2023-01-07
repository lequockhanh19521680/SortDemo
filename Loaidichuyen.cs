using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSort
{
    public enum Loaidichuyen
    {
        //Nút 1 tại vt1 đi lên, sang phải, đi xuống
        //Nút 2 tại vt2 đi xuống, sang trái, đi lên
        //tạo hành động cho nút lệnh di chuyển
        dilen_dixuong, sangtrai_sangphai, dixuong_dilen, dung,
    }

    //vị trí lúc di chuyển
    public class trangthai
    {
        public Loaidichuyen Type { get; set; }
        public int vt1 { get; set; }
        public int vt2 { get; set; }

    }
}
