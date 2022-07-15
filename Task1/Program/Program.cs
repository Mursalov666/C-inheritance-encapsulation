using System;
using System.Diagnostics;
using System.Text;

namespace Program
{

    public class Program
    {
        static void Main()
        {
            DocumentProgram basic = new DocumentProgram();
            ExpertDocumentProgram expert = new ExpertDocumentProgram();
            ProDocumentProgram pro = new ProDocumentProgram();

            basic.OpenDocument();
            basic.EditDocument();
            basic.SaveDocument();
        }


    }

}