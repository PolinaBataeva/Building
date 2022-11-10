using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Building.App_Code.DAL
{
    public class Exrenses
    {
        public int RowNumber { get; set; }
        public int IdExrenses { get; set; }
        public string WorkPerformel { get; set; }
        public int CostAmount { get; set; }

        public Exrenses()
        {
            RowNumber = 0;
            IdExrenses = 0;
            WorkPerformel = string.Empty;
            CostAmount = 0;
        }
        public static Exrenses Map(DataRow dataRow)
        {
            Exrenses result = new Exrenses();
            result.IdExrenses = (int)dataRow["IdExrenses"];
            result.WorkPerformel = dataRow["WorkPerformel"].ToString();
            result.CostAmount = (int)dataRow["CostAmount"];
            return result;

        }
        public static Exrenses Map(DataRow dataRow, int index)
        {
            Exrenses result = Map(dataRow);
            result.RowNumber = index;
            return result;
        }
    }
}