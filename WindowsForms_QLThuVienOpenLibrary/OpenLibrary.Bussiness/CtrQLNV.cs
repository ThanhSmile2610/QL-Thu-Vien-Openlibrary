using OpenLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenLibrary.DataAccess;

namespace OpenLibrary.Bussiness
{
    public class CtrQLNV
    {
        NhanVienDL tblNhanVien = new NhanVienDL();
        public DataTable LayDSNhanVien()
        {
            return tblNhanVien.LayDSNhanVien();
        }
    }
}
