using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Portfolio()
        {
            ViewBag.Message = "Your Portfolio page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult FAQ()
        {
            ViewBag.Message = "Your FAQ page.";

            return View();
        }

        public ActionResult Feedback()
        {
            ViewBag.Message = "Send Feedback page.";

            return View();
        }

        public class BlogPost
        {
            public string id;
            public string text;
            public string userid;
            public string date;
        }


        public ActionResult Blog()
        {
            ViewBag.Message = "Your Blog page.";

            SqlConnection sqlConnection1 = new SqlConnection(
            "Server=(LocalDb)\\v11.0;Database=aspnet-FirstProject-20160628191641;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT * FROM BlogPosts";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();
            // Data is accessible through the DataReader object here.
            var blogpost = new BlogPost();

            while (reader.Read())
            {
                blogpost.id = reader["NoteId"].ToString();
                blogpost.text = reader["BlogPost"].ToString();
                blogpost.userid = reader["UserId"].ToString();
                blogpost.date = reader["DatePosted"].ToString();
                
            }

            sqlConnection1.Close();

            //blogcontent

            return View(blogpost);
        }
    }
}
