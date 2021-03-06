﻿using System;
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
        public string act4table1 { get; set; }
        public string act4table2 { get; set; }
        public string act4q1 { get; set; }
        public string act4q2 { get; set; }
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
        public string act6table3 { get; set; }
        public string act6table4 { get; set; }
        public string act8table1 { get; set; }
        public string act8table2 { get; set; }
        public string act8table3 { get; set; }
        public string act8q1 { get; set; }
        public string act8q2 { get; set; }
        public string act8q3 { get; set; }
        public string act8q4 { get; set; }
        public string act8q5 { get; set; }
        public string act8q6 { get; set; }
        public string act8q7 { get; set; }
        public string act8q8 { get; set; }
        public string act8q9 { get; set; }
        public string act8q10 { get; set; }
        public string act8q11 { get; set; }
        public string act8q12{ get; set; }
        public string act8q13 { get; set; }
        public string act8q14 { get; set; }
        public string act8q15 { get; set; }
        public string act8q16 { get; set; }
        public string act8q17{ get; set; }
        public string act8q18 { get; set; }
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
        public string act11q1 { get; set; }
        public string act11table1 { get; set; }
        public string act11q2 { get; set; }
        public string act12table1 { get; set; }
        public string act12table2 { get; set; }
        public string act12q1 { get; set; }
        public string act13q1 { get; set; }
        public string act13table1 { get; set; }
        public string act13table2 { get; set; }
        public string act14graph1 { get; set; }
        public string act14graph2 { get; set; }
        public string act14graph3 { get; set; }
        public string act14q1 { get; set; }
        public string act14q2 { get; set; }
        public string act14q3 { get; set; }
        public string act14q4 { get; set; }
        public string act14q5 { get; set; }
        public string act14q6 { get; set; }
        public string act14q7 { get; set; }
        public string act14q8 { get; set; }
        public string act14q9 { get; set; }
        public string act14q10 { get; set; }
        public string act14q11 { get; set; }
        public string act15quad1 { get; set; }
        public string act15table1 { get; set; }
        public string act15quad2 { get; set; }
        public string act15table2 { get; set; }
        public string act15quad3 { get; set; }
        public string act15graphpoints { get; set; }
        public string act15graphlines { get; set; }
        public string act15table4 { get; set; }
        public string act15table5 { get; set; }
        public string act15textarea { get; set; }
        public string act16table1 { get; set; }
        public string act16table2 { get; set; }
        public string act16table3 { get; set; }
        public string act16table4 { get; set; }
        public string act16table5 { get; set; }
        public string act16table6 { get; set; }
        public string act17table1 { get; set; }
        public string act17table2 { get; set; }
        public string act17table3 { get; set; }
        public string act17table4 { get; set; }
        public string act17table5 { get; set; }
        public string act17table6 { get; set; }
        public string act17table7 { get; set; }
        public string act17q1{ get; set; }
        public string act17q2 { get; set; }
        public string act17q3 { get; set; }
        public string act17q4 { get; set; }
        public string act17q5 { get; set; }
        public string act17q6 { get; set; }
        public string act17q7 { get; set; }


    }
}
