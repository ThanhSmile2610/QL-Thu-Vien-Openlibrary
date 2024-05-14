using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibrary.DataAccess
{
    public class NhanVienDL
    {
        DataTable tblNhanVien;
        DataHelper dt = DataHelper.GetInstance();
        public NhanVienDL()
        {
            tblNhanVien = dt.FillDataTable("Select * from NHANVIEN");
        }
        public DataTable LayDSNhanVien()
        {
            return tblNhanVien;
        }
        public DataRow[] TimNhanVien(string userName, string password)
        {
            DataRow[] nv = tblNhanVien.Select("UserName = '" + userName + "' AND Password = '" + password + "'");
            return nv;
        }

    }
}
