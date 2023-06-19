using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BuilderPattern.BuilderHouse.BuildHouseNotPattern.SeparateСlasses
{
    public interface IBuildNotPattern
    {
        void BuildFoundation();
        void BuildPartWallOne();
        void BuildPartWallTwo();
        void BuildPartWallThree();
        void BuildPartWallFour();
        void BuildPartRoof();
        void BuildPool();
        void BuildGarage();
    }
}
