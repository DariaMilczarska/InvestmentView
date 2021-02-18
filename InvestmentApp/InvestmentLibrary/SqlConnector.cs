using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;


namespace InvestmentLibrary
{
    class SqlConnector
    {
        public static String ConnectionName { get; set; } = "Investment";

        public static string GetConnectionString(String name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static Investment CreateInvestment(Investment Investment)
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(ConnectionName)))
            {
                var p = new DynamicParameters();
                p.Add("idInvType", Investment.IdInvestmentType);
                p.Add("currency", Investment.IdCurrency);
                p.Add("val", Investment.Value);
                p.Add("invName", Investment.InvName);
                p.Add("dataS", Investment.DataSource);
                p.Add("id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("addInvestment", p, commandType: CommandType.StoredProcedure);
                Investment.IdInvestment = p.Get<int>("id");

                return Investment;
            }
        }
        public static InvestmentType CreateInvestmentType(InvestmentType investemntType)
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(ConnectionName)))
            {
                var p = new DynamicParameters();
                p.Add("invName", investemntType.InvName);
                p.Add("id", 0, DbType.Int32, ParameterDirection.Output);

                connection.Execute("addInvestmentType", p, commandType: CommandType.StoredProcedure);
                investemntType.IdInvestmentType = p.Get<int>("id");

                return investemntType;
            }
        }

        public static User AddUser(User User)
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(ConnectionName)))
            {
                var p = new DynamicParameters();
                p.Add("login", User.login);
                p.Add("pass", User.password);
                p.Add("id", 0, DbType.Int32, ParameterDirection.Output);

                connection.Execute("addUser", p, commandType: CommandType.StoredProcedure);
                User.idUser = p.Get<int>("id");

                return User;
            }
        }

        public static UserInvestment AddUserInvestment(UserInvestment UserInvestment)
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(ConnectionName)))
            {
                var p = new DynamicParameters();
                p.Add("idUser", UserInvestment.idUser);
                p.Add("idInvestment", UserInvestment.IdInvestment);
                p.Add("datePurchased", UserInvestment.DatePurchased);
                p.Add("valPurchased", UserInvestment.ValuePurchased);
                p.Add("Amount", UserInvestment.Amount);
                p.Add("valPLN", UserInvestment.ValuePLN);
                p.Add("id", 0, DbType.Int32, ParameterDirection.Output);

                connection.Execute("addUserInvestment", p, commandType: CommandType.StoredProcedure);
                UserInvestment.IdUserInvestment = p.Get<int>("id");

                return UserInvestment;
            }
        }

        public static Currency AddCurrency(Currency currency)
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(ConnectionName)))
            {
                var p = new DynamicParameters();
                p.Add("short", currency.Shorthand);
                p.Add("val", currency.Value);
                p.Add("dataSource", currency.DataSource);
                p.Add("id", 0, DbType.Int32, ParameterDirection.Output);

                connection.Execute("addCurrency", p, commandType: CommandType.StoredProcedure);
                currency.IdCurrency = p.Get<int>("id");

                return currency;
            }
        }
        public static void UpdateInvestmentData(Investment inv)
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(ConnectionName)))
            {
                var p = new DynamicParameters();
                p.Add("id", inv.IdInvestment);
                p.Add("val", inv.Value);

                connection.Execute("editInvestmentValue", p, commandType: CommandType.StoredProcedure);
            }
        }

        public static void UpdateDifference(UserInvestment ui)
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(ConnectionName)))
            {
                var p = new DynamicParameters();
                p.Add("id", ui.idUser);
                p.Add("investmentID", ui.IdInvestment);
                p.Add("amount", ui.Amount);

                connection.Execute("updateDifference", p, commandType: CommandType.StoredProcedure);
            }
        }

        public static List<InvestmentType> GetInvestmentType_All()
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(ConnectionName)))
            {
                return connection.Query<InvestmentType>("GetInvestmentTypes_All").ToList();
            }
        }

        public static List<Investment> GetInvestment_All()
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(ConnectionName)))
            {
                return connection.Query<Investment>("GetInvestment_All").ToList();
            }
        }

        public static List<Currency> GetCurrency_All()
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(ConnectionName)))
            {
                return connection.Query<Currency>("GetCurrency_All").ToList();
            }
        }

        public static User GetUser()
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(ConnectionName)))
            {
                return connection.Query<User>("SELECT * FROM User").ToList()[0];
            }
        }

        public static List<InvestmentView> GetInvestmentView_All()
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(ConnectionName)))
            {
                return connection.Query<InvestmentView>("SELECT * FROM fullinvestment_view").ToList();
            }
        }

        public static List<HistoryView> GetHistoryView_All()
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(ConnectionName)))
            {
                return connection.Query<HistoryView>("SELECT * FROM history_view").ToList();
            }
        }

        public static void FinishInvestment(int IdUserInvestment)
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(ConnectionName)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("IdUI", IdUserInvestment);

                connection.Execute("deleteUserInvestment", p, commandType: CommandType.StoredProcedure);
            }
        }

        public static Investment GetInvestment(String name)
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(ConnectionName)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("iName", name);
                return connection.Query<Investment>("GetInvestment", p, commandType: CommandType.StoredProcedure).ToList()[0];
            }
        }
        public static List<UserInvestment> GetUserInvestemnt_All()
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(ConnectionName)))
            {
                return connection.Query<UserInvestment>("GetUserInvestment_All", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static UserInvestment GetUserInvestment(int idU, int idI)
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(ConnectionName)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("idU", idU);
                p.Add("idI", idI);
                return connection.Query<UserInvestment>("GetUserInvestment", p, commandType: CommandType.StoredProcedure).ToList()[0];
            }
        }

        public static List<CurrencyView> GetCurrencyView()
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(ConnectionName)))
            {
                return connection.Query<CurrencyView>("Select * from curencyview_view").ToList();
            }
        }
        public static void UpdateCurrencyData(Currency currency)
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(ConnectionName)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("id", currency.IdCurrency);
                p.Add("val", currency.Value);

                connection.Execute("updateCurrency", p, commandType: CommandType.StoredProcedure);
            }
        }

        public static List<double> GetInvestmentType(String name)
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(ConnectionName)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("typeName", name);

                return connection.Query<double>("getInvestmentType", p, commandType: CommandType.StoredProcedure).ToList();
            }
        }


    }
}
