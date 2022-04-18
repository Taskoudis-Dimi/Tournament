using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<DataConnection> Connections { get; private set; }

        public static void InitializeConnections(bool database, bool textfiles)
        {


            if (database)
            {
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);

            }
            if (textfiles)
            {
                TextConnector text = new TextConnector();
                Connections.Add(text);

            }



        }


        // Κάθε φορά που καλώ τη CnnString θα πραγματοποιώ σύνδεση με τη βάση σύμφωνα με το connection string
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }




    }
}
