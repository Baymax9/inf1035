﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Game
{
    public interface ITile
    {

        void Activate(IGameController controller);
    }
}
