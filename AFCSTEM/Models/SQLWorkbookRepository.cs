using AFCSTEM.Data;
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
            , string act6q10, string act6q11 , string act6q12,string act9table1, string act9table2, string act9table3,string act9table4, string act9table5,string act10table1 ,string act10q1, string act10q2, string act10table2, string act10table3, string act10q3
            ,string act11q1,string act11table1,string act11q2,string act12table1, string act12q1,string act12table2,string act13q1,string act13table1, string act13table2)
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



            var workbookUpdate = context.Workbook.Attach(workbook);
            workbookUpdate.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return workbook;
        }
    }
}
