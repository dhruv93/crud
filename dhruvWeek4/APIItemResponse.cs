using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhruvWeek4
{
    class APIItemResponse
    {
        public int error_code
        {
            get;
            set;
        }
        public string msg
        {
            get;
            set;
        }
        public string version
        {
            get;
            set;
        }
        public List<Item> data
        {
            get;
            set;
        }
    }
}
