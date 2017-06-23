using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ESTD2
{
    class Index
    {
        private string[] ListaNombres = new string[size];
        static public int size = 10;
        public Index()
        {
            for (int i = 0; i < size; i++)
            {
                ListaNombres[i] = "N. A.";
            }
        }

        public string this[int index]
        {
            get
            {
                string tmp;

                if (index >= 0 && index <= size - 1)
                {
                    tmp = ListaNombres[index];
                }
                else
                {
                    tmp = "";
                }

                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    ListaNombres[index] = value;
                }
            }
        }
        public int this[string name]
        {
            get
            {
                int index = 0;
                while (index < size)
                {
                    if (ListaNombres[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return index;
            }

        }
    }
}
