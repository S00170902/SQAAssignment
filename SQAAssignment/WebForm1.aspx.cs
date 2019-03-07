using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQAAssignment
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static int ageInput;
        static string genderInput;
        static InsuranceService ins = new InsuranceService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton g = sender as RadioButton;
            genderInput = g.Text;
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string a = age.Text;
            int ageInput = int.Parse(a);

            float premium = ins.CalcPremium(ageInput, genderInput);

            prem.Text = "Your premium is: " + premium.ToString();
        }
    }
}