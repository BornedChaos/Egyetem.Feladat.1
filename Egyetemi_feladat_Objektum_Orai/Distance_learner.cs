using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Egyetemi_feladat_Objektum_Orai
{
    internal class Distance_learner : Students
    {
        string workplace;
        public Distance_learner(string name, int point, string workplace) : base(name, point)
        {
            this.workplace = workplace;
        }
        public override string Visualize()
        {
            return base.Visualize() + " Munkavégzés helye: " + workplace;
        }
    }
}