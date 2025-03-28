
using PhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook.UI
{
    public partial class MainForm : Form
    {
        BLL.BusinessLogicLayer BLL;
        public MainForm()
        {
            InitializeComponent();
            BLL = new BLL.BusinessLogicLayer();
            DataLoad();
        }


        private void btn_newRegistration_Click(object sender, EventArgs e)
        {
            int cap = BLL.NewRegistration(
                        Guid.NewGuid(),
                        txt_name.Text, txt_surname.Text, txt_phoneI.Text, txt_phoneII.Text, txt_phoneIII.Text,
                        txt_address.Text, txt_emailAddress.Text, txt_website.Text, txt_description.Text);

            if (cap > 0)
            {
                MessageBox.Show("Registration was successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataLoad();
            }
            else if (cap == -100)
            {
                MessageBox.Show("There was missing parameter. Please fill at least Name, Surname and PhoneI sections.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("There was an error in the registration.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_updateRegistration_Click(object sender, EventArgs e)
        {
            if (lst_bookList.SelectedItem != null)
            {
                Guid id = ((DirectoryRegistration)lst_bookList.SelectedItem).Id;
                int cap = BLL.UpdateRegistration(id, txt_name.Text,
                            txt_surname.Text, txt_phoneI.Text, txt_phoneII.Text, txt_phoneIII.Text, txt_address.Text,
                            txt_emailAddress.Text, txt_website.Text, txt_description.Text);

                if (cap > 0)
                {
                    MessageBox.Show("Registration was updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataLoad();
                }
                else if (cap == -100)
                {
                    MessageBox.Show("There was missing parameter. Please fill at least Name, Surname and PhoneI sections.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("There was an error in the registration.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
        }




        private void DataLoad()
        {
            List<DirectoryRegistration> directoryRegs = BLL.GetDirectoryRegistrations();
            if (directoryRegs != null && directoryRegs.Count > 0)
            {
                lst_bookList.DataSource = directoryRegs;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void lst_bookList_DoubleClick(object sender, EventArgs e)
        {
            ListBox LB = (ListBox)sender;
            DirectoryRegistration DR = (DirectoryRegistration)LB.SelectedItem;
            txt_name.Text = DR.Name;
            txt_surname.Text = DR.Surname;
            txt_phoneI.Text = DR.PhoneI;
            txt_phoneII.Text = DR.PhoneII;
            txt_phoneIII.Text = DR.PhoneIII;
            txt_emailAddress.Text = DR.EmailAddress;
            txt_address.Text = DR.Address;
            txt_website.Text = DR.Website;
            txt_description.Text = DR.Description;

            gb_registration.Text = "Update Registration";


        }

        private void btn_deleteRegistration_Click(object sender, EventArgs e)
        {
            DirectoryRegistration DR = (DirectoryRegistration)lst_bookList.SelectedItem;
            int cap = BLL.DeleteRegistration(DR.Id);
            if (cap > 0)
            {
                MessageBox.Show("Delete was successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataLoad();
            }
            else
            {
                MessageBox.Show("There was an error in the delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_xmlExport_Click(object sender, EventArgs e)
        {
            int cap = BLL.XMLDataExport();
            ExportHandle(cap);
        }

        private void btn_csvExport_Click(object sender, EventArgs e)
        {
            int cap = BLL.CSVDataExport();
            ExportHandle(cap);
        }


        private void btn_jsonExport_Click(object sender, EventArgs e)
        {
            int cap = BLL.JSONDataExport();
            ExportHandle(cap);
        }



        #region Helper
        private void ExportHandle(int cap)
        {
            if (cap > 0)
            {
                progbar_status.Value = 100;
                MessageBox.Show("Export was successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progbar_status.Value = 0;

            }
            if (cap == 0)
            {
                MessageBox.Show("There was an error in the export.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

    }
}
