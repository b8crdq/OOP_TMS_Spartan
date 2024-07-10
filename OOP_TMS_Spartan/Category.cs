using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TMS_Spartan
{
    public interface Category
    {
        public abstract string Type();

    }

    class Sprint : Category {
        private static Sprint? instance;
        private Sprint() : base() { }
        public static Sprint Instance()
        {
            if(instance == null)
            {
                instance = new Sprint();
            }
            return instance;
        }

        public string Type()
        {
            return "sprint";
        }
    }

    class Beast : Category
    {
        private static Beast instance;
        private Beast() : base() { }
        public static Beast Instance()
        {
            if (instance == null)
            {
                instance = new Beast();
            }
            return instance;
        }

        public string Type()
        {
            return "beast";
        }
    }
    class Super : Category
    {
        private static Super instance;
        private Super() : base() { }
        public static Super Instance()
        {
            if (instance == null)
            {
                instance = new Super();
            }
            return instance;
        }

        public string Type()
        {
            return "super";
        }
    }
}
