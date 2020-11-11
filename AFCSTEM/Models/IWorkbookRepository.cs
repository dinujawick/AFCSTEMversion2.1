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
            , string act6q10, string act6q11, string act6q12);


    }
}
