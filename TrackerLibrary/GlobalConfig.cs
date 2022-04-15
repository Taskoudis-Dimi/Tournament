using System;
using System.Collections.Generic;
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
                TextConnection text = new TextConnection();
                Connections.Add(text);

            }

        }




    }
}
