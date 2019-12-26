using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAlgoritmos
{
    public abstract class Box<Orientation>
    {
        public Status status { get; set; }
        public Dictionary<Orientation, Box<Orientation>> Neighborhood = new Dictionary<Orientation, Box<Orientation>>();
        public Token token { get; set; }

        public bool IsFree()
        {
            return status.IsFree();
        }

        public bool IsFree(Orientation direction)
        {
            if (IsFree())
            {
                if (Neighborhood[direction] == null)
                {
                    return true;
                }
                else
                {
                    return Neighborhood[direction].IsFree(direction);
                }
            }
            else
            {
                return false;
            }
        }

        public void SetEmpty()
        {
            if (status.Cleanable())
            {
                token = null;

            }
        }
    }
}
