using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Student
    {
        private static int studentId = 0;
        public Student() {
            StudentID=++studentId;
        }
        public Student(string name, DateTime dob, string gender, int sclass, char section,string staffName)
        {
            StudentID = ++studentId;
            StudentName = name;
            DOB = dob;
            Gender = gender;
            StudentClass = sclass;
            Section = section;
            StaffName = staffName;
        }
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime DOB;
        public string Gender{ set; get; }
        public int StudentClass { set; get; }
        public char Section { set; get; } 
        public string StaffName;
    }
}
