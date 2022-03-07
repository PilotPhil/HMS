using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilot.HMS.Models
{
    class UserModel
    {
        public int user_id { get; set; }
        public string user_name { get; set; }
        public int is_validation { get; set; }
        public int is_can_login { get; set; }
    }
}
