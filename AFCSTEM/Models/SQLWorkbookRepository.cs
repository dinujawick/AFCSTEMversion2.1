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
            string ACT1TABLE1, string ACT1TABLE2, float ACT2CSWIDTH, float ACT2CSLENGTH, float ACT2CSAREA, string ACT1TABLE3, string ACT1ROW1 ,string ACT1ROW2, string ACT1ROW3, string ACT1ROW4)
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


            var workbookUpdate = context.Workbook.Attach(workbook);
            workbookUpdate.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return workbook;
        }
    }
}
