using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHouseExampleNamespace
{
    public class Director
    {
        private IBuilder _builder;

        public Director(IBuilder _builder)
        {
            this._builder = _builder;
        }
        public void BuildMinimalViableProduct()
        {
            _builder.BuildFoundation();
        }
        public void BuildFullFeaturedProduct()
        {
            _builder.BuildFoundation();
            _builder.BuildPartWallOne();
            _builder.BuildPartWallTwo();
            _builder.BuildPartWallThree();
            _builder.BuildPartWallFour();
            _builder.BuildPartRoof();
        }
    }
}
