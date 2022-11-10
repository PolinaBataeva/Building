using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Building.App_Code.DAL
{
    public class WorkPerformel
    {

        public int RowNumber { get; set; }
        public int IdWork { get; set; }
        public string TypeOfWork { get; set; }
        public int Durability { get; set; }

        public WorkPerformel()
        {
            RowNumber = 0;
            IdWork = 0;
            TypeOfWork = string.Empty;
            Durability = 0;
        }
        public static WorkPerformel Map(DataRow dataRow)
        {
            WorkPerformel result = new WorkPerformel();
            result.IdWork = (int)dataRow["IdWork"];
            result.TypeOfWork = dataRow["TypeOfWork"].ToString();
            result.Durability = (int)dataRow["Durability"];
            return result;

        }
        public static WorkPerformel Map(DataRow dataRow, int index)
        {
            WorkPerformel result = Map(dataRow);
            result.RowNumber = index;
            return result;
        }
    }
}