using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Net.Configuration;
using Microsoft.Win32;

namespace PhoneBook.UI
{
    public partial class form_Lisans : Form
    {
        public form_Lisans()
        {
            InitializeComponent();
        }

        private void btn_license_Click(object sender, EventArgs e)
        {
            if (txt_licenseKey.Text == "8e2b4136-829c-11eb-8dcd-0242ac130003")
            {
                string hardDiskSerialNumber = "";
                string macAddress = "";

                string disk = "C";
                ManagementObject MO = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + disk + ":\"");
                MO.Get();

                hardDiskSerialNumber = MO["VolumeSerialNumber"].ToString();

                ManagementClass MacAddress = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection NAL = MacAddress.GetInstances();

                foreach (ManagementObject item in NAL)
                {
                    if ((bool)item["IPEnabled"])
                    {
                        macAddress = item["MacAddress"].ToString();
                    }

                }
                if (!string.IsNullOrEmpty(hardDiskSerialNumber) && !string.IsNullOrEmpty(macAddress))
                {
                    RegistryKey key = Registry.CurrentUser.CreateSubKey("PhoneBook",true);
                    key.SetValue("HardDiskSerialNumber", hardDiskSerialNumber);
                    key.SetValue("MacAddress", macAddress);

                    MessageBox.Show("Licence key accepted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);   
                }


            }
            else
            {
                MessageBox.Show("Licence number denied.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
