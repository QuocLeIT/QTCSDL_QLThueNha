using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThueNha.Module
{
    public static class DataAccount
    {
        public static bool _fix = false;
        public static int _idUser = -1;
        public static string _username = "";
        public static string _ma = "";
        public static string _name = "";
        public static int _idChiNhanh = -1;
        public static int _idChucVu = -1;//1: admim, 2: nhanvien, 3: khach hang

       

        public static void ResetDataAccount()
        {
            _idUser = -1;
            _username = "";
            _ma = "";
            _name = "";
            _idChiNhanh = -1;
            _idChucVu = -1;
        }

        public static void SetDataAccount(int id, string username, string ma, string name, int idChiNhanh, int idChucVu)
        {
            _idUser = id;
            _username = username;
            _ma = ma;
            _name = name;
            _idChiNhanh = idChiNhanh;
            _idChucVu = idChucVu;
        }
    }
}
