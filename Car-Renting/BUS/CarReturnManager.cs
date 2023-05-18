using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Car_Renting.DAO;

namespace Car_Renting
{
    public class CarReturnManager
    {
        private BillDAO _billDAO;
        private RentDAO _rentsDAO ;
        private CarDAO _carDAO ;
        private UserDAO _userDAO;
        private ClientDAO _clientDAO;
        private RatingDAO _ratingDAO;
        private DiscountManager _discountManager;

        public CarReturnManager()
        {
            this._discountManager = new DiscountManager();
            this._rentsDAO = new RentDAO();
            this._carDAO = new CarDAO();
            this._clientDAO = new ClientDAO();
            this._ratingDAO = new RatingDAO();
            this._billDAO = new BillDAO();
            this._userDAO = new UserDAO();
        }

        public DataTable SearchTwoState(string keyword , string state1 , string state2 )
        {
            return _rentsDAO.SearchTwoState( keyword , state1 , state2 );
        }

        public DataTable LoadData()
        {
            return _rentsDAO.GetAllDataTableByState(Contraint.STATE_WAITING);
        }

        public Rent GetRentById (int id)
        {
            return _rentsDAO.GetById(id);
        }

        public Car GetCarById(int id)
        {
            return _carDAO.GetById(id);
        }

        public Client GetClientById(int id)
        {
            return _clientDAO.GetById(id);
        }

        public void HandleSubmit(Bill bill , Rating rating )
        {
            //add Revenue User
            User userHadSubmit = _userDAO.GetById(bill.IdUser);
            userHadSubmit.TotalRevenue += Decimal.ToInt32(bill.TotalCost);
            _userDAO.Update(userHadSubmit);

            //Insert Data
            _ratingDAO.Insert(rating);
             _billDAO.Insert(bill);
            

            //Change State Rent
            _rentsDAO.ChangeState(bill.RentId, Contraint.STATE_AVAILABLE);

            //Decrease Quantity Discount
            if (!String.IsNullOrEmpty(bill.DiscountCode))
            {
                Discount discount = _discountManager.GetDiscountByCode(bill.DiscountCode);
                _discountManager.DecreaseQuantityDiscount(discount);
            }

        }

        public decimal HandleDiscount(int idUser , string code , decimal cost)
        {
            string status = _discountManager.CheckDiscount(code);
            switch (status)
            {
                case "Valid":
                    Discount discount = _discountManager.GetDiscountByCode(code);
                    cost -= cost * discount.DiscountPercent;
                    //Discount for vip customer about 10%
                    cost = _discountManager.HandleDiscountForVip(idUser, cost);
                    return cost;
                case "Invalid":
                    MessageBox.Show($"The code is {status}");
                    break;
                case "Expired":
                    MessageBox.Show($"The code is {status}");
                    break;
                case "NoQuantity":
                    MessageBox.Show($"The code is {status}");
                    break;
            }

            //Discount for vip customer about 10%
            cost = _discountManager.HandleDiscountForVip(idUser, cost);

            return cost;
        }

    }
}
