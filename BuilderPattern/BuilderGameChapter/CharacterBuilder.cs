using BuilderGameChapterNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderGameChapterNamespace
{
    public class CharacterBuilder : ICharacterBuilder
    {
        private Character _character;

        public CharacterBuilder()
        {
            _character = new Character();
        }

        public void SetClass(string characterClass)
        {
            _character.ChapterClass = characterClass;
        }

        public void SetHealth(int health)
        {
            _character.Health = health;
        }

        public void SetAttackPower(int attackPower)
        {
            _character.AttackPower = attackPower;
        }

        public Character GetCharacter()
        {
            Character result = _character;
            Reset();
            return result;
        }
        private void Reset()
        {
            _character = new Character();
        }
    }
}
