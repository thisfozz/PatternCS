using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHouseExampleNamespace
{
    /*
        * Класс Director не имеет своего собственного метода для создания объекта продукта, так как это ответственность строителя. 
        * Вместо этого Director работает с заданным строителем, вызывая его методы построения в нужной последовательности для создания определенного типа продукта.
        * Однако класс Director играет важную роль в координации и управлении процессом построения продукта с помощью строителя. 
        * Он предоставляет удобный интерфейс для клиента и определяет определенные шаги построения, которые строитель должен выполнить.
    */
    public class Director // отвечает за управление процессом создания продукта
    {
        private IBuilder _builder;

        public IBuilder Builder // Это свойство используется для внедрения зависимости от конкретного строителя (ConcreteBuilder) через интерфейс IBuilder.
        {
            set { _builder = value; }
        }
        public void BuildMinimalViableProduct() //  Этот метод строит только минимально жизнеспособный продукт, выполняя необходимые операции построения для части A.
        {
            _builder.BuildFoundation();
        }
        public void BuildFullFeaturedProduct() // Этот метод строит полнофункциональный продукт, выполняя все необходимые операции построения полнофункционального продукта
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
