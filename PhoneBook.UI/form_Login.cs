using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneBook.BLL;

namespace PhoneBook.UI
{
    public partial class form_Login: Form
    {
        BLL.BusinessLogicLayer BLL;
        
        public form_Login()
        {
            InitializeComponent();
            BLL = new BLL.BusinessLogicLayer();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            int cap = BLL.UserControl(txt_username.Text, txt_password.Text);

            if (cap > 0)
            {
                MainForm form = new MainForm();
                form.Show();
                this.Hide();
                
            }
            else if (cap == -100) 
            {
                MessageBox.Show("Please fill in the required fields.","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Username or password is incorrect.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }
    }
}
