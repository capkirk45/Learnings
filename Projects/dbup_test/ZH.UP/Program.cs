using DbUp;
using DbUp.Engine;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ZH.UP
{
    //TODO:  Logging, 
    //TODO:  Preprocessor step to copy files over.
    //TODO:  Environment specific connection strings

    class Program
    {
        static void Main(string[] args)
        {
            var zengineresult = ExecuteDB_ZENGINE();
            var zhealthresult = ExecuteDB_ZHEALTH();
            var zidsresult = ExecuteDB_ZIDS();
            var zfilestoreresult = ExecuteDB_ZFILESTORE();
            Console.ReadLine();
        }

        private static int ExecuteDB_ZENGINE()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DB_ZENGINE"].ConnectionString;

            var upgrader =
                DeployChanges.To
                    .SqlDatabase(connectionString)
                    .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly(), (String s) => s.StartsWith("DB_ZENGINE"))
                    .LogToConsole()
                    .Build();

            var result = upgrader.PerformUpgrade();
            if (!result.Successful)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(string.Format("Result of DB_ZENGINE upgrade ... Fail {0} " + result.Error));
                Console.ResetColor();
#if DEBUG
                Console.ReadLine();
#endif
                return -1;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Format("Result of DB_ZENGINE upgrade ... Success!"));
            Console.ResetColor();
            return 0;
        }
        private static int ExecuteDB_ZHEALTH()
        {

            var connectionString = ConfigurationManager.ConnectionStrings["DB_ZHEALTH"].ConnectionString;
            var upgrader =
                DeployChanges.To
                    .SqlDatabase(connectionString)
                    .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                    .LogToConsole()
                    .Build();

            var result = upgrader.PerformUpgrade();
            if (!result.Successful)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(string.Format("Result of DB_ZHEALTH upgrade ... Fail {0} " + result.Error));
                Console.ResetColor();
#if DEBUG
                Console.ReadLine();
#endif
                return -1;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Format("Result of DB_ZHEALTH upgrade ... Success!"));
            Console.ResetColor();
            return 0;

        }
        private static int ExecuteDB_ZIDS()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DB_ZIDS"].ConnectionString;
            var upgrader =
                DeployChanges.To
                    .SqlDatabase(connectionString)
                    .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                    .LogToConsole()
                    .Build();

            var result = upgrader.PerformUpgrade();
            if (!result.Successful)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(string.Format("Result of DB_ZIDS upgrade ... Fail {0} " + result.Error));
                Console.ResetColor();
#if DEBUG
                Console.ReadLine();
#endif
                return -1;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Format("Result of DB_ZIDS upgrade ... Success!"));
            Console.ResetColor();
            return 0;

        }
        private static int ExecuteDB_ZFILESTORE()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DB_ZFILESTORE"].ConnectionString;
            var upgrader =
                DeployChanges.To
                    .SqlDatabase(connectionString)
                    .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                    .LogToConsole()
                    .Build();

            var result = upgrader.PerformUpgrade();
            if (!result.Successful)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(string.Format("Result of DB_ZFILESTORE upgrade ... Fail {0} " + result.Error));
                Console.ResetColor();
#if DEBUG
                Console.ReadLine();
#endif
                return -1;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Format("Result of DB_ZFILESTORE upgrade ... Success!"));
            Console.ResetColor();
            return 0;

        }

    }
}
