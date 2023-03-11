using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ShopManagement
{   class clsShopManagement
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
    
        public clsShopManagement()
        {

        }
       
        public clsShopManagement(string type)
        {
            Type = type;
        }
        public void SaveType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveType");
            cmd.Parameters.AddWithValue("@Utype", Type);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable GetProductType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetType");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();

        }
        public clsShopManagement(string name, int id)
        {
            ProductName = name;
            TypeID = id;
        }
        public void SaveProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;  
            cmd.Parameters.AddWithValue("@Flag", "SaveProduct");
            cmd.Parameters.AddWithValue("@Utypeid", TypeID);
            cmd.Parameters.AddWithValue("@Uproductname", ProductName);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        
        public DataTable GetSizeType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetSizeType");

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand= cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();
        }
        public clsShopManagement(int typeid)
        {
            TypeID = typeid;
        }
        public DataTable GetSizeProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetSizeProduct");
            cmd.Parameters.AddWithValue("@Utypeid", TypeID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

            con.Close();
        }

        public clsShopManagement(string size, decimal mrp, decimal realprice, int typeid, int productid)
        {
            Size = size;
            MRP = mrp;
            RealPRice = realprice;
            TypeID = typeid;
            ProductID = productid;

        }
        public void SaveSize()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ShopManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveSize");
            cmd.Parameters.AddWithValue("@Utypeid", TypeID);
            cmd.Parameters.AddWithValue("@Uproductid",ProductID);
            cmd.Parameters.AddWithValue("@Usize",Size);
            cmd.Parameters.AddWithValue("@Umrp",MRP);
            cmd.Parameters.AddWithValue("@Urealprice", RealPRice);
            cmd.ExecuteNonQuery();

            con.Close();
        }

    }
}
