using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3TIB_GitHub.pertama
{
    public partial class cobalabel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }
        
        Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        {
        LblHasil.Text = "Nama Anda : " & TextNama.Text
        LblHasil.Text += "Nim Anda : " & TextNim.Text
        LblHasil.Text += "Prodi anda : " & TextProdi.Text
        }
    }
}
