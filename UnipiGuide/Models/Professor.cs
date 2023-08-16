using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnipiGuide.Models
{
    internal class Professor
    {
        string professorName;
        int professorId;

        public string ProfessorName { get { return professorName; } set {  professorName = value; } }
        public int ProfessorId { get { return professorId; } set { professorId = value; } }  
    }
}
