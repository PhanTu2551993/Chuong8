using Chuong8;

namespace Chuong8
{
    class EmployeeDetails
    {
        private string _empName;
        private int _empId;
        public string EmpName
        {

            //Lỗi get, set không có ()
            //    get() 
            //     { 
            //     return _empName; 
            //     }
            //        set()
            //        {
            //            _empName = value;
            //        }

            //sửa 

            get
             { 
             return _empName; 
             }
            set
            {
                _empName = value;
            }

        }
     public void SetId(int val)
        {
            _empId = val;
        }
        static void Main(string[] args)
        {
            EmployeeDetails objDetails = new EmployeeDetails();
            objDetails.EmpName = "Bill";
            objDetails.SetId(10);
            Console.WriteLine("Employee Name:" + objDetails.EmpName);
            Console.WriteLine("Employee Id:" + objDetails._empId);
        } 
    }
}
