using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Interfaces
{
    interface ICharacter
    {
        void Attack();
        void Defend();
        void SayName();
        void ChallengeToDuel();
        void CastSpell();
    }
}
