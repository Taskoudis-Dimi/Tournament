using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public class SqlConnector : DataConnection
    {
        // TODO - Make the CreatePrize method actually save to database
        //Αποθήκευση ενός new prize στη database
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;

        }






    }
}
