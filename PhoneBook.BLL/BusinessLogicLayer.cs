using CsvHelper;
using CsvHelper.Configuration;
using PhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PhoneBook.BLL
{
    public class BusinessLogicLayer
    {
        PhoneBook.Core.DatabaseLogicLayer DLL;


        public BusinessLogicLayer()
        {
            DLL = new Core.DatabaseLogicLayer();
        }

        public int UserControl(string username, string password)
        {
            int cap = 0;
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                cap = DLL.UserControl(new User() { Username = username, Password = password });
                cap = 1;
            }
            else
            {
                cap = -100; // Required fields are not filled
            }
            return cap;
        }

        public int NewRegistration(Guid id, string name, string surname, string phoneI, string phoneII, string phoneIII, string address, string emailAddress, string website, string description)
        {
            int cap = 0;
            if (id != Guid.Empty && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname) && !string.IsNullOrEmpty(phoneI))
            {
                DirectoryRegistration DR = new DirectoryRegistration()
                {
                    Id = id,
                    Name = name,
                    Surname = surname,
                    PhoneI = phoneI,
                    PhoneII = phoneII,
                    PhoneIII = phoneIII,
                    Address = address,
                    EmailAddress = emailAddress,
                    Website = website,
                    Description = description
                };
                cap = DLL.NewRegistration(DR);
            }
            else
            {
                cap = -100; // Required fields are not filled
            }
            return cap;


        }

        public int UpdateRegistration(Guid id, string name, string surname, string phoneI, string phoneII, string phoneIII, string address, string emailAddress, string website, string description)
        {
            int cap = 0;
            if (id != Guid.Empty && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname) && !string.IsNullOrEmpty(phoneI))
            {
                DirectoryRegistration DR = new DirectoryRegistration()
                {
                    Id = id,
                    Name = name,
                    Surname = surname,
                    PhoneI = phoneI,
                    PhoneII = phoneII,
                    PhoneIII = phoneIII,
                    Address = address,
                    EmailAddress = emailAddress,
                    Website = website,
                    Description = description
                };
                cap = DLL.UpdateRegistration(DR);
            }
            else
            {
                cap = -100; // Required fields are not filled
            }
            return cap;
        }

        public int DeleteRegistration(Guid id)
        {
            return DLL.DeleteRegistration(id);
        }

        public int XMLDataExport()
        {
            int cap = 0;

            try
            {
                List<DirectoryRegistration> regs = DLL.GetDirectoryRegistrations();

                XDocument doc = new XDocument(new XDeclaration("1.0.0.1", "UTF-8", "yes"), new XElement("BookRecords",
                    regs.Select(I => new XElement("Registration", new XElement("ID", I.Id),
                                                    new XElement("Name", I.Name),
                                                    new XElement("Surname", I.Surname),
                                                    new XElement("PhoneI", I.PhoneI),
                                                    new XElement("PhoneII", I.PhoneII),
                                                    new XElement("PhoneIII", I.PhoneIII),
                                                    new XElement("Address", I.Address),
                                                    new XElement("EmailAddress", I.EmailAddress),
                                                    new XElement("Website", I.Website),
                                                    new XElement("Description", I.Description)
                                                    ))));
                doc.Save("C:\\PhoneBookDB\\BookRecordsXML.xml");
                cap = 1;

            }
            catch (Exception ex)
            {
                cap = 0;
            }


            return cap;
        }

        public int CSVDataExport()
        {
            int cap = 0;
            try
            {

                List<DirectoryRegistration> regs = DLL.GetDirectoryRegistrations();
                StreamWriter sw = new StreamWriter("C:\\PhoneBookDB\\BookRecordsCSV.csv");
                CsvWriter cw = new CsvWriter(sw, CultureInfo.GetCultureInfo("tr_TR"));

                cw.WriteHeader<DirectoryRegistration>();
                cw.NextRecord();
                foreach (DirectoryRegistration item in regs)
                {
                    cw.WriteRecord(item);
                    cw.NextRecord();
                }
                sw.Flush();
                cap = 1;

            }
            catch (Exception ex)
            {
                cap = 0;

            }

            return cap;
        }

        public int JSONDataExport()
        {
            int cap = 0;

            try
            {
                List<DirectoryRegistration> regs = DLL.GetDirectoryRegistrations();
                string jsonText = Newtonsoft.Json.JsonConvert.SerializeObject(regs);
                File.WriteAllText("C:\\PhoneBookDB\\BookRecordsJSON.json", jsonText);
                cap = 1;
            }
            catch(Exception ex)
            {

            }


            return cap;
        }


        public List<DirectoryRegistration> GetDirectoryRegistrations()
        {
            return DLL.GetDirectoryRegistrations();
        }






    }
}
