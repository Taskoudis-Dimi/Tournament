using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using System.Data.SqlClient;
using Dapper;

namespace TrackerLibrary
{
    public class SqlConnector : DataConnection
    {
        // TODO - Make the CreatePrize method actually save to database
        //Αποθήκευση ενός new prize στη database
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (DbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments"))) 
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Output);


                //Θα εκτελεστεί το store procedure που όρισα στη db περνώντας όλες τις παραπάνω τιμές του p
                connection.Execute("dbo.spPeople_Insert", p, commandType: System.Data.CommandType.StoredProcedure);



                //Για να επιστρέψω τις τιμές απο τη βάση δεδομένων κάνω τα παρακάτω
                model.Id = p.Get<int>("@id");
                return model;
            }

        }






    }
}
