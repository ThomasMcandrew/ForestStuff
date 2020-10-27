using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ForestStuff.Models
{
    public class RandomThing
    {
        [Key]
        public int RandomId { get; set; }
        public string stuff { get; set; }
        public string otherStuff { get; set; }

    }
}
