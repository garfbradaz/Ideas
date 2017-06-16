using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ideas.Models
{
    public class Idea    : BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
