using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCalcSystem.Model
{
    public class TrainA : Train
    {
        public override string Name => "電車A";

        public override int BasicPrice => 100;

        public override int distancePrice => 10;

        public override Seat SeatKind { get; }

        public TrainA(Seat seatKind)
        {
            SeatKind = seatKind;
        }
    }
}
