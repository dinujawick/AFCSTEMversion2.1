﻿using AFCSTEM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFCSTEM.Models
{
    public class SQLWorkbookRepository : IWorkbookRepository
    {

        private readonly ApplicationDbContext context;

        public SQLWorkbookRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Workbook CreateWorkbookActivity(string studentID,
            string ACT1TABLE1, string ACT1TABLE2 )
        {
            Workbook workbook = new Workbook();

            
            workbook.StudentId = studentID;
            workbook.Act1Table1 = ACT1TABLE1;
            workbook.Act1Table2 = ACT1TABLE2;
          

            context.Workbook.Add(workbook);
            context.SaveChanges();
            return workbook;
        }

        public Workbook GetWorkbook(string studentID)
        {
            if(context.Workbook.Find(studentID) == null)
            {
                return CreateWorkbookActivity(studentID,"", "");
            }
            else {
                return context.Workbook.Find(studentID);
            }
            
        }

        public Workbook UpdateWorkbookActivity(Workbook workbook,
            string ACT1TABLE1, string ACT1TABLE2, float ACT2CSWIDTH, float ACT2CSLENGTH, float ACT2CSAREA, string ACT1TABLE3, string ACT1ROW1 ,string ACT1ROW2, string ACT1ROW3, string ACT1ROW4,
            float ACT2LENGTHGS, float ACT2WIDTHGS, float ACT2AREAGS,float ACT2LENGTHGP,float ACT2WIDTHGP, float ACT2AREAGP,float ACT2LENGTHBP, float ACT2WIDTHBP, float ACT2AREABP, string ACT2TEXT1, string ACT2BOX,
            string ACT2BOX2, string ACT2BOX3, string ACT2T4, string ACT2T5, float ACT2LENGTHGS2, float ACT2WIDTHGS2, float ACT2AREAGS2, float mcgLength, float mcgWidth, float mcgArea, float msLength, float msWidth, float msArea,
            float gmhLength, float gmhWidth, float gmhArea, float scgLength,float scgWidth, float scgArea, float ssLength, float ssWidth, float ssArea, float osLength, float osWidth ,float osArea, float gLength, float gWidth, float gArea, float metLength ,
            float metWidth, float metArea, string largestArea, string smallestArea, string crowdCapacity, string act3q4, string act3q5, string act3q6, string act3q7, string act3q8, string act5table1, int act5tablecount, string act5q1, string act5q2 ,string act5q3, string act5q4, 
            string act5q5, string act6table1, int act6tablecount, string act6avgheight, string act6avgage, string act6q1, string act6q2, string act6q3, string act6q4 , string act6q5, string act6q6, string act6q7, string act6q8, string act6q9 
            , string act6q10, string act6q11 , string act6q12,string act6table3, string act6table4,string act9table1, string act9table2, string act9table3,string act9table4, string act9table5,string act10table1 ,string act10q1, string act10q2, string act10table2, string act10table3, string act10q3
            ,string act11q1,string act11table1,string act11q2,string act12table1, string act12q1,string act12table2,string act13q1,string act13table1, string act13table2,string act14graph1,string act14graph2, string act14graph3,
            string act14q1, string act14q2, string act14q3, string act14q4, string act14q5, string act14q6, string act14q7, string act14q8, string act14q9,string act14q10, string act14q11,string act15quad1, string act15table1, string act15quad2, string act15table2, string act15quad3
            ,string act15graphpoints, string act15graphlines,string act15table4,string act15table5, string act15textarea,string act16table1, string act16table2, string act16table3, string act16table4, string act16table5, string act16table6,
            string act17table1,string act17table2,string act17table3,string act17table4,string act17table5,string act17table6,string act17table7, string act17q1,string act17q2,string act17q3,string act17q4, string act17q5,string act17q6,string act17q7,
            string act8table1, string act8table2, string act8table3, string act8q1, string act8q2, string act8q3, string act8q4, string act8q5, string act8q6, string act8q7, string act8q8, string act8q9, string act8q10, string act8q11,
            string act8q12, string act8q13, string act8q14, string act8q15, string act8q16, string act8q17, string act8q18,string act4table1, string act4table2, string act4q1, string act4q2)
        {
            workbook.Act1Table1 = ACT1TABLE1;
            workbook.Act1Table2 = ACT1TABLE2;
            workbook.Act2CSArea = ACT2CSAREA;
            workbook.Act2CSLength = ACT2CSLENGTH;
            workbook.Act2CSWidth = ACT2CSWIDTH;
            workbook.Act1Row1 = ACT1ROW1;
            workbook.Act1Row2 = ACT1ROW2;
            workbook.Act1Row3 = ACT1ROW3;
            workbook.Act1Row4 = ACT1ROW4;
            workbook.Act1Table3 = ACT1TABLE3;
            workbook.Act2GSLength = ACT2LENGTHGS;
            workbook.Act2GSWidth = ACT2WIDTHGS;
            workbook.Act2GSArea = ACT2AREAGS;
            workbook.Act2GPLength = ACT2LENGTHGP;
            workbook.Act2GPWidth = ACT2WIDTHGP;
            workbook.Act2GPArea = ACT2AREAGP;
            workbook.Act2BPLength = ACT2LENGTHBP;
            workbook.Act2BPWidth = ACT2WIDTHBP;
            workbook.Act2BPArea = ACT2AREABP;
            workbook.Act2text1 = ACT2TEXT1;
            workbook.Act2box1 = ACT2BOX;
            workbook.Act2box2 = ACT2BOX2;
            workbook.Act2box3 = ACT2BOX3;
            workbook.Act2t4 = ACT2T4;
            workbook.Act2t5 = ACT2T5;
            workbook.Act2GS2Length = ACT2LENGTHGS2;
            workbook.Act2GS2Width = ACT2WIDTHGS2;
            workbook.Act2GS2Area = ACT2AREAGS2;
            workbook.mcgLength = mcgLength;
            workbook.mcgWidth = mcgWidth;
            workbook.mcgArea = mcgArea;
            workbook.msLength = msLength;
            workbook.msWidth = msWidth;
            workbook.msArea = msArea;
            workbook.gmhLength = gmhLength;
            workbook.gmhWidth = gmhWidth;
            workbook.gmhArea = gmhArea;
            workbook.scgLength = scgLength;
            workbook.scgWidth = scgWidth;
            workbook.scgArea = scgArea;
            workbook.ssLength = ssLength;
            workbook.ssWidth = ssWidth;
            workbook.ssArea = ssArea;
            workbook.osLength = osLength;
            workbook.osWidth = osWidth;
            workbook.osArea = osArea;
            workbook.gLength = gLength;
            workbook.gWidth = gWidth;
            workbook.gArea = gArea;
            workbook.metLength = metLength;
            workbook.metWidth = metWidth;
            workbook.metArea = metArea;
            workbook.largestArea = largestArea;
            workbook.smallestArea = smallestArea;
            workbook.crowdCapacity = crowdCapacity;
            workbook.act3q4 = act3q4;
            workbook.act3q5 = act3q5;
            workbook.act3q6 = act3q6;
            workbook.act3q7 = act3q7;
            workbook.act3q8 = act3q8;
            workbook.act5table = act5table1;
            workbook.act5tablecount = act5tablecount;
            workbook.act5q1 = act5q1;
            workbook.act5q2 = act5q2;
            workbook.act5q3 = act5q3;
            workbook.act5q4 = act5q4;
            workbook.act5q5 = act5q5;
            workbook.act6table1 = act6table1;
            workbook.act6tablecount = act6tablecount;
            workbook.act6avgHeight = act6avgheight;
            workbook.act6avgAge = act6avgage;
            workbook.act6q1 = act6q1;
            workbook.act6q2 = act6q2;
            workbook.act6q3 = act6q3;
            workbook.act6q4 = act6q4;
            workbook.act6q5 = act6q5;
            workbook.act6q6 = act6q6;
            workbook.act6q7 = act6q7;
            workbook.act6q8 = act6q8;
            workbook.act6q9 = act6q9;
            workbook.act6q10 = act6q10;
            workbook.act6q11 = act6q11;
            workbook.act6q12 = act6q12;
            workbook.act9table1 = act9table1;
            workbook.act9table2 = act9table2;
            workbook.act9table3 = act9table3;
            workbook.act9table4 = act9table4;
            workbook.act9table5 = act9table5;
            workbook.act10table1 = act10table1;
            workbook.act10q1 = act10q1;
            workbook.act10q2 = act10q2;
            workbook.act10table2 = act10table2;
            workbook.act10table3 = act10table3;
            workbook.act10q3 = act10q3;
            workbook.act11q1 = act11q1;
            workbook.act11table1 = act11table1;
            workbook.act11q2 = act11q2;
            workbook.act12table1 = act12table1;
            workbook.act12q1 = act12q1;
            workbook.act12table2 = act12table2;
            workbook.act13q1 = act13q1;
            workbook.act13table1 = act13table1;
            workbook.act13table2 = act13table2;
            workbook.act14graph1 = act14graph1;
            workbook.act14graph2 = act14graph2;
            workbook.act14graph3 = act14graph3;
            workbook.act14q1 = act14q1;
            workbook.act14q2 = act14q2;
            workbook.act14q3 = act14q3;
            workbook.act14q4 = act14q4;
            workbook.act14q5 = act14q5;
            workbook.act14q6 = act14q6;
            workbook.act14q7 = act14q7;
            workbook.act14q8 = act14q8;
            workbook.act14q9 = act14q9;
            workbook.act14q10 = act14q10;
            workbook.act14q11 = act14q11;
            workbook.act15quad1 = act15quad1;
            workbook.act15table1 = act15table1;
            workbook.act15quad2 = act15quad2;
            workbook.act15table2 = act15table2;
            workbook.act15quad3 = act15quad3;
            workbook.act15graphpoints = act15graphpoints;
            workbook.act15graphlines = act15graphlines;
            workbook.act15table4 = act15table4;
            workbook.act15table5 = act15table5;
            workbook.act15textarea = act15textarea;
            workbook.act16table1 = act16table1;
            workbook.act16table2 = act16table2;
            workbook.act16table3 = act16table3;
            workbook.act16table4 = act16table4;
            workbook.act16table5 = act16table5;
            workbook.act16table6 = act16table6;
            workbook.act17table1 = act17table1;
            workbook.act17table2 = act17table2;
            workbook.act17table3 = act17table3;
            workbook.act17table4 = act17table4;
            workbook.act17table5 = act17table5;
            workbook.act17table6 = act17table6;
            workbook.act17table7 = act17table7;
            workbook.act17q1 = act17q1;
            workbook.act17q2 = act17q2;
            workbook.act17q3 = act17q3;
            workbook.act17q4 = act17q4;
            workbook.act17q5 = act17q5;
            workbook.act17q6 = act17q6;
            workbook.act17q7 = act17q7;
            workbook.act6table3 = act6table3;
            workbook.act6table4 = act6table4;
            workbook.act8table1 = act8table1;
            workbook.act8table2 = act8table2;
            workbook.act8table3 = act8table3;
            workbook.act8q1 = act8q1;
            workbook.act8q2 = act8q2;
            workbook.act8q3 = act8q3;
            workbook.act8q4 = act8q4;
            workbook.act8q5 = act8q5;
            workbook.act8q6 = act8q6;
            workbook.act8q7 = act8q7;
            workbook.act8q8 = act8q8;
            workbook.act8q9 = act8q9;
            workbook.act8q10 = act8q10;
            workbook.act8q11 = act8q11;
            workbook.act8q12= act8q12;
            workbook.act8q13 = act8q13;
            workbook.act8q14 = act8q14;
            workbook.act8q15 = act8q15;
            workbook.act8q16 = act8q16;
            workbook.act8q17 = act8q17;
            workbook.act8q18= act8q18;
            workbook.act4table1 = act4table1;
            workbook.act4table2 = act4table2;
            workbook.act4q1 = act4q1;
            workbook.act4q2 = act4q2;



            var workbookUpdate = context.Workbook.Attach(workbook);
            workbookUpdate.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return workbook;
        }
    }
}
