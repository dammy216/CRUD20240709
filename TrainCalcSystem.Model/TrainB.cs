using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCalcSystem.Model
{
    public class TrainB : Train
    {
        public override string Name => "電車B";

        public override int BasicPrice => 150;

        public override int distancePrice => 20;

        public override Seat SeatKind { get; }

        public TrainB(Seat seat)
        {
            SeatKind = seat;
        }
    }
}
