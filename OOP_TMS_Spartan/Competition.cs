using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TMS_Spartan
{
    public class Competition
    {
        private int year;
        private string place;
        public  List<Competitor> competitors = new();
        public List<Category> cath = new();
        public  List<Result> res = new();
        public Competition(int y, string p, List<Category> c)
        {
            if (c.Count == 0 || y <= 2000)
            {
                throw new Exception();
            }
            this.year = y;
            this.place = p;
            this.cath = c;




        }
        public void Register(Competitor c)
        {
           
            foreach (Competitor e in competitors)
            {
                if (e.ID() == c.ID())
                {
                    throw new Exception();
                }
              
            }
          

            competitors.Add(c);
            c.SetCompetition(this);
        }

        public Category PopularCath()
        {
            int max = int.MinValue;
            Category c = cath[0];
            foreach (Category e in cath)
            {
                int sum = 0;
                foreach (Result e2 in res)
                {
                    if (e2.Cat().Type() == e.Type())
                    {
                        sum++;

                    }
                    if (sum > max)
                    {
                        max = sum;
                        c = e;
                    }

                }
            }
            return c;
        }

        public void Score(int min, int sec, int num, Category c)
        {

            bool l = false;
            Competitor elem2 = null;
            foreach (Competitor e in competitors)
            {
                if (!l && e.ID() == num)
                {
                    l = true;
                    elem2 = e;

                }
                
            }
            if (!l)
            {
                throw new Exception();
            }
            bool l2 = false;
            Category elem = cath[0];
            foreach (Category e in cath)
            {
                if (!l2 && e == c)
                {
                    l2 = true;
                    elem = e;


                }

            }
            if (!l2)
            {
                throw new Exception();
            }

            bool l3 = false;
            bool cond = false;
            foreach (Result e in res)
            {
                if (!l3 && e.Cat() == c && e.Comp().ID() == num)
                {
                    l3 = true;
                    cond = e.Cat() == c && e.Comp().ID() == num;

                }
            }
            if (l3)
            {
                throw new Exception();
            }
            res.Add(new Result(min, sec, elem2, c));
        }

        public (bool, Competitor) Winner(Category c, bool man)
        {
            int min = int.MaxValue;

            bool l = false;


            Result elem = null;
            foreach (Result e in res)
            {
                if (e.Min() * 60 + e.Sec() < min
                    && e.Cat() == c && e.Comp().Man() == man)
                {
                    elem = e;
                    min = e.Min() * 60 + e.Sec();
                    l = true;

                }
              
            }
            return elem == null ? (l, null) : (l, elem.Comp());
            //Console.WriteLine(l + " :: " + elem.ID());

        }
    }
}


