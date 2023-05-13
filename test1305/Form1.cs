using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1305
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLocalization_Click(object sender, EventArgs e)
        {
            switch (buttonLocalization.Text)
            {
                case "ENG":
                    {
                        ChangeLocalization("ru-RU");

                        break;
                    }
                case "RU":
                    {
                        ChangeLocalization("uk-UA");
                        break;
                    }
                case "UA":
                    {
                        ChangeLocalization("en-EN");
                        break;
                    }
            }
        }

        private void ChangeLocalization(string lang)
        {
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
            CultureInfo cultureInfo = new CultureInfo(lang);

            foreach (Control item in this.Controls)
            {
                componentResourceManager.ApplyResources(item, item.Name, cultureInfo);
            }
        }
    }
}
