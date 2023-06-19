using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BuilderPattern.BuilderHouse.BuildHouseNotPattern.SeparateСlasses
{
    public class BrickHouse : IBuildNotPattern
    {
        private ProductNot _product = new ProductNot();
        public void BuildFoundation()
        {
            _product.Add("кирпичный фундамент");
        }
        public void BuildPartWallOne()
        {
            _product.Add("кирпичная стена 1");
        }
        public void BuildPartWallTwo()
        {
            _product.Add("кирпичная стена 2");
        }
        public void BuildPartWallThree()
        {
            _product.Add("кирпичная стена 3");
        }

        public void BuildPartWallFour()
        {
            _product.Add("кирпичная стена 4");
        }

        public void BuildPartRoof()
        {
            _product.Add("кирпичная крыша 4");
        }

        public void BuildPool()
        {
            _product.Add("бассейн");
        }
        public void BuildGarage()
        {
            _product.Add("гараж");
        }
        public void Reset()
        {
            _product = new ProductNot();
        }
        public ProductNot GetProduct()
        {
            ProductNot result = _product;

            Reset();

            return result;
        }
    }
}
