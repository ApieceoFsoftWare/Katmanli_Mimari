using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katmanli_Mimari
{
    internal class BusinessLogicLayer
    {
        DataAccessLayer _layer;
        public BusinessLogicLayer()
        {
            _layer = new DataAccessLayer();
        }
        internal int SaveData(int CustomerID, string name, string surname)
        {
            if(!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname)) 
            {
                Customer customer = new Customer();
                customer.CustomerID = CustomerID;
                customer.Name = name;
                customer.Surname = surname;

                return _layer.SaveData(customer);
            }
            else
            {
                return -1; // Eksik parametre hatası...
            }
        }
    }
}
