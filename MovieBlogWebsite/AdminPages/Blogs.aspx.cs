﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieBlogWebsite.Entity;
namespace MovieBlogWebsite.AdminPages
{
    public partial class Blogs : System.Web.UI.Page
    {
        BlogMovieEntities dt = new BlogMovieEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = dt.TBLBLOG.ToList();
            Repeater1.DataBind();
        }
    }
}