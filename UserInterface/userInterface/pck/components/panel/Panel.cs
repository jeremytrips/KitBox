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
        protected Color color = Color.White;
        protected string sColor;

        public Color Color { get => color; set
            {
                sColor = ColorMapper.MapColorFrench(value);
                color = value;
            }
        }
        protected string attribute = "PA";
    }
}