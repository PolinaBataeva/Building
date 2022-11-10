using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Building.App_Code.DAL
{
    public class Staff
    {
        public int RowNumber { get; set; }
        public int IdFirm { get; set; }
        public int IdStaff { get; set; }
        public string FIO { get; set; }
        public string Post { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfHiring { get; set; }
        public string PhoneNumb { get; set; }
        public Staff()
        {
            RowNumber = 0;
            IdFirm = 0;
            IdStaff = 0;
            FIO = string.Empty;
            Post = string.Empty;
            DateOfBirth = null;
            DateOfHiring = null;
        }
        public static Staff Map(DataRow dataRow)
        {
            Staff result = new Staff();
            result.IdFirm = (int)dataRow["IdFirm"];
            result.IdStaff = (int)dataRow["IdStaff"];
            result.FIO = dataRow["FIO"].ToString();
            result.Post = dataRow["Post"].ToString();
            result.DateOfBirth = dataRow["DateOfBirth"] != DBNull.Value ? (DateTime?)dataRow["DateOfBirth"] : null;
            result.DateOfHiring = dataRow["DateOfHiring"] != DBNull.Value ? (DateTime?)dataRow["DateOfHiring"] : null;
            return result;

        }
        public static Staff Map(DataRow dataRow, int index)
        {
            Staff result = Map(dataRow);
            result.RowNumber = index;
            return result;
        }
    }
}