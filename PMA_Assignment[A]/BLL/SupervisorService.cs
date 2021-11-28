using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SupervisorService
    {
        public int Id { get; set; }
        public int SupervisorId { get; set; }
        public string SupervisorName { get; set; }
        public string Password { get; set; }
    }
}
