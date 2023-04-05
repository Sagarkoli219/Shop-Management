using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Shop_Management
{
    class clsProduct
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-PF2QR8K;Initial Catalog=ShopManagement;Integrated Security=True");

        public int TypeId { get; set; }
        public string TypeName  { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int SizeId { get; set; }
        public string Size { get; set; }
        public int MRP { get; set; }
        public int RealPrice { get; set; }
        
        public clsProduct()
        { 
        }
        public clsProduct(int tId)
        {
            TypeId = tId;
        }
        public clsProduct(string tName)
        {
            TypeName = tName;
        }
        public clsProduct(int tId,string pName)
        {
            TypeId = tId;
            ProductName = pName;
        }
        public clsProduct(int tId,int pId,string size,int mrp,int Rprice)
        {
            TypeId = tId;
            ProductId = pId;
            Size = size;
            MRP = mrp;
            RealPrice = Rprice;
        }
        //================= To save data in tblType ================//
        public void SaveType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveType");
            cmd.Parameters.AddWithValue("@TypeName", TypeName);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //================= To show data in frmProduct and frmAllOrders ================//
        public DataTable GetType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetType");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        //================= To save data in tblProduct ================//
        public void SaveProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveProduct");
            cmd.Parameters.AddWithValue("@TypeId", TypeId);
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //================= To show data in frmSize and frmOrder ================// 
        public DataTable GetProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetProduct");
            cmd.Parameters.AddWithValue("@TypeId", TypeId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        //================= To save in tblSize ================// 
        public void SaveSize()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveSize");
            cmd.Parameters.AddWithValue("@TypeId", TypeId);
            cmd.Parameters.AddWithValue("@ProductId", ProductId);
            cmd.Parameters.AddWithValue("@Size", Size);
            cmd.Parameters.AddWithValue("@MRP", MRP);
            cmd.Parameters.AddWithValue("@RealPrice", RealPrice);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //================= To show data in Datagridview of frmAllOrders ================// 
        public DataTable GetSize()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetSize");
            cmd.Parameters.AddWithValue("@ProductId", TypeId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        //================= To show Price on frmOrder ================// 
        public SqlDataReader GetPrice()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetPrice");
            cmd.Parameters.AddWithValue("@SizeId", TypeId);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        //================= To Save Discount in tblOrder ================// 
        public void UpdateDiscount()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateDiscount");
            cmd.Parameters.AddWithValue("@OrderId", TypeId);
            cmd.Parameters.AddWithValue("@Discount", ProductName);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //================= To show data in frmUnOrderProduct ================// 
        public DataTable UnOrderedProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UnOrderedProduct");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        
    }
}
