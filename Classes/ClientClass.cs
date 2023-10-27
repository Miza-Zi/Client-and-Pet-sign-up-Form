using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Assignment_1_Code.Classes
{

    [Serializable]
    public class ClientClass
    {
        // Data attributes (known as data members)
        private string _Name;
        private string _Surname;
        private string _IDNumber;
        private decimal _CreditLimit;
        private decimal _CurrentBalanceOwed;

        // Properties
        public string Name
        {
            get => _Name;
            set => _Name = value;
        }

        public string Surname
        {
            get => _Surname;
            set => _Surname = value;
        }

        public string IDNumber
        {
            get => _IDNumber;
            set => _IDNumber = value;
        }

        public decimal CreditLimit
        {
            get => _CreditLimit;
            set => _CreditLimit = value;
        }

        public decimal CurrentBalanceOwed
        {
            get => _CurrentBalanceOwed;
            set => _CurrentBalanceOwed = value;
        }

        // Default constructor
        public ClientClass()
        {
            _Name = "";
            _Surname = "";
            _IDNumber = "";
            _CreditLimit = 0.00M;
            _CurrentBalanceOwed = 0.00M;
        }

        // Overloaded constructor
        public ClientClass(string Name, string Surname, string IDNumber, decimal CreditLimit, decimal CurrentBalanceOwed)
        {
            _Name = Name;
            _Surname = Surname;
            _IDNumber = IDNumber;
            _CreditLimit = CreditLimit;
            _CurrentBalanceOwed = CurrentBalanceOwed;
        }
    }
}
