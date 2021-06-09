using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

public partial class CONTACTS : System.Web.UI.Page
{
    SqlCommand cmd;
    SqlConnection cn;
    protected void Page_Load(object sender, EventArgs e)
    {
        String str = "database=Contacts; Trusted_Connection=True; Server=MANISH-PC";
 
            cn= new SqlConnection(str);

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand();
        cmd.CommandText = "insert into contact values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
        cmd.Connection = cn;
        cn.Open();
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {
            MessageBox.Show("bhai save ho gya !!!");
        }
        else 
        {
            MessageBox.Show("Bhai Plz try Again");
        }
        cn.Close();

    }
}