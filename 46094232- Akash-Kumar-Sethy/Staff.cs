using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Staff
    {
        public int StaffID;
        public Staff(string name,int id) {
            StaffName = name;
            StaffID=id;
        }
        public string StaffName{ set; get; }
    }
}
