using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Shop_Management
{
    class clsUserReg
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-PF2QR8K;Initial Catalog=ShopManagement;Integrated Security=True");
        public int UserId { get; set; }
        public string UserType { get; set; }
        public string UserName { get; set; }

        public string UserEmail { get; set; }

        public string UserGender { get; set; }

        public string UserState { get; set; }

        public string UserPassword { get; set; }
        public string UserPhone { get; set; }
        public int SizeId { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }
        public string TypeName { get; set; }
        public string ProductName { get; set; }
        public string Size { get; set; }
        public int MRP { get; set; }
        public int RealPrice { get; set; }

        public clsUserReg()
        {

        }
        public clsUserReg(string Name,string PName)
        {
            UserName = Name;
            ProductName = PName;
        }
        public clsUserReg(string Type, string Name, string Email, string Gender, string State, string Password, string Phone)
        {
            UserType = Type;
            UserName = Name;
            UserEmail = Email;
            UserGender = Gender;
            UserState = State;
            UserPassword = Password;
            UserPhone = Phone;
        }
        public clsUserReg(string Type, string Email, string Password)
        {
            UserType = Type;
            UserEmail = Email;
            UserPassword = Password;
        }

        public clsUserReg(string Phone)
        {
            UserPhone = Phone;
        }
        public clsUserReg(int Id, int sizeId, string stat)
        {
            UserId = Id;
            SizeId = sizeId;
            Status = stat;
        }
        public clsUserReg(int Id, int sizeId)
        {
            UserId = Id;
            SizeId = sizeId;
            
        }
        public clsUserReg(string TName, string PName, string size, int mrp, int RPrice)
        {
            TypeName = TName;
            ProductName = PName;
            Size = size;
            MRP = mrp;
            RealPrice = RPrice;
        }
        
        //================= To Save data in tblRegistration ================// 
        public void RegisterData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "RegisterData");
            cmd.Parameters.AddWithValue("@Type", UserType);
            cmd.Parameters.AddWithValue("@Name", UserName);
            cmd.Parameters.AddWithValue("@Email", UserEmail);
            cmd.Parameters.AddWithValue("@Gender", UserGender);
            cmd.Parameters.AddWithValue("@State", UserState);
            cmd.Parameters.AddWithValue("@Password", UserPassword);
            cmd.Parameters.AddWithValue("@Phone", UserPhone);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public SqlDataReader Login()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Login");
            cmd.Parameters.AddWithValue("@Email", UserEmail);
            cmd.Parameters.AddWithValue("@Password", UserPassword);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }
        //================= Transfer to frmOrder ================// 
        public SqlDataReader GetOrderInfo()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetOrderInfo");
            cmd.Parameters.AddWithValue("@Name", UserName);
            cmd.Parameters.AddWithValue("@Phone", UserPhone);
            cmd.Parameters.AddWithValue("@Email", UserEmail);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }
        //================= To save data in tblOrder ================// 
        public void OrderConfirm()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "OrderConfirm");
            cmd.Parameters.AddWithValue("@UserId", UserId);
            cmd.Parameters.AddWithValue("@SizeId", SizeId);
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString());
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //================= To Show Data in frmAllProducts ================// 
        public DataTable GetAllProducts()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetAllProducts");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        //================= To show data in frmAllOrders ================// 
        public DataTable GetAllOrders()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetAllOrders");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        //================= To Search data by Name/Product ================// 
        public DataTable GetByNameProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetByNameProduct");
            cmd.Parameters.AddWithValue("@Name", UserName);
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        //================= To show data in frmNotOrderCust ================// 
        public DataTable NotOrderCustomer()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "NotOrderCustomer");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public void DeleteOrder()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DeleteOrder");
            cmd.Parameters.AddWithValue("@IsDeleted", UserId);
            cmd.Parameters.AddWithValue("@OrderId", SizeId);
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}