using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TMS_Spartan
{
    public  class Competitor
    {
        private Competition competition;
        private int id;
        private string name;
        private bool man;

        public Competitor(int id,string n, bool m) 
        {
            if (id <= 0)
            {
                throw new Exception();
            }
            this.id = id;
            this.name = n;
            this.man = m;
           
          
        }

        public int ID()
        {
            return id;
        }
        public bool Man()
        {
            return man;
        }
        public bool IsWinner(Category c)
        {
           

            bool l;
            Competitor comp;

            (l, comp) = competition.Winner(c, man);

            

            return (l && comp == this);
        }


        public void SetCompetition(Competition c)
        {
            competition =c;
        }

    }
}

