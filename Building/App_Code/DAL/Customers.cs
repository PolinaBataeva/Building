using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Building.App_Code.DAL
{
    public class Customers
    {
        public int RowNumber { get; set; }
        public int IdFirm { get; set; }
        public int IdCustomers { get; set; }
        public string FIO { get; set; }
        public int IdExpense { get; set; }


        public Customers()
        {
            IdFirm = 0;
            IdCustomers = 0;
            FIO = string.Empty;
            IdExpense = 0;
        }
        public static Customers Map(DataRow dataRow)
        {
            Customers result = new Customers();
            result.IdFirm = (int)dataRow["IdFirm"];
            result.IdCustomers = (int)dataRow["IdCustomers"];
            result.FIO = dataRow["FIO"].ToString();
            result.IdExpense = (int)dataRow["IdExpense"];
            return result;

        }

        public static Customers Map(DataRow dataRow, int index)
        {
            Customers result = Map(dataRow);
            result.RowNumber = index;
            return result;
        }
    }
}