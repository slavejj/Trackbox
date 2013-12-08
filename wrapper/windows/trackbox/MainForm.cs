using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xilium.CefGlue.WindowsForms;

namespace trackbox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var browser = new CefWebBrowser();
            browser.StartUrl = "http://trackboxapp.com";
            browser.Dock = DockStyle.Fill;
           
            page.Controls.Add(browser);
        }
    }
}
