using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringLaunchPad.EncapsulateCollection
{
    public class Student
    {

        #region Before
        private List<Course> _courses;

        public List<Course> GetCourses()
        {
            return _courses;
        }


        public void SetCourses(Course course)
        {
            _courses.Add(course);
        }

        #endregion


        #region After
        private List<Course> _enrolledCourses;

        public IEnumerable<Course> EnrolledCourses
        {
            get { return _enrolledCourses; }
        }

        public void AddClass(Course course)
        {
            ValidatePrerequistes(this, course);
            _enrolledCourses.Add(course);
        }


        public void RemoveClass(Course course)
        {
            _enrolledCourses.Remove(course);
        }

        private void ValidatePrerequistes(Student student, Course course)
        {
            throw new NotImplementedException();
        }
        #endregion





    }



    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
