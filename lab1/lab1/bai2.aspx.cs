using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab1
{
    public partial class bai2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void button_tong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(input_a.Text);
            int b = int.Parse(input_b.Text);
            int tong = a + b;
            resultLabel.Text = $"tổng 2 số là {tong}";
        }
        protected void button_hieu_Click(object sender, EventArgs e) 
        {
            int a = int.Parse(input_a.Text) ;
            int b = int.Parse (input_b.Text) ;
            int hieu = a - b ;
            resultLabel.Text = $"hiệu 2 số là {hieu}";
        }
        protected void button_tich_Click(object sender, EventArgs e)
        {
            int a = int.Parse(input_a.Text);
            int b = int.Parse(input_b.Text);
            int tich = a*b ;
            resultLabel.Text = $"tích 2 số là {tich}";
        }
       
    }
}