using DAL;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class DangNhapBUS
    {
        ConnectionAccess obj_DAL = new ConnectionAccess();

        public List<NhanVien> dangnhap(string taikhoan, string matkhau)
        {
            List<NhanVien> list = new List<NhanVien>();
            list = obj_DAL.layDsNhanVien("select * from NhanVien5 where TKhoan = '" + taikhoan + "' and Mkhau = '" + matkhau + "' ");

            return list;
        }
    }
}
