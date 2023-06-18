using BuilderGameChapterNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderGameChapterNamespace
{
    public class CharacterDirector
    {
        private ICharacterBuilder _builder;

        /*
         * В момент создания объекта CharacterDirector клиентский код должен передать конкретную реализацию строителя, которую будет использовать директор для построения персонажей.
         * Параметр builder: Это объект, реализующий интерфейс ICharacterBuilder, который будет использоваться директором для построения персонажей. 
        */
        public CharacterDirector(ICharacterBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructBarbarian()
        {
            _builder.SetClass("Варвар");
            _builder.SetHealth(900);
            _builder.SetAttackPower(70);
        }

        public void ConstructSorceress()
        {
            _builder.SetClass("Волшебница");
            _builder.SetHealth(500);
            _builder.SetAttackPower(110);
        }
        
        public void ConstructDruid()
        {
            _builder.SetClass("Друид");
            _builder.SetHealth(400);
            _builder.SetAttackPower(80);
        }   
    }
}
