﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace userInterface
{
    /*
     * Class that groups all panels
     */
    abstract class Panel : Component
    {
        private Color color;

        protected Color Color { get => color; set => color = value; }
    }
}