using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHouseExampleNamespace
{
    public interface IBuilder
    {
        void BuildFoundation(string material);
        void BuildPartWallOne(string material);
        void BuildPartWallTwo(string material);
        void BuildPartWallThree(string material);
        void BuildPartWallFour(string material);
        void BuildPartRoof(string material);
        void BuildPool();
        void BuildGarage();
    }
}
