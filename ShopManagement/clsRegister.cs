using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{
    class clsRegister
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RU5490M;Initial Catalog=ShopManagement;Integrated Security=True");

        public int TypeID { get; set; }
        public string Type { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SizeID { get; set; }
        public string Size { get; set; }
        public decimal MRP { get; set; }
        public decimal RealPRice { get; set; }
        public int RtypeID { get; set; }
        public string TypeName { get; set; }
        public string Name { get; set; }
        public string EmaiID { get; set; }
        public Int64 Contact { get; set; }
        public string Gender { get; set; }
        public string State { get; set; }
        public string PassWord { get; set; }
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public DateTime OrderDate {get; set; }
        public string OrderStatus { get; set; }
        public int Discount { get; set; }
        public decimal NewPrice { get; set; }
        public bool ISDelete { get; set; }

        public clsRegister()
        {

        }
        public clsRegister(string name, string emailid, string state, string password, string typename, string gender, Int64 contact)
        {
            TypeName = typename;
            Name = name;
            EmaiID = emailid;
            State = state;
            PassWord = password;
            Gender = gender;
            Contact = contact;
        }
        public void SaveRegister()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("RegisterUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveRegister");
            cmd.Parameters.AddWithValue("@typename", TypeName);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@emailid", EmaiID);
            cmd.Parameters.AddWithValue("@contact", Contact);
            cmd.Parameters.AddWithValue("@gender", Gender);
            cmd.Parameters.AddWithValue("@state", State);
            cmd.Parameters.AddWithValue("@password", PassWord);
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public DataTable GetOrderType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("RegisterUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetOrderType");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();
        }
        public clsRegister(int typeoid)
        {
            TypeID = typeoid;
        }
        public DataTable GetOrderProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("RegisterUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetOrderProduct");
            cmd.Parameters.AddWithValue("@Utypeid", TypeID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();

        }
   
        public DataTable GetSizeShow()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("RegisterUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetSizeShow");
            cmd.Parameters.AddWithValue("@Utypeid",TypeID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt ;

            con.Close();
        }
        public clsRegister(string size,int sizeid)
        {
            Size = size;
            SizeID = sizeid;
        }
        public SqlDataReader MRPShow()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("RegisterUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "MRPShow");
            cmd.Parameters.AddWithValue("@Usizeid", SizeID);
            cmd.Parameters.AddWithValue("@Usize", Size);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();

        }
        public clsRegister(string typename,string emailid,string password)
        {
           EmaiID = emailid;
            PassWord = password;
            TypeName = typename;
        }
        public SqlDataReader Login()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("RegisterUser",con);
            cmd.CommandType = CommandType.StoredProcedure ;
            cmd.Parameters.AddWithValue("@Flag", "Login");
            cmd.Parameters.AddWithValue("@typename", TypeName);
            cmd.Parameters.AddWithValue("@emailid", EmaiID);
            cmd.Parameters.AddWithValue("@password",PassWord);          
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;

            con.Close();
        }
        public clsRegister( int UID, int sizeid, DateTime orderdate, string orderstatus, int discount, decimal newPrice, bool iSDelete)
        {
            UserID = UID;
            SizeID = sizeid;
            OrderDate = orderdate;
            OrderStatus = orderstatus;
            Discount = discount;
            NewPrice = newPrice;
            ISDelete = iSDelete;
        }
        public void OrderConfirmed()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("RegisterUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Order Conformed");
            cmd.Parameters.AddWithValue("@Usizeid", SizeID);
            cmd.Parameters.AddWithValue("@userid", UserID);
            cmd.Parameters.AddWithValue("@orderdate", OrderDate);
            cmd.Parameters.AddWithValue("@orderstatus", OrderStatus);
            cmd.Parameters.AddWithValue("@discount", Discount);
            cmd.Parameters.AddWithValue("@discountprice", NewPrice);
            cmd.Parameters.AddWithValue("@isdelete", ISDelete);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable GetAllProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("RegisterUser",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetAllProduct");
            cmd.ExecuteNonQuery();
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public clsRegister(int orderid, int discount,decimal newPrice)
        {
            OrderID = orderid;
            Discount = discount;
            NewPrice = newPrice;
        }
        public void UpdateNewPrice()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("RegisterUser",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdatePrice");
            cmd.Parameters.AddWithValue("@orderid", OrderID);
            cmd.Parameters.AddWithValue("@discount", Discount);
            cmd.Parameters.AddWithValue("@discountprice", NewPrice);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public clsRegister(string name, string productname)
        {
            Name = name;
            ProductName = productname;
        }
        public DataTable Search()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("RegisterUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Search");
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@Uproductname", ProductName);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();
        }
        public DataTable Unorder_Customer()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("RegisterUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Unorder Customer");
            cmd.ExecuteNonQuery();
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable Unorder_Product()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("RegisterUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Unorder Product");
            cmd.ExecuteNonQuery();
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
      
        public void ISDeleted()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("RegisterUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ISDelete");
            cmd.Parameters.AddWithValue("@orderid", OrderID);
            cmd.ExecuteNonQuery();
            con.Close();

        }


    }
    
    
}
