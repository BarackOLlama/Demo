using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSBeheer.Model
{
    public class Inspection
    {
        [Key]
        public int Id { get; set; }
        
        public DateTime StartingTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
