using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public const string PrizesFile = "PrizeModels.csv";
        public const string PeopleFile = "PersonModels.csv";
        public const string TeamFile = "TeamModels.csv";
        public const string TournamentFile = "TournamentModels.csv";
        public const string MatchupFile = "MatchupModels.csv";
        public const string MatchupEntryFile = "MatchupEntryModels.csv";
        public static IDataConnection Connection { get; private set; }

        //   public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        /// <summary>
        /// Maybe you will want to save to the both
        /// Oba tipa, i za baze i za tekstualne fajlove moze u ovu listu.
        /// Jer je u pitanju lista interfejsa.
        /// </summary>
        /// <param name="database"></param>
        /// <param name="textfiles"></param>
        //Before creating DatabaseType enum,
        //The parameters were bool database, bool textfiles
        public static void InitializeConnections(DatabaseType db)
        {
            //  Instead of if-else, this is also a pretty option
            /*
            switch (db)
            {
                case DatabaseType.Sql:
                    break;
                case DatabaseType.TextFile:
                    break;
                default:
                    break;
            }*/
            if (db==DatabaseType.Sql)
            {
                //TODO - Set up the SQL Connector properly
                SqlConnector sql = new SqlConnector();
                //  Connections.Add(sql);
                Connection=sql;
            } // now you only want to have one type of connection
            //before that it was only else, not else if
            //we are doing this because you want to escape the problem
            //of clashing ids in db and text file.
           else  if (db==DatabaseType.TextFile)
            {
                //TODO - Create the Text Connection
                TextConnector text = new TextConnector();
                // Connections.Add(text);
                Connection = text;
            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    
    }
}
