using ClassLibrary1;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            double r, h;
            string errorMessage = "";

            if (!double.TryParse(txtA.Text, out r) || r <= 0)
            {
                errorMessage += "Giá trị bán kính đáy không hợp lệ";
            }

            if (!double.TryParse(txtH.Text, out h) || h <= 0)
            {
                errorMessage += "Giá trị chiều cao không hợp lệ";
            }

            if (errorMessage != "")
            {
                lblResult.Text = "Lỗi: " + errorMessage;
            }
            else
            {
                double area = Class1.thetich(r, h);
                lblResult.Text = $"Diện tích hình nón là: {area}";
            }
        }
    }
}