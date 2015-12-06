using Mvvm;

namespace XamlBrewer.Uwp.RadialGaugeSample.ViewModels
{
    class BankAccountViewModel: ViewModelBase
    {
        private double expense;
        private double balance = 500;

        public double Expense
        {
            get { return expense; }
            set
            {
                SetProperty(ref expense, value);
                Balance = 500 - value;
            }
        }

        public double Balance
        {
            get { return balance; }
            set { SetProperty(ref balance, value); }
        }
    }
}
