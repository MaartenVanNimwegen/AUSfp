using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUSfp
{
    class ItemClass
    {
        public string Name;
        public int Id;
        public string Category;
        public string Student;
        public DateTime TurnInDateTime;
        public int Status;
        public int StudentId;
        public string Description;
        public string Adder;
        public DateTime AddedDateTime;


        public void Item(string name, int id, string category, string student, DateTime turnindatetime, int status, int studentid, string description, string adder, DateTime addeddatetime)
        {
            this.Name = name;
            this.Id = id;
            this.Category = category;
            this.Student = student;
            this.TurnInDateTime = turnindatetime;
            this.Status = status;
            this.StudentId = studentid;
            this.Description = description;
            this.Adder = adder;
            this.AddedDateTime = addeddatetime;
        }
    }
}
