using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayone.BLL
{
    public class ImportResult
    {
            public int SuccessCount { get; set; }
            public int ErrorCount { get; set; }
            public List<string> ErrorLines { get; set; } = new List<string>();
        
    }
}
