using OpenLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenLibrary.Bussiness
{
    public class CtrChuyenNganh
    {
        private string strcon = "Data Source=LAPTOP-TT2BDHBO;Initial Catalog=OPENLIBRARY;Integrated Security=True";
        ChuyenNghanhDL tblChuyenNghanh = new ChuyenNghanhDL();
        public DataTable LayDSChuyenNghanh()
        {
            return tblChuyenNghanh.LayDSChuyenNghanh();
        }

        public bool ThemChuyenNghanh(String TenCN)
        {
            try
            {
                tblChuyenNghanh.ThemMoiChuyenNganh(TenCN);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool SuaCN(string TenCNCu, string TenCNMoi)
        {
            SqlConnection conn = new SqlConnection(strcon);
            try
            {
                conn.Open();
                string sql = "UPDATE CHUYENNGANH SET TenCN = @TenCNMoi WHERE TenCN = @TenCNCu";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenCNMoi", TenCNMoi);
                cmd.Parameters.AddWithValue("@TenCNCu", TenCNCu);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0; // Update successful if at least one row is affected
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa chuyên ngành thất bại. Vui lòng kiểm tra lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool XoaCN(string TenChuyenNganh)
        {
            SqlConnection conn = new SqlConnection(strcon);
            try
            {
                conn.Open();
                string sql = "DELETE FROM CHUYENNGANH WHERE TenCN = @TenCN";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenCN", TenChuyenNganh);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa chuyên ngành thất bại. Vui lòng kiểm tra lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
