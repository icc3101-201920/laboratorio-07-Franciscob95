using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_6_OOP_201902
{
    interface IAttackPoints
    {
        int[] GetAttackPoints(Enums.EnumType line = Enums.EnumType.None);
    }
}
