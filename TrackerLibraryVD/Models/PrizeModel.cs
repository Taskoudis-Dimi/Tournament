namespace TrackerLibraryVD.Models
{
    public class PrizeModel
    {   /// <summary>
        /// Unique ID for the Prize
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Which place in TRNMT team got
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Name of thr  place: Champion, 1st RunnerUp...
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Prize money
        /// </summary>
        public decimal PrizeAmount { get; set; }
        ///Price %
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;


        }

    }
}
