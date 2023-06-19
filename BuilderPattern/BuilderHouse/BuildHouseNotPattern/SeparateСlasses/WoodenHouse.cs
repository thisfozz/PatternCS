using BuilderHouseExampleNamespace;

namespace Builder.BuilderPattern.BuilderHouse.BuildHouseNotPattern.SeparateСlasses
{
    public class WoodenHouse : IBuildNotPattern
    {
        private ProductNot _product = new ProductNot();
        public void BuildFoundation()
        {
            _product.Add("деревянный фундамент");
        }
        public void BuildPartWallOne()
        {
            _product.Add("деревянная стена 1");
        }
        public void BuildPartWallTwo()
        {
            _product.Add("деревянная стена 2");
        }
        public void BuildPartWallThree()
        {
            _product.Add("деревянная стена 3");
        }

        public void BuildPartWallFour()
        {
            _product.Add("деревянная стена 4");
        }

        public void BuildPartRoof()
        {
            _product.Add("деревянная крыша 4");
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
