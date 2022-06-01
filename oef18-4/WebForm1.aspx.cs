using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

namespace oef18_4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != TextBox2.Text)
            {
                Label2.Visible = true;

                HttpCookie cookie = Request.Cookies["SurveyCookie"];
                if (cookie == null)
                {
                    // no cookie found, create it
                    cookie = new HttpCookie("SurveyCookie");
                    cookie.Values["surveyPage"] = "0";

                }
                else
                {
                    // update the cookie values
                    int newSurveyPage = int.Parse(cookie.Values["surveyPage"]) + 1;
                    cookie.Values["surveyPage"] = newSurveyPage.ToString();
                }

                // update the expiration timestamp
                cookie.Expires = DateTime.UtcNow.AddDays(30);

                // overwrite the cookie
                Response.Cookies.Add(cookie);


                if (Convert.ToInt32(cookie.Value[0]) == 3)
                {
                    Label1.Visible = true;
                    Button1.Visible = false;
                    Thread.Sleep(5000);
                    Label1.Visible = false;
                    Button1.Visible = true;
                    cookie.Value = "0";
                }
            }
            else
            {
                Label2.Visible=false;
            }
        }
    }
}