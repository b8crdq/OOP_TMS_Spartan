using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TMS_Spartan
{
    public class Result
    {
        private int min;
        private int sec;
        private Category cat;
        private Competitor comp;
        public Result(int m, int s,Competitor c , Category cath)
        {
            if(m <=0 ||  s < 0 || s>59 )
            {
                throw new Exception();
            }
            this.min = m;
            this.sec = s;
            this.comp = c;
            this.cat = cath;

        }

        public Category Cat()
        { 
            return cat;
        }
        
        public int Sec()
        {
            return sec;
        }
        public int Min()
        {
            return min;
        }

        public Competitor Comp()
        {
            return comp;
        }
    }
}
