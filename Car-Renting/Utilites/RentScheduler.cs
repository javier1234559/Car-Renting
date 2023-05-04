using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Car_Renting
{
    public class RentScheduler
    {
        private static RentDAO _rentDAO;
        private static Timer _timer;
        private static bool _running;

        public static void Start()
        {
            if(_rentDAO == null) { 
                _rentDAO = new RentDAO();
            }

            if (!_running)
            {
                DateTime startTime = DateTime.Now;
                _timer = new Timer(state => Callback(state, startTime), null, 0, 5000);
                _running = true;
            }
        }


        private static async void Callback(object state, DateTime startTime)
        {
            DateTime currentTime = startTime.AddMilliseconds((int)state);

            DataTable rentsPeddingList = await Task.Run(() => _rentDAO.GetAllDataTableByState(Contraint.STATE_PEDDING));

            // Loop through each rent and check if it's time to update the state
            foreach (DataRow rent in rentsPeddingList.Rows)
            {
                DateTime endDate = (DateTime)rent["DateStart"];

                if (currentTime >= endDate)
                {
                    // Call the ChangeState method to update the rent state
                    int rentId = (int)rent["RentId"];
                    await Task.Run(() => _rentDAO.ChangeState(rentId, Contraint.STATE_RENTING));
                }
            }
            //DataTable rentsRentingList = _rentDAO.GetAllDataTableByState(Contraint.STATE_RENTING);

            //// Loop through each rent and check if it's time to update the state
            //foreach (DataRow rent in rentsRentingList.Rows)
            //{
            //    DateTime endDate = (DateTime)rent["DateEnd"];

            //    if (currentTime >= endDate)
            //    {
            //        // Call the ChangeState method to update the rent state
            //        int rentId = (int)rent["RentId"];
            //        _rentDAO.ChangeState(rentId, Contraint.STATE_WAITING);
            //    }
            //}

        }

        public static void Stop()
        {
            if (_running)
            {
                _timer.Dispose();
                _running = false;
            }
        }
    }
}
