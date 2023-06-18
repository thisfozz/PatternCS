using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHouseExampleNamespace
{
    public interface IBuilder
    {
        void BuildFoundation();
        void BuildPartWallOne();
        void BuildPartWallTwo();
        void BuildPartWallThree();
        void BuildPartWallFour();
        void BuildPartRoof();
    }
}
