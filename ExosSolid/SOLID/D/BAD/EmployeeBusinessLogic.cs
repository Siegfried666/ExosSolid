namespace EXOSSOLID.SOLID.D.BAD
{
    public class EmployeeBusinessLogic
    {
        EmployeeDataAccessLogic _EmployeeDataAccessLogic;
        public EmployeeBusinessLogic()
        {
            _EmployeeDataAccessLogic = DataAccessFactory.GetEmployeeDataAccessObj();
        }
        public Employee GetEmployeeDetails(int id)
        {
            return _EmployeeDataAccessLogic.GetEmployeeDetails(id);
        }
    }
}