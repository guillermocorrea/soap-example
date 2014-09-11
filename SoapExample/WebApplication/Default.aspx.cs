using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class _Default : Page
    {
        private ServiceCalculator.ServiceCalculatorClient _proxy = new ServiceCalculator.ServiceCalculatorClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SumButton_Click(object sender, EventArgs e)
        {
            this.Total.Text = this._proxy.Sum(Double.Parse(this.Number1.Text), Double.Parse(this.Number2.Text)).ToString();
        }

        protected void SubtractButton_Click(object sender, EventArgs e)
        {
            this.Total.Text = this._proxy.Subtract(Double.Parse(this.Number1.Text), Double.Parse(this.Number2.Text)).ToString();
        }
    }
}