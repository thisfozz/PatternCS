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
            _product = new Product(); // переустанавливает _product на новый экземпляр класса Product(). Это выполняется для сброса состояния строителя и подготовки к созданию нового продукта.
        }
        public void BuildFoundation()
        {
            _product.Add("Фундамент"); // добавляет "Фундамент" в список частей продукта _parts с помощью метода Add() объекта _product.
        }
        public void BuildPartWallOne()
        {
            _product.Add("Стена 1"); // добавляет "Стена 1" в список частей продукта _parts с помощью метода Add() объекта _product.
        }
        public void BuildPartWallTwo()
        {
            _product.Add("Стена 2"); // добавляет "Стена 2" в список частей продукта _parts с помощью метода Add() объекта _product.
        }
        public void BuildPartWallThree()
        {
            _product.Add("Стена 3"); // добавляет "Стена 3" в список частей продукта _parts с помощью метода Add() объекта _product.
        }
        public void BuildPartWallFour()
        {
            _product.Add("Стена 4"); // добавляет "Стена 4" в список частей продукта _parts с помощью метода Add() объекта _product.
        }

        public void BuildPartRoof()
        {
            _product.Add("Крыша");
        }
        public Product GetProduct()
        {
            Product result = _product; // // сохраняет текущий _product в локальную переменную result.

            Reset(); // Этот метод для сброса состояния строителя, чтобы гарантировать, что при следующем вызове метода GetProduct() будет создан новый продукт.

            return result; // Наконец, метод возвращает сохраненный result, представляющий готовый продукт.
        }
    }
}
