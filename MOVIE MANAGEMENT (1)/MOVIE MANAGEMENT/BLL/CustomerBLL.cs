using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EmailValidation;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Security.Cryptography;
using DAL;
using DTO;

namespace BLL
{
    public class CustomerBLL
    {
        private static CustomerBLL _instance;
        public static CustomerBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CustomerBLL();
                return _instance;
            }
            set { }
        }
        public DataTable LoadAllCustomer()
        {
            return CustomerDAL.Instance.LoadAllCustomer();
        }
        public DataTable LoadSearchCustomer(string txt)
        {
            return CustomerDAL.Instance.LoadSearchCustomer(txt);
        }
        public DataRow LoadCustomerByID(int id)
        {
            return CustomerDAL.Instance.LoadCustomerByID(id);
        }
        public bool CheckPhoneNumber(string pn)
        {
            return Regex.IsMatch(pn, "^[0-9]{10}$");
        }

        public string CheckFormartCustomer(Customer customer)
        {
            if (customer.customer_name == "") return "Invalid Fullname. Please enter customer's name.";
            if (customer.customer_address == "") return "Invalid Address! Please enter customer's address.";
            if (!CheckPhoneNumber(customer.customer_phone_number)) return "Invalid phone number! Customer's phone number.\nmust contain 10 characters.";

            return "OK";
        }
        public string Add(Customer customer)
        {
            string check = CheckFormartCustomer(customer);
            if (check != "OK") return check;
            if (CustomerDAL.Instance.CheckPhoneAdd(customer.customer_phone_number).Rows.Count > 0)
                return "Phone number is already registered!";

            CustomerDAL.Instance.Add(customer);
            
            return "ADD SUCCESSFUL !";
        }
        public string Update(Customer customer)
        {
            string check = CheckFormartCustomer(customer);
            if (check != "OK") return check;
            if (CustomerDAL.Instance.CheckPhoneUpdate(customer).Rows.Count > 0)
                return "Phone number is already registered!";

            CustomerDAL.Instance.Update(customer);

            return "UPDATE SUCCESSFUL !";
        }
        public void Delete(List<int> id)
        {
            foreach (int i in id)
            {
                CustomerDAL.Instance.Delete(i);
            }
        }
    }
}
