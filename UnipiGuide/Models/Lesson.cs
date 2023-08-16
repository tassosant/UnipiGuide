using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnipiGuide.Models
{
    internal class Lesson
    {
        string lessonName;
        int lessonId;

        public int LessonId { get { return lessonId; } set { lessonId = value; } }
        public string LessonName { get {  return lessonName; } set { lessonName = value; } }
    }
}
