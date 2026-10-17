using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Egyetemi_feladat_objekt_Levelezo
{
    internal class Distance_learner
    {
        string workplace;
        public Distance_learner(string name, int point, string workplace) :base(name, point)
        {
            this.workplace = workplace;
        }
    }
}