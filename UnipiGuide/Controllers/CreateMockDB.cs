using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnipiGuide.Models;

namespace UnipiGuide.Controllers
{
    internal class CreateMockDB
    {
        User[] users;
        Professor[] professors;
        Lesson[] lessons;
        Review[] reviews;
        ClassRoom[] classrooms;


        public User[] Users { get { return users; } }
        public Professor[] Professors { get { return professors; } }
        public Lesson[] Lessons { get { return lessons; } }
        public ClassRoom[] ClassRooms { get { return classrooms; } }



        private User[] CreateMockUsers()
        {
            int usersLength = 10;
            User[] tempUsers = new User[usersLength];
            int index;
            for(index = 0; index < usersLength; index++)
            {
                User user = new User();
                user.Id = index;
                user.UserName = "aUserName" + index;
                tempUsers[index] = user;                
            }

            return (User[])tempUsers.Clone();
            
        }

        private Professor[] CreateMockProfessors()
        {
            int professorsLength = 5;
            Professor[] tempProfessors = new Professor[professorsLength];
            int index;
            for(index = 0;index < professorsLength; index++)
            {
                Professor professor = new Professor();
                professor.ProfessorId = index;
                professor.ProfessorName = "aProfessorName" + index;
                professors[index] = professor;
            }
            return (Professor[])tempProfessors.Clone();
        }

        private Lesson[] CreateMockLessons()
        {
            int lessonsLength = 5;
            Lesson[] tempLessons = new Lesson[lessonsLength];
            int index;
            for( index = 0; index < lessonsLength; index++)
            {
                Lesson lesson = new Lesson();
                lesson.LessonId = index;
                lesson.LessonName = "aLessonName" + index;
            }
            return (Lesson[])lessons.Clone();
        }

        private ClassRoom[] CreateMockClassRooms()
        {
            int classroomsLength = 7;
            ClassRoom[] tempClassRooms = new ClassRoom[classroomsLength];
            int index;
            for(index=0; index < classroomsLength; index++)
            {
                ClassRoom classroom = new ClassRoom();
                classroom.ClassroomId = index;
                classroom.ClassRoomName = "aClassRoomName";
                tempClassRooms[index] = classroom;
            }
            return (ClassRoom[])tempClassRooms.Clone();
        }

        public CreateMockDB() {
            Array.Copy(CreateMockUsers(), 0, Users, 0, CreateMockUsers().Length);
            Array.Copy(CreateMockClassRooms(), 0, ClassRooms, 0, CreateMockClassRooms().Length);
            Array.Copy(CreateMockLessons(), 0, Lessons, 0, CreateMockLessons().Length);
            Array.Copy(CreateMockProfessors(), 0, Lessons, 0, CreateMockProfessors().Length);
        }
    }
}
