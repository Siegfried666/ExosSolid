using EXOSSOLID.SOLID.S.GOOD.Interface;

namespace EXOSSOLID.SOLID.S.GOOD
{
    public class Logger : ILogger
    {
        public void Debug(string info)
        {
            Console.WriteLine(info);
        }

        public void Error(string info)
        {
            Console.WriteLine(info);
        }

        public void Info(string info)
        {
            Console.WriteLine(info);
        }
    }
}