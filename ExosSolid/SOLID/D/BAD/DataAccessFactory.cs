namespace EXOSSOLID.SOLID.D.BAD
{
    public class DataAccessFactory
    {
        public static EmployeeDataAccessLogic GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccessLogic();
        }
    }
}