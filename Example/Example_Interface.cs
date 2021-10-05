using System;
namespace DotNetNews
{
    public class Example_Interface
    {
        #region Test 1
        public abstract class BaseLogger
        {
            public void Info(string x)
            {
                Console.WriteLine(x + " Beep Beep!");
            }

            public abstract void Error();
        }

        public interface ILogger
        {
            void Info(string x)
            {
                Console.WriteLine(x + " Beep Beep!");
            }
            void Error();
        }
        #endregion

        #region Test 2 (Reabstraction)

        public interface IInfoLogger : ILogger
        {
            abstract void ILogger.Info(string x);
        }

        public class InfoLogger : IInfoLogger
        {
            public void Error()
            {
            }

            public void Info(string x)
            {
                (this as ILogger).Info(x);
            }
        }
        #endregion

        #region Test 3
        public interface IComplexLogger : ILogger
        {
            void Info(int x)
            {
                Console.WriteLine(x);
            }
        }

        public class ComplexLogger : IComplexLogger
        {
            public void Error()
            {
            }
        }

        public void Test3()
        {
            var logger = new ComplexLogger();
            // logger.Info();

            IComplexLogger complexLogger = new ComplexLogger();
            complexLogger.Info(5);
            complexLogger.Info("test");
        }
        #endregion
    }
}