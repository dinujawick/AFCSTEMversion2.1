using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFCSTEM.Models
{
    public interface IWorkbookRepository
    {
        Workbook GetWorkbook(string studentID);

        Workbook CreateWorkbookActivity(string studentID, string ACT1TABLE1, string ACT1TABLE2);

        Workbook UpdateWorkbookActivity(Workbook workbook,
            string ACT1TABLE1, string ACT1TABLE2, float ACT2CSWIDTH, float ACT2CSLENGTH, float ACT2CSAREA, string ACT1TABLE3, string ACT1ROW1, string ACT1ROW2, string ACT1ROW3, string ACT1ROW4,
            float ACT2LENGTHGS, float ACT2WIDTHGS, float ACT2AREAGS, float ACT2LENGTHGP, float ACT2WIDTHGP, float ACT2AREAGP, float ACT2LENGTHBP, float ACT2WIDTHBP, float ACT2AREABP, string ACT2TEXT1, string ACT2BOX,
            string ACT2BOX2, string ACT2BOX3, string ACT2T4, string ACT2T5, float ACT2LENGTHGS2, float ACT2WIDTHGS2, float ACT2AREAGS2, float mcgLength, float mcgWidth, float mcgArea, float msLength, float msWidth, float msArea,
            float gmhLength, float gmhWidth, float gmhArea, float scgLength, float scgWidth, float scgArea, float ssLength, float ssWidth, float ssArea, float osLength, float osWidth, float osArea, float gLength, float gWidth, float gArea, float metLength,
            float metWidth, float metArea, string largestArea, string smallestArea, string crowdCapacity, string act3q4, string act3q5, string act3q6, string act3q7, string act3q8, string act5table1, int act5tablecount, string act5q1, string act5q2, string act5q3, string act5q4,
            string act5q5, string act6table1, int act6tablecount, string act6avgheight, string act6avgage, string act6q1, string act6q2, string act6q3, string act6q4, string act6q5, string act6q6, string act6q7, string act6q8, string act6q9
            , string act6q10, string act6q11, string act6q12, string act9table1, string act9table2, string act9table3, string act9table4, string act9table5, string act10table1, string act10q1, string act10q2, string act10table2, string act10table3, string act10q3,
            string act11q1, string act11table1, string act11q2, string act12table1, string act12q1, string act12table2, string act13q1, string act13table1, string act13table2,string act14graph1, string act14graph2, string act14graph3,
             string act14q1, string act14q2, string act14q3, string act14q4, string act14q5, string act14q6, string act14q7, string act14q8, string act14q9, string act14q10, string act14q11, string act15quad1, string act15table1, string act15quad2, string act15table2, string act15quad3
            , string act15graphpoints, string act15graphlines, string act15table4, string act15table5, string act15textarea, string act16table1, string act16table2, string act16table3, string act16table4, string act16table5, string act16table6,
             string act17table1, string act17table2, string act17table3, string act17table4, string act17table5, string act17table6, string act17table7, string act17q1, string act17q2, string act17q3, string act17q4, string act17q5, string act17q6, string act17q7);


    }
}
