using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace واجب_10_برمجة_مرئية
{
    public class student
    {
        private int number;
        private string name;
        private string brithdate;
        private string imapgth;

        public void SetNumber(int number)
        {
            this.number = number;

        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetBithdate(string birthdate)
        {
            this.brithdate = birthdate;

        }
        public void SetImagePath(string imagepath)
        {
            this.imapgth = imagepath;
        }
        public int GetNumber()
        {
            return number;
        }

        public string GetName() => name;
        public string GetBrithdate() => brithdate;
        public string GetIMAPgth() => imapgth;
        
    }
}
