using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Essens_Anwendung
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Source\Repos\Essens_Anwendung\Essens_Anwendung\App_Data\Database1.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            disp_data();
        }

        protected void Button_Auswerten_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            string Essen = DropDownList_Essen.SelectedItem.Text;
            String Name = DropDownList_Name.SelectedItem.Text;
            String Zusatz = DropDownList_Zusatz.SelectedItem.Text;

            cmd.CommandText =   "insert into table1 values('" + Name + "','" + Essen + "','" + Zusatz + "')";
            cmd.ExecuteNonQuery();
            disp_data();

           
        }
        public void disp_data()
        {
            SqlCommand cmd = new SqlCommand(/*@"INSERT INTO [Table](Name,Essen,Zusatz) VALUES (@Name,@Essen,@Zusatz)"+*/);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "select * from table1";
            cmd.ExecuteNonQuery();
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            
        }

        protected void Button_Löschen_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            string Essen = DropDownList_Essen.SelectedItem.Text;
            String Name = DropDownList_Name.SelectedItem.Text;
            String Zusatz = DropDownList_Zusatz.SelectedItem.Text;

            cmd.CommandText = "delete from table1 where Name='" + Name + "'";
            cmd.ExecuteNonQuery();

            disp_data();
        }
    }
}