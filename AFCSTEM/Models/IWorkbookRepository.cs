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
            string ACT1TABLE1, string ACT1TABLE2, float ACT2CSWIDTH, float ACT2CSLENGTH, float ACT2CSAREA, string ACT1TABLE3, string ACT1ROW1, string ACT1ROW2, string ACT1ROW3, string ACT1ROW);


    }
}
