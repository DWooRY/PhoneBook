using PhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PhoneBook.Core
{
    public class DatabaseLogicLayer
    {
        List<DirectoryRegistration> directoryRegs = new List<DirectoryRegistration>();
        public DatabaseLogicLayer()
        {
            directoryRegs = new List<DirectoryRegistration>();
            DatabaseControl();
        }

        private void DatabaseControl()
        {
            bool control = Directory.Exists(@"C:\PhoneBookDB\");
            if (!control)
            {
                Directory.CreateDirectory(@"C:\PhoneBookDB\");

                User demo = new User()
                {
                    Id = Guid.NewGuid(),
                    Username = "admin",
                    Password = "admin"
                };

                string jsonUserText = Newtonsoft.Json.JsonConvert.SerializeObject(demo);
                File.WriteAllText("C:\\PhoneBookDB\\user.json", jsonUserText);
            }
        }

        public int NewRegistration(DirectoryRegistration DR)
        {
            int cap = 0;

            try
            {
                GetDirectoryRegistrations();
                directoryRegs.Add(DR);
                JsonDBUpdate();
                cap = 1;
            }
            catch (Exception ex)
            {
                cap = 0;
            }

            return cap;

        }

        public int UpdateRegistration(DirectoryRegistration DR)
        {
            int cap = 0;

            try
            {
                GetDirectoryRegistrations();
                int index = directoryRegs.FindIndex(I => I.Id == DR.Id);
                if (index > -1)
                {
                    directoryRegs[index].Name = DR.Name;
                    directoryRegs[index].Surname = DR.Surname;
                    directoryRegs[index].PhoneI = DR.PhoneI;
                    directoryRegs[index].PhoneII = DR.PhoneII;
                    directoryRegs[index].PhoneIII = DR.PhoneIII;
                    directoryRegs[index].Address = DR.Address;
                    directoryRegs[index].EmailAddress = DR.EmailAddress;
                    directoryRegs[index].Website = DR.Website;
                    directoryRegs[index].Description = DR.Description;
                    cap = 1;
                }
                JsonDBUpdate();
            }
            catch(Exception ex)
            {
            }
            return cap;
        }

        public int DeleteRegistration(Guid id)
        {
            int cap = 0;

            try
            {
                GetDirectoryRegistrations();
                DirectoryRegistration DR = directoryRegs.Find(I => I.Id == id);
                if (DR != null)
                {
                    directoryRegs.Remove(DR);
                }
                JsonDBUpdate();
                cap = 1;
            }
            catch(Exception ex)
            {

            }

            return cap;
        }



        public List<DirectoryRegistration> GetDirectoryRegistrations()
        {
            if (File.Exists("C:\\PhoneBookDB\\user.json"))
            {
                string jsonDBText = File.ReadAllText("C:\\PhoneBookDB\\user.json");
                directoryRegs = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DirectoryRegistration>>(jsonDBText);
            }
            return directoryRegs;
        }

        public int UserControl(User user)
        {
            int cap = 0;
            if (File.Exists("C:\\PhoneBookDB\\user.json"))
            {
                string jsonDBText = File.ReadAllText("C:\\PhoneBookDB\\user.json");
                List<User> users = Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>(jsonDBText);
                cap = users.FindAll(I => I.Username == user.Username && I.Password == user.Password).ToList().Count();
            }
            return cap;
        }




        #region Helper

        private void JsonDBUpdate()
        {
            if (directoryRegs != null && directoryRegs.Count > 0)
            {
                string jsonDBText = Newtonsoft.Json.JsonConvert.SerializeObject(directoryRegs);
                File.WriteAllText("C:\\PhoneBookDB\\user.json", jsonDBText);
            }
        }
        #endregion





























    }
}
