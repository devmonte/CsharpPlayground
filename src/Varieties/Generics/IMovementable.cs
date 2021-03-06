﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public interface IMovementable<T> where T : Creature
    {
        void Move();
    }
}
