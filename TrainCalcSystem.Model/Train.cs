using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCalcSystem.Model
{
    public abstract class Train
    {
        public abstract string Name { get; }
        public abstract int BasicPrice { get; }
        public abstract int distancePrice {  get; }
        public abstract Seat SeatKind { get; }
    }
}
