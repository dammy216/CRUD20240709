using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCalcSystem.Model
{
    public class HistoryManager
    {
        private List<History> _hitoryList = new List<History>();
        public History[] HistoryList { get {  return _hitoryList.ToArray(); } }
        private static HistoryManager _instance;
        public History ResultHistory;
        public static HistoryManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HistoryManager();
                }
                return _instance;
            }
        }

        public void AddHistory()
        {
            _hitoryList.Add(ResultHistory);
        }

        public void RemoveHistory(History history)
        {
            var sameHistory = _hitoryList.FirstOrDefault(q => q == history);
            _hitoryList.Remove(sameHistory);
        }
        public string[] GetHitoryItems(History history)
        {
            var name = history.TrainKind.Name;
            var seat = history.TrainKind.SeatKind.ToString();    
            var price = history.TotalPrice.ToString();

            string[] items = { name, seat, price };
            return items;
        }

        private Seat GetSeat(string seat)
        {
            switch (seat)
            {
                case "自由席":
                    return new SeatA();
                case "指定席":
                    return new SeatB();
                case "グリーン席":
                    return new SeatC();
                    default:
                    return null;
            }
        }

        public void GetHistoryData(string name, string seat, int distance)
        {
            switch(name)
            {
                case "電車A":
                    ResultHistory = new History(new TrainA(GetSeat(seat)), distance);
                    break;
                case "電車B":
                    ResultHistory = new History(new TrainB(GetSeat(seat)), distance);
                    break;
                case "電車C":
                    ResultHistory = new History(new TrainC(GetSeat(seat)), distance);
                    break;
                    default:
                    break;
            }
        }
    }
}
