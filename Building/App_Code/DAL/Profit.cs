using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Building.App_Code.DAL
{
    public class Profit
    {
        public int RowNumber { get; set; }
        public int IdFirm { get; set; }
        public int IdProfit { get; set; }
        public int Date { get; set; }
        public int Profits { get; set; }
        public Profit()
        {
            RowNumber = 0;
            IdFirm = 0;
            IdProfit = 0;
            Date = 0;
            Profits = 0;
        }

        public static Profit Map(DataRow dataRow)
        {
            Profit result = new Profit();
            result.IdFirm = (int)dataRow["IdFirm"];
            result.IdProfit = (int)dataRow["IdProfit"];
            result.Date = (int)dataRow["Date"];
            result.Profits = (int)dataRow["Profit"];
           
            return result;

        }

        public static Profit Map(DataRow dataRow, int index)
        {
            Profit result = Map(dataRow);
            result.RowNumber = index;
            return result;
        }
    }
}