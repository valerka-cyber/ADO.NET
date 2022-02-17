using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.model
{
    public class AppContext
    {
        IConfiguration _configuration;
        private string _path;
        public AppContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _path = _configuration.GetConnectionString("manDb");
        }
        public string GetProjectPath()
        {
            return _path;
        }
    }
}
