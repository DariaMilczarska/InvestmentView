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
        public static String connectionName { get; set; } = "Investment";

        public static string GetConnectionString(String name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static Investment CreateInvestment(Investment investment)
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(connectionName)))
            {
                var p = new DynamicParameters();
                p.Add("idInvType", investment.investmentType.idInvestmentType);
                p.Add("currency", investment.currency.idCurrency);
                p.Add("val", investment.value);
                p.Add("invName", investment.invName);
                p.Add("dataS", investment.dataSource);        
                p.Add("id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("addInvestment", p, commandType: CommandType.StoredProcedure);
                investment.idInvestment = p.Get<int>("id");

                return investment;
            }
        }
        public static InvestmentType CreateInvestmentType(InvestmentType investemntType)
        {
            using(IDbConnection connection = new MySqlConnection(GetConnectionString(connectionName)))
            {
                var p = new DynamicParameters();
                p.Add("invName", investemntType.invName);
                p.Add("id", 0, DbType.Int32, ParameterDirection.Output);

                connection.Execute("addInvestmentType", p, commandType: CommandType.StoredProcedure);
                investemntType.idInvestmentType = p.Get<int>("id");

                return investemntType;
            }              
        }

        public static User AddUser(User user)
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(connectionName)))
            {
                var p = new DynamicParameters();
                p.Add("login", user.login);
                p.Add("pass", user.password);
                p.Add("id", 0, DbType.Int32, ParameterDirection.Output);

                connection.Execute("addUser", p, commandType: CommandType.StoredProcedure);
                user.idUser = p.Get<int>("id");

                return user;
            }
        }

        public static UserInvestment AddUserInvestment(UserInvestment userInvestment)
        {
            using(IDbConnection connection = new MySqlConnection(GetConnectionString(connectionName)))
            {
                var p = new DynamicParameters();
                p.Add("idUser", userInvestment.user.idUser);
                p.Add("idInvestment", userInvestment.investment.idInvestment);
                p.Add("datePurchased", userInvestment.datePurchased);
                p.Add("valPurchased", userInvestment.valuePurchased);
                p.Add("amount", userInvestment.amount);
                p.Add("valPLN", userInvestment.valuePLN);
                p.Add("id", 0, DbType.Int32, ParameterDirection.Output);

                connection.Execute("addUserInvestment", p, commandType: CommandType.StoredProcedure);
                userInvestment.idUserInvestment = p.Get<int>("id");

                return userInvestment;
            }
        }

        public static Currency AddCurrency(Currency currency)
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(connectionName)))
            {
                var p = new DynamicParameters();
                p.Add("short", currency.Shorthand);
                p.Add("val", currency.value);
                p.Add("dataSource", currency.dataSource);
                p.Add("id", 0, DbType.Int32, ParameterDirection.Output);

                connection.Execute("addCurrency", p, commandType: CommandType.StoredProcedure);
                currency.idCurrency = p.Get<int>("id");

                return currency;
            }
        }
        public static void EditInvestmentValue(Investment inv)
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(connectionName)))
            {
                var p = new DynamicParameters();
                p.Add("id", inv.idInvestment);
                p.Add("val", inv.value);

                connection.Execute("editInvestmentValue", p, commandType: CommandType.StoredProcedure);
            }
        }

        public static void UpdateDifference(UserInvestment ui)
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(connectionName)))
            {
                var p = new DynamicParameters();
                p.Add("id", ui.user.idUser);
                p.Add("investmentID", ui.investment.idInvestment);

                connection.Execute("updateDifference", p, commandType: CommandType.StoredProcedure);
            }
        }

        public static List<InvestmentType> GetInvestmentType_All()
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(connectionName)))
            {
                return connection.Query<InvestmentType>("GetInvestmentTypes_All").ToList();
            }
        }

        public static List<Investment> GetInvestment_All()
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(connectionName)))
            {
                return connection.Query<Investment>("GetInvestment_All").ToList();
            }
        }

        public static List<Currency> GetCurrency_All()
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(connectionName)))
            {
                return connection.Query<Currency>("GetCurrency_All").ToList();
            }
        }

        public static User GetUser()
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(connectionName)))
            {
                return connection.Query<User>("SELECT * FROM User").ToList()[0];
            }
        }

        public static List<InvestmentView> GetInvestmentView_All()
        {
            using (IDbConnection connection = new MySqlConnection(GetConnectionString(connectionName)))
            {
                return connection.Query<InvestmentView>("SELECT * FROM fullinvestment_view").ToList();
            }
        }
    }
}
