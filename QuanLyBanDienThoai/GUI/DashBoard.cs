using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDienThoai.GUI
{
    public partial class Dashboard : Form
    {
        String _currentUser;
        public Dashboard(String name)
        {
            _currentUser = name;
            InitializeComponent();
            labelName.Text = _currentUser;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
