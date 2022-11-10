using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace Building.App_Code.DAL
{
    public class DataAccessor
    {
        private static OdbcConnection conn = null;
        public static OdbcConnection Conn
        {
            get
            {
                if (conn == null)
                {
                    conn = new OdbcConnection(Config.ConnectionString);
                }
                return conn;
            }
        }
        public static void CreateConnection(string connectionString)
        {
            conn = new OdbcConnection(connectionString);
        }

        private static OdbcCommand cmd = null;
        private static OdbcDataAdapter dataAdapter = null;


        #region Customers
        public static Customers SelectCustomers(int id)
        {
            Customers result = null;
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT [Customers].[IdCustomers].*FROM [Customers] WHERE [Customers].[IdCustomers]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[Customers] [IdCustomers]", id);
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                    if (dataTable.Rows.Count > 0)
                    {
                        result = Customers.Map(dataTable.Rows[0]);
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                return result;
            }
        }
        public static List<Customers> SelectCustomers()
        {
            List<Customers> result = new List<Customers>();
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT Customers.*FROM Customers";
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                int i = 1;
                foreach (DataRow row in dataTable.Rows)
                {
                    result.Add(Customers.Map(row, i));
                    i++;
                }
            }
            return result;
        }
        public static void DeleteCustomers(int id)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "DELETE FROM [Customers] WHERE [IdCustomers]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdCustomers]", id);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public static void UpdateCustomers(Customers entity)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "UPDATE [Customers] SET [IdCustomers]=?, [IdFirm]=?, [FIO]=?, [IdExpense]=? WHERE [IdCustomers]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdCustomers]", entity.IdCustomers);
                    cmd.Parameters.AddWithValue("[IdFirm]", entity.IdFirm);
                    cmd.Parameters.AddWithValue("[FIO]", entity.FIO);
                    cmd.Parameters.AddWithValue("[IdExpense]", entity.IdExpense);
                    cmd.Parameters.AddWithValue("[IdCustomers]", entity.IdCustomers);
                    cmd.ExecuteNonQuery();
                }

                finally
                {
                    conn.Close();
                }
            }
        }
        public static int InsertCustomers(Customers entity)
        {
            int result = 0;
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "INSERT INTO [Customers] ([IdCustomers], [IdFirm], [FIO], [IdExpense])" + "VALUES (?,?,?,?)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdCustomers]", entity.IdCustomers);
                    cmd.Parameters.AddWithValue("[IdFirm]", entity.IdFirm);
                    cmd.Parameters.AddWithValue("[FIO]", entity.FIO);
                    cmd.Parameters.AddWithValue("[IdExpense]", entity.IdExpense);
                    cmd.CommandText = "SELECT @@IDENTITY";
                    object o = cmd.ExecuteScalar();
                    if (o != null)
                    {
                        result = int.Parse(o.ToString());
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }
        #endregion


        #region Firm
        public static Firm SelectFirm(int id)
        {
            Firm result = null;
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT [Firm].[IdFirm].*FROM [Firm] WHERE [Firm].[IdFirm]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[Firm] [IdFirm]", id);
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                    if (dataTable.Rows.Count > 0)
                    {
                        result = Firm.Map(dataTable.Rows[0]);
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                return result;
            }
        }
        public static List<Firm> SelectFirm()
        {
            List<Firm> result = new List<Firm>();
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT Firm.*FROM Firm";
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                int i = 1;
                foreach (DataRow row in dataTable.Rows)
                {
                    result.Add(Firm.Map(row, i));
                    i++;
                }
            }
            return result;
        }
        public static void DeleteFirm(int id)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "DELETE FROM [Firm] WHERE [IdFirm]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdFirm]", id);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public static void UpdateFirm(Firm entity)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "UPDATE [Firm] SET [IdFirm]=?, [NameFirm]=?, [WorkingHours]=?, [Address]=?, [PhoneNumb]=? WHERE [IdFirm]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdFirm]", entity.IdFirm);
                    cmd.Parameters.AddWithValue("[NameFirm]", entity.NameFirm);
                    cmd.Parameters.AddWithValue("[WorkingHours]", entity.WorkingHours);
                    cmd.Parameters.AddWithValue("[Address]", entity.Address);
                    cmd.Parameters.AddWithValue("[PhoneNumb]", entity.PhoneNumb);
                    cmd.Parameters.AddWithValue("[IdFirm]", entity.IdFirm);
                    cmd.ExecuteNonQuery();
                }

                finally
                {
                    conn.Close();
                }
            }
        }
        public static int InsertFirm(Firm entity)
        {
            int result = 0;
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "INSERT INTO [Firm] ([IdFirm], [NameFirm], [WorkingHours], [Address],[PhoneNumb])" + "VALUES (?,?,?,?,?)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdFirm]", entity.IdFirm);
                    cmd.Parameters.AddWithValue("[NameFirm]", entity.NameFirm);
                    cmd.Parameters.AddWithValue("[WorkingHours]", entity.WorkingHours);
                    cmd.Parameters.AddWithValue("[Address]", entity.Address);
                    cmd.Parameters.AddWithValue("[PhoneNumb]", entity.PhoneNumb);
                    cmd.CommandText = "SELECT @@IDENTITY";
                    object o = cmd.ExecuteScalar();
                    if (o != null)
                    {
                        result = int.Parse(o.ToString());
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }
        #endregion




        #region Exrenses
        public static Exrenses SelectExrenses(int id)
        {
            Exrenses result = null;
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT [Exrenses].[IdExrenses].*FROM [Exrenses] WHERE [Exrenses].[IdExrenses]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[Exrenses] [IdExrenses]", id);
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                    if (dataTable.Rows.Count > 0)
                    {
                        result = Exrenses.Map(dataTable.Rows[0]);
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                return result;
            }
        }
        public static List<Exrenses> SelectExrenses()
        {
            List<Exrenses> result = new List<Exrenses>();
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT Exrenses.*FROM Exrenses";
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                int i = 1;
                foreach (DataRow row in dataTable.Rows)
                {
                    result.Add(Exrenses.Map(row, i));
                    i++;
                }
            }
            return result;
        }
        public static void DeleteExrenses(int id)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "DELETE FROM [Exrenses] WHERE [IdExrenses]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdExrenses]", id);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public static void UpdateExrenses(Exrenses entity)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "UPDATE [Exrenses] SET [IdExrenses]=?, [WorkPerformel]=?, [CostAmount]=? WHERE [IdExrenses]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdExrenses]", entity.IdExrenses);
                    cmd.Parameters.AddWithValue("[WorkPerformel]", entity.WorkPerformel);
                    cmd.Parameters.AddWithValue("[CostAmount]", entity.CostAmount);
                    cmd.Parameters.AddWithValue("[IdExrenses]", entity.IdExrenses);
                    cmd.ExecuteNonQuery();
                }

                finally
                {
                    conn.Close();
                }
            }
        }
        public static int InsertExrenses(Exrenses entity)
        {
            int result = 0;
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "INSERT INTO [Exrenses] ([IdExrenses], [WorkPerformel], [CostAmount])" + "VALUES (?,?,?)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdExrenses]", entity.IdExrenses);
                    cmd.Parameters.AddWithValue("[WorkPerformel]", entity.WorkPerformel);
                    cmd.Parameters.AddWithValue("[CostAmount]", entity.CostAmount);
                    object o = cmd.ExecuteScalar();
                    if (o != null)
                    {
                        result = int.Parse(o.ToString());
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }
        #endregion




        #region Profit
        public static Profit SelectProfit(int id)
        {
            Profit result = null;
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT [Profit].[IdProfit].*FROM [Profits] WHERE [Profits].[IdProfit]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[Profit] [IdProfit]", id);
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                    if (dataTable.Rows.Count > 0)
                    {
                        result = Profit.Map(dataTable.Rows[0]);
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                return result;
            }
        }
        public static List<Profit> SelectProfit()
        {
            List<Profit> result = new List<Profit>();
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT Profit.*FROM Profit";
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                int i = 1;
                foreach (DataRow row in dataTable.Rows)
                {
                    result.Add(Profit.Map(row, i));
                    i++;
                }
            }
            return result;
        }
        public static void DeleteProfit(int id)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "DELETE FROM [Profit] WHERE [IdProfit]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdProfit]", id);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public static void UpdateProfit(Profit entity)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "UPDATE [Profit] SET [IdProfit]=?, [IdFirm]=?, [CostAmount]=?,[Profit]=? WHERE [IdProfit]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdProfit]", entity.IdProfit);
                    cmd.Parameters.AddWithValue("[IdFirm]", entity.IdFirm);
                    cmd.Parameters.AddWithValue("[Date]", entity.Date);
                    cmd.Parameters.AddWithValue("[Profits]", entity.Profits);
                    cmd.Parameters.AddWithValue("[IdProfit]", entity.IdProfit);
                    cmd.ExecuteNonQuery();
                }

                finally
                {
                    conn.Close();
                }
            }
        }
        public static int InsertProfit(Profit entity)
        {
            int result = 0;
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "INSERT INTO [Profit] ([IdProfit], [IdFirm], [Date],[Profit])" + "VALUES (?,?,?,?)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdProfit]", entity.IdProfit);
                    cmd.Parameters.AddWithValue("[IdFirm]", entity.IdFirm);
                    cmd.Parameters.AddWithValue("[Date]", entity.Date);
                    cmd.Parameters.AddWithValue("[Profits]", entity.Profits);
                    object o = cmd.ExecuteScalar();
                    if (o != null)
                    {
                        result = int.Parse(o.ToString());
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }
        #endregion



        #region Staff
        public static Staff SelectStaff(int id)
        {
            Staff result = null;
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT [Staff].[IStaff].*FROM [Staff] WHERE [Staff].[IdStaff]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[Staff] [IdStaff]", id);
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                    if (dataTable.Rows.Count > 0)
                    {
                        result = Staff.Map(dataTable.Rows[0]);
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                return result;
            }
        }
        public static List<Staff> SelectStaff()
        {
            List<Staff> result = new List<Staff>();
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT Staff.*FROM Staff";
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                int i = 1;
                foreach (DataRow row in dataTable.Rows)
                {
                    result.Add(Staff.Map(row, i));
                    i++;
                }
            }
            return result;
        }
        public static void DeleteStaff(int id)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "DELETE FROM [Staff] WHERE [IdStaff]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdStaff]", id);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public static void UpdateStaff(Staff entity)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "UPDATE [Staff] SET [IdStaff]=?, [IdFirm]=?, [FIO]=?,[Post]=?,[DateOfBirth]=?,[DateOfHiring]=?, WHERE [IdStaff]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdStaff]", entity.IdStaff);
                    cmd.Parameters.AddWithValue("[IdFirm]", entity.IdFirm);
                    cmd.Parameters.AddWithValue("[FIO]", entity.FIO);
                    cmd.Parameters.AddWithValue("[Post]", entity.Post);
                    cmd.Parameters.AddWithValue("[DateOfBirth]", entity.DateOfBirth);
                    cmd.Parameters.AddWithValue("[DateOfHiring]", entity.DateOfHiring);
                    cmd.Parameters.AddWithValue("[PhoneNumb]", entity.PhoneNumb);
                    cmd.Parameters.AddWithValue("[IdStaff]", entity.IdStaff);
                    cmd.ExecuteNonQuery();
                }

                finally
                {
                    conn.Close();
                }
            }
        }
        public static int InsertStaff(Staff entity)
        {
            int result = 0;
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "INSERT INTO [Staff] ([IdStaff], [IdFirm], [FIO],[Post],[DateOfBirth],[DateOfHiring],[PhoneNumb])" + "VALUES (?,?,?,?,?,?,?)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdStaff]", entity.IdStaff);
                    cmd.Parameters.AddWithValue("[IdFirm]", entity.IdFirm);
                    cmd.Parameters.AddWithValue("[FIO]", entity.FIO);
                    cmd.Parameters.AddWithValue("[Post]", entity.Post);
                    cmd.Parameters.AddWithValue("[DateOfBirth]", entity.DateOfBirth);
                    cmd.Parameters.AddWithValue("[DateOfHiring]", entity.DateOfHiring);
                    cmd.Parameters.AddWithValue("[PhoneNumb]", entity.PhoneNumb);
                    object o = cmd.ExecuteScalar();
                    if (o != null)
                    {
                        result = int.Parse(o.ToString());
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }
        #endregion




        #region WorkPerfomel
        public static WorkPerformel SelectWorkPerformel(int id)
        {
            WorkPerformel result = null;
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT [WorkPerformel].[IdWork].*FROM [WorkPerformel] WHERE [WorkPerforrmel].[IdWork]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[WorkPerformel] [IdWork]", id);
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                    if (dataTable.Rows.Count > 0)
                    {
                        result = WorkPerformel.Map(dataTable.Rows[0]);
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                return result;
            }
        }
        public static List<WorkPerformel> SelectWorkPerformel()
        {
            List<WorkPerformel> result = new List<WorkPerformel>();
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT WorkPerformel.*FROM WorkPerformel";
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                int i = 1;
                foreach (DataRow row in dataTable.Rows)
                {
                    result.Add(WorkPerformel.Map(row, i));
                    i++;
                }
            }
            return result;
        }
        public static void DeleteWorkPerformel(int id)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "DELETE FROM [WorkPerformel] WHERE [IdWork]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdWork]", id);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public static void UpdateWorkPerformel(WorkPerformel entity)
        {
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "UPDATE [WorkPerformel] SET [IdWork]=?, [TypeOfWork]=?, [Durability]=?, WHERE [IdWork]=?";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdWork]", entity.IdWork);
                    cmd.Parameters.AddWithValue("[TypeOfWork]", entity.TypeOfWork);
                    cmd.Parameters.AddWithValue("[Durability]", entity.Durability);
                    cmd.Parameters.AddWithValue("[IdWork]", entity.IdWork);
                    cmd.ExecuteNonQuery();
                }

                finally
                {
                    conn.Close();
                }
            }
        }
        public static int InsertWorkPerformel(WorkPerformel entity)
        {
            int result = 0;
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "INSERT INTO [WorkPerformel] ([IdWork], [TypeOfWork], [FIO])" + "VALUES (?,?,?)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdWork]", entity.IdWork);
                    cmd.Parameters.AddWithValue("[TypeOfWork]", entity.TypeOfWork);
                    cmd.Parameters.AddWithValue("[Durability]", entity.Durability);
                    object o = cmd.ExecuteScalar();
                    if (o != null)
                    {
                        result = int.Parse(o.ToString());
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }
        #endregion
    }


}