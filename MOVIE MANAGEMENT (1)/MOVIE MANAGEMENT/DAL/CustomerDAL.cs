using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAL
{
    public class CustomerDAL : DataBase
    {

        private static CustomerDAL _instance;
        public static CustomerDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CustomerDAL();
                return _instance;
            }
            set { }
        }
        public DataTable LoadAllCustomer()
        {
            string query = "SELECT * FROM TBCustomer where customer_id != 1000";
            return LoadData(query);
        }
        public DataTable LoadSearchCustomer(string txt)
        {
            string query = "Select  * from TBCustomer where customer_phone_number = '" + txt + "' or customer_name like '%" + txt+"%'; ";
            return LoadData(query);
        }
        public DataRow LoadCustomerByID(int id)
        {
            string query = "SELECT * FROM TBCustomer WHERE customer_id = " + id + ";";
            return LoadData(query).Rows[0];
        }
        public DataTable CheckPhoneAdd(string phone_number)
        {
            return LoadData("Select customer_phone_number from TBCustomer where customer_phone_number = '" + phone_number + "'");
        }
        public void Add(Customer customer)
        {
            EditData("Insert into TBCustomer(customer_name, customer_birthday, customer_address,customer_phone_number) " +
                "values('"+ customer.customer_name + "','" + customer.customer_birthday + "','" + customer.customer_address + "','" + customer.customer_phone_number + "')");
        }
        public DataTable CheckPhoneUpdate(Customer customer)
        {
            return LoadData("Select customer_phone_number from TBCustomer where customer_phone_number = '" + customer.customer_phone_number + "' and customer_id != " + customer.customer_id); 
        }
        public void Update(Customer customer)
        {
            EditData("UPDATE TBCustomer set customer_name = '" + customer.customer_name + "', customer_birthday = '" + customer.customer_birthday +
              "', customer_address = '" + customer.customer_address + "', customer_phone_number = '" + customer.customer_phone_number + "' where customer_id = '" + customer.customer_id + "'");
        }
        public void Delete(int id)
        {
            EditData("DELETE FROM TBCustomer WHERE customer_id = " + id);
        }
        public void UpdateRewardPoint(int price, int customer_id)
        {       
            EditData("update TBCustomer set customer_accumulated_reward_points = "+Convert.ToInt32(price * 5 / 100 / 1000) +" where customer_id = "+customer_id);
        }
    }
}
