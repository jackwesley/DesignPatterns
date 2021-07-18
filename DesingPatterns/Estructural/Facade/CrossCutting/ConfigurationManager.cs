using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Estructural.Facade.CrossCutting
{
    public class ConfigurationManager : IConfigurationManager
    {
        public string GetValue(string key)
        {
            return key;
        }       
    }
}
