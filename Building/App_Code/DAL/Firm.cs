using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Building.App_Code.DAL
{
    public class Firm
    {
        public int RowNumber { get; set; }
        public int IdFirm { get; set; }
        public string NameFirm { get; set; }
        public string WorkingHours { get; set; }
        public string Address { get; set; }
        public string PhoneNumb { get; set; }

        public Firm() {
            RowNumber = 0;
            IdFirm = 0;
            NameFirm = string.Empty;
            WorkingHours = string.Empty;
            Address = string.Empty;
            PhoneNumb = string.Empty;
        }

        public static Firm Map(DataRow dataRow)
        {
            Firm result = new Firm();
            result.IdFirm = (int)dataRow["IdFirm"];
            result.NameFirm = dataRow["NameFirm"].ToString();
            result.WorkingHours = dataRow["WorkingHours"].ToString();
            result.Address = dataRow["Address"].ToString();
            result.PhoneNumb = dataRow["PhoneNumb"].ToString();
            return result;
            
        }

        public static Firm Map(DataRow dataRow, int index)
        {
            Firm result = Map(dataRow);
            result.RowNumber = index;
            return result;
        }
    }
}