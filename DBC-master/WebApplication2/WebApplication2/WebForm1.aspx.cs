using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string str;

        protected void Page_Load(object sender, EventArgs e)
        {

            con = new MySqlConnection("Data Source=127.0.0.1;Database=problema4;User ID=root;Password= ; port = 3306");
            con.Open();
            //Response.Write("connect");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double altura = Convert.ToDouble(TextBox3.Text); 
            String nombre = Convert.ToString(TextBox1.Text);
            String contacto = Convert.ToString(TextBox2.Text);

            try
            {
                if (altura <= 160)
                {
                    str = "insert into clientesb (nombre, contacto, estatura) values ( '" + nombre + "', '" + contacto + "', '" + altura + "')";
                    cmd = new MySqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    Label5.Text = "La informacion ha sido ingresada existosamente";



                }
               
                if (altura >= 180)
                {

                    str = "insert into clientesa (nombre, contacto, estatura) values ( '" + nombre + "', '" + contacto + "', '" + altura + "')";
                    cmd = new MySqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    Label5.Text = "La informacion ha sido ingresada existosamente";

                }

                if (altura >= 161 && altura <= 179)
                {

                    str = "insert into clientesc (nombre, contacto, estatura) values ( '" + nombre + "', '" + contacto + "', '" + altura + "')";
                    cmd = new MySqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    Label5.Text = "La informacion ha sido ingresada existosamente";
                }
                
            }

            catch(Exception ex)
            {
                Label5.Text = "La informacion no se pudo ingresar.";
            }











        }
    }
}