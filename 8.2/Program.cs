namespace _8._2
{

    class Balance
    {
        private double _balanceAmount;

        public double BalanceAmount
        {

            // Lỗi phương thức get trả về value là sai. 
            //get
            //{
            //    return value;
            //}

            // Sửa lỗi :
            get
            {
                return _balanceAmount;
            }
            set
            {
                _balanceAmount = value;
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Balance objBal = new Balance();
                objBal.BalanceAmount = 1005.50;
                Console.WriteLine(objBal.BalanceAmount);
            }
        }
    }
}
