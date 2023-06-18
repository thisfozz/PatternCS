using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHouseExampleNamespace
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product(); // представляет собой создаваемый продукт

        public ConcreteBuilder()
        {
            Reset(); //  сбрасывает состояние объекта строителя, чтобы гарантировать, что при создании нового продукта состояние строителя будет чистым.
        }
        public void Reset()
        {
            _product = new Product();
        }
        public void BuildFoundation()
        {
            _product.Add("Фундамент");
        }
        public void BuildPartWallOne()
        {
            _product.Add("Стена 1");
        }
        public void BuildPartWallTwo()
        {
            _product.Add("Стена 2");
        }
        public void BuildPartWallThree()
        {
            _product.Add("Стена 3");
        }
        public void BuildPartWallFour()
        {
            _product.Add("Стена 4");
        }

        public void BuildPartRoof()
        {
            _product.Add("Крыша");
        }
        public Product GetProduct()
        {
            Product result = _product;

            Reset();

            return result;
        }
    }
}
