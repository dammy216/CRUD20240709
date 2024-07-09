using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCalcSystem.Model
{
    public class TrainC : Train
    {
        public override string Name => "電車C";

        public override int BasicPrice => 200;

        public override int distancePrice => 30;

        public override Seat SeatKind { get; }
        public TrainC(Seat seatKind)
        {
            SeatKind = seatKind;
        }
    }
}
