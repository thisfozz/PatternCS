using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderGameChapterNamespace
{
    public interface ICharacterBuilder
    {
        void SetClass(string characterClass);
        void SetHealth(int health);
        void SetAttackPower(int attackPower);
        Character GetCharacter();
    }
}
