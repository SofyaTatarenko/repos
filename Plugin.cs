using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneApp.Domain;
using PhoneApp.Domain.Attributes;
using PhoneApp.Domain.DTO;
using PhoneApp.Domain.Interfaces;
using Newtonsoft.Json;

namespace EmployeesAdderPlugin
{
    [Author(Name = "Sofya Tatarenko")]
    public class Plugin : IPluggable
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public IEnumerable<DataTransferObject> Run(IEnumerable<DataTransferObject> args)
        {
            logger.Info("Adding employees");

            var employeesList = JsonConvert.SerializeObject(args);
            Console.WriteLine("puk");

            logger.Info($"Added new employee");
            return employeesList.Cast<DataTransferObject>();
        }
    }
}
