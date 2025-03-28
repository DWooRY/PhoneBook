using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool lc = LicenseControl();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (lc)
            {
                Application.Run(new form_Login());
            }
            else
            {
                Application.Run(new form_Lisans());
            }
            
        }

        static bool LicenseControl()
        {
            RegistryKey RK = Registry.CurrentUser.OpenSubKey("PhoneBook");
            if (RK != null)
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

                string hddSNRKSTR = RK.GetValue("HardDiskSerialNumber").ToString();
                string macAddressSTR = RK.GetValue("MacAddress").ToString();

                if (hddSNRKSTR == hardDiskSerialNumber && macAddressSTR == macAddress)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
                

        }
    }
}
