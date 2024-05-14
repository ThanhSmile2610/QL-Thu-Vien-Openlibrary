using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibrary.Bussiness
{
    public class CtrMain
    {
        public void logout()
        {
            LoginInfo.MaNV = -1;
            LoginInfo.HoTenNV = "";
            LoginInfo.CMND = "";
            LoginInfo.SDT = "";
            LoginInfo.DiaChi = "";
            LoginInfo.Email = "";
            LoginInfo.MaCn = -1;
            LoginInfo.MaLoaiNV = -1;
            LoginInfo.UserName = "";
            LoginInfo.Password = "";
        }
    }
}