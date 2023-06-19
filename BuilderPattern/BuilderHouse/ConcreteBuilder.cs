using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHouseExampleNamespace
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            _product = new Product();
        }
        public void BuildFoundation(string material)
        {
            _product.Add($"{material} фундамент");
        }
        public void BuildPartWallOne(string material)
        {
            _product.Add($"{material} стена 1") ;
        }
        public void BuildPartWallTwo(string material)
        {
            _product.Add($"{material} стена 2");
        }
        public void BuildPartWallThree(string material)
        {
            _product.Add($"{material} стена 3");
        }
        public void BuildPartWallFour(string material)
        {
            _product.Add($"{material} стена 4");
        }
        public void BuildPartRoof(string material)
        {
            _product.Add($"{material} крыша");
        }
        public void BuildPool()
        {
            _product.Add("бассейн");
        }
        public void BuildGarage()
        {
            _product.Add("гараж");
        }

        public Product GetProduct()
        {
            Product result = _product;

            Reset();

            return result;
        }
    }
}
