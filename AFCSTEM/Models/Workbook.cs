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
        public string Act1Row1 { get; set; }
        public string Act1Row2 { get; set; }
        public string Act1Row3 { get; set; }
        public string Act1Row4 { get; set; }
        public string Act1Table3 { get; set; }
        public float Act2CSWidth { get; set; }
        public float Act2CSArea { get; set; }
        public float Act2CSLength { get; set; }
        public float Act2GSLength { get; set; }
        public float Act2GSWidth { get; set; }
        public float Act2GSArea { get; set; }
        public float Act2GPLength { get; set; }
        public float Act2GPWidth { get; set; }
        public float Act2GPArea { get; set; }
        public float Act2BPLength { get; set; }
        public float Act2BPWidth { get; set; }
        public float Act2BPArea { get; set; }
        public string Act2box1 { get; set; }
        public string Act2box2 { get; set; }
        public string Act2box3 { get; set; }
        public string Act2text1 { get; set; }
        public string Act2t4 { get; set; }
        public string Act2t5 { get; set; }
        public float Act2GS2Length { get; set; }
        public float Act2GS2Width { get; set; }
        public float Act2GS2Area { get; set; }
        public float mcgLength { get; set; }
        public float mcgWidth { get; set; }
        public float mcgArea { get; set; }
        public float msLength { get; set; }
        public float msWidth { get; set; }
        public float msArea { get; set; }
        public float gmhLength { get; set; }
        public float gmhWidth { get; set; }
        public float gmhArea { get; set; }
        public float scgLength { get; set; }
        public float scgWidth { get; set; }
        public float scgArea { get; set; }
        public float ssLength { get; set; }
        public float ssWidth { get; set; }
        public float ssArea { get; set; }
        public float osLength { get; set; }
        public float osWidth { get; set; }
        public float osArea { get; set; }
        public float gLength { get; set; }
        public float gWidth { get; set; }
        public float gArea { get; set; }
        public float metLength { get; set; }
        public float metWidth { get; set; }
        public float metArea { get; set; }
        public string largestArea { get; set; }
        public string smallestArea { get; set; }
        public string crowdCapacity { get; set; }
        public string act3q4 { get; set; }
        public string act3q5 { get; set; }
        public string act3q6 { get; set; }
        public string act3q7 { get; set; }
        public string act3q8 { get; set; }
        public string act5table { get; set; }
        public int act5tablecount { get; set; }
        public string act5q1 { get; set; }
        public string act5q2 { get; set; }
        public string act5q3 { get; set; }
        public string act5q4 { get; set; }
        public string act5q5 { get; set; }
        public string act6table1 { get; set; }
        public int act6tablecount { get; set; }
        public string act6avgHeight { get; set; }
        public string act6avgAge { get; set; }
        public string act6q1 { get; set; }
        public string act6q2 { get; set; }
        public string act6q3 { get; set; }
        public string act6q4 { get; set; }
        public string act6q5 { get; set; }
        public string act6q6 { get; set; }
        public string act6q7 { get; set; }
        public string act6q8 { get; set; }
        public string act6q9 { get; set; }
        public string act6q10 { get; set; }
        public string act6q11 { get; set; }
        public string act6q12 { get; set; }
        public string act9table1 { get; set; }
        public string act9table2 { get; set; }
        public string act9table3 { get; set; }
        public string act9table4 { get; set; }
        public string act9table5 { get; set; }
        public string act10table1 { get; set; }
        public string act10q1 { get; set; }
        public string act10q2 { get; set; }
        public string act10table2 { get; set; }
        public string act10table3 { get; set; }
        public string act10q3 { get; set; }


    }
}
