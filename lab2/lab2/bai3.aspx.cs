﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab2
{
    public partial class bai3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            string targetPage = e.Item.Value;
            Response.Redirect(targetPage);
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = ListBox1.SelectedValue;
            string imagePath = $"~/Images/{selectedValue}.jpg";
            Image1.ImageUrl = imagePath;
        }
    }
}