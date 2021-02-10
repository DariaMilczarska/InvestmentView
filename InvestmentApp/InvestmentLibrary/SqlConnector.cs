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
                /* WebClient web = new WebClient();
                 string data = web.DownloadString("https://www.bankier.pl/inwestowanie/profile/quote.html?symbol=SREBRO");
                 String[] splited = data.Split(new String[] { "class=\"profilLast\">" }, StringSplitOptions.None);
                 String[] endSplit = splited[1].Split(' ');
                 Decimal value = Decimal.Parse(endSplit[0]);*/
                var p = new DynamicParameters();
                p.Add("idInvType", investment.idInvestmentType);
                p.Add("val", investment.value);
                p.Add("invName", investment.invName);
                p.Add("dataS", investment.dataSource);
                p.Add("id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("addInvestment", commandType: CommandType.StoredProcedure);
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

                connection.Execute("addInvestmentType", CommandType.StoredProcedure);
                investemntType.idInvestmentType = p.Get<int>("id");

                return investemntType;
            }              
        }
    }
}
