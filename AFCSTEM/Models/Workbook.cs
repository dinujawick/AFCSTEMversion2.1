using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AFCSTEM.Models
{
    public class Workbook
    {

        [Key]
        public string StudentId { get; set; }
        public string Act1Table1 { get; set; }
        public string Act1Table2 { get; set; }
        public float Act2CSWidth { get; set; }

        public float Act2CSArea { get; set; }

        public float Act2CSLength { get; set; }
        public string Act1Row1 { get; set; }
        public string Act1Row2 { get; set; }
        public string Act1Row3 { get; set; }
        public string Act1Row4 { get; set; }
        public string Act1Table3 { get; set; }






    }
}
