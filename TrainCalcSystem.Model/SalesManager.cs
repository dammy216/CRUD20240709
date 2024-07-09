using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCalcSystem.Model
{
    public class SalesManager
    {
        private List<History> _salesList = new List<History>();
        public History[] SaleList { get { return _salesList.ToArray(); } }
        private static SalesManager _instance;
        public static SalesManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SalesManager();
                }
                return _instance;
            }
        }

        public void AddSales(History history)
        {
            _salesList.Add(history);
        }

        public string[] GetSalesItem(History history)
        {
            var name = history.TrainKind.Name;
            var seat = history.TrainKind.SeatKind.ToString();
            var price = history.TotalPrice.ToString();

            string[] items = { name, seat, price };
            return items;
        }
    }
}
