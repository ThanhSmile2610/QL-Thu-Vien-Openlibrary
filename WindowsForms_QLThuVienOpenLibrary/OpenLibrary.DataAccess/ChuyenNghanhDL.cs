    using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibrary.DataAccess
{
    public class ChuyenNghanhDL
    {
        // Attribute
        DataTable tblChuyenNghanh;
        DataHelper dt = DataHelper.GetInstance();

        //Constructor
        public ChuyenNghanhDL()
        {
            tblChuyenNghanh = dt.FillDataTable("Select * from CHUYENNGANH");
        }

        public DataTable LayDSChuyenNghanh()
        {
            return tblChuyenNghanh;
        }

        public bool ThemMoiChuyenNganh(String TenCN)
        {       
            try
            {
                dt.InsertRowtable(tblChuyenNghanh, null, TenCN);
                dt.UpdateFromDataTableToDataBase("CHUYENNGANH", tblChuyenNghanh);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }
        //public bool XoaChuyenNghanh(string MaCN)
        //{
        //    try
        //    {
        //        DataRow rowToDelete = dt.Select("MachuyenNganh = " + MaCN).FirstOrDefault();
        //        if (rowToDelete != null)
        //        {
        //            dt.Rows.Remove(rowToDelete);
        //            dt.UpdateFromDataTableToDataBase("CHUYENNGANH", tblChuyenNghanh); 
        //            return true;
        //        }
        //        else
        //        {
        //            return false; 
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        public bool SuaChuyenNghanh(String TenCN, String MaCN)
        {
            try
            {
                String dk = "MachuyenNganh = " + MaCN;
                dt.UpdateRowTable(tblChuyenNghanh, dk, "TenChuyenNganh", TenCN);
                dt.UpdateFromDataTableToDataBase("CHUYENNGANH", tblChuyenNghanh);
                return true;
            }catch(Exception ex)
            {
                throw ex;
                return false;
            }
        }
    }
}
