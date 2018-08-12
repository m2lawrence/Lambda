using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LambdaWebApp1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //write a LINQ query using Lambda Expressions.
            //use IEnumerable and store it in "QueryResult"
            //bind to GridView.

            IEnumerable<Student> QueryResult = Student.GetAllStudents().Where(student => student.Gender == "Male");

            //display the data in a GridView.
            GridView1.DataSource = QueryResult;

            //invoke the data bind method to the GridView.
            GridView1.DataBind();
        }
    }
}