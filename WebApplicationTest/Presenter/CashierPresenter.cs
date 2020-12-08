using System;
using WebApplicationTest.Model;

namespace WebApplicationTest.Presenter
{
    public class CashierPresenter
    {
        private string name = "Cashier";
        public CashRegisterModel model;
        public DBPresenter db;
        public string GetSetName { get { return name; } set { name = value; } }
        public CashierPresenter()
        {
            model = new CashRegisterModel();
            db = new DBPresenter();
        }
        public double GetBalance()
        {
            model.StoredAmount = db.GetData();
            return model.StoredAmount;
        }

        public double Withdraw(double value)
        {
            db.AddData(-value);
            return model.StoredAmount = model.StoredAmount - value;
        }

        public double Deposit(double value)
        {
            db.AddData(value);
            return model.StoredAmount = model.StoredAmount + value;
        }
    }
}