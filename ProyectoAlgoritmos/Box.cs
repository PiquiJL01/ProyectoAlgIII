using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAlgoritmos
{
    public abstract class Box<Orientation>
    {
        public Status status;
        public Dictionary<Orientation, Box<Orientation>> Neighborhood;
        public Token token;
    }
}
