using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryfrmwrk
{
    public class Class1
    {
        public struct Student
        {
            public int Id;
            public string Name;
            public int Fees;

            public void SetStudent(int id, string name, int fees)
            {
                Id = id;
                Name = name;
                Fees = fees;
                
            }

            
        }
    }
}