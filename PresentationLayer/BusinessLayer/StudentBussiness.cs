using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StudentBussiness
    {
        private readonly StudentRepository studentRepository;
        public StudentBussiness()
        {
            this.studentRepository = new StudentRepository();
        }

        public List<Student> GetStudents()
        {
           return this.studentRepository.GetStudents();
        }

        public bool InsertStudent(Student s)
        {
            if(this.studentRepository.InsertStudent(s) > 0)
            {
                return true;
            }
            return false;
        }

        public List<Student> GetStudentsWithMark(decimal averageMark)
        {
            return this.studentRepository.GetStudents().Where(s => s.AverageMark > averageMark).ToList();
        }
    }
}
