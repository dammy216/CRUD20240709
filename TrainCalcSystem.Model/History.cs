using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCalcSystem.Model
{
    public class History
    {
        public Train TrainKind { get; }
        public int Distance { get; }
        public int TotalPrice {  get; }

        public History(Train train, int distance)
        {
            TrainKind = train;
            Distance = distance;
            TotalPrice = train.BasicPrice + train.SeatKind.PRice + (train.distancePrice * distance);
        }
    }
}
