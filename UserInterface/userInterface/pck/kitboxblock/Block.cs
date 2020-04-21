﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using userInterface;

/*
 * TODO :   - Remember how to impose a child class to have a certain function (ToListDescription)
 *          - Create a widget class to properly display block
 */

namespace userInterface
{
    abstract class Block
    {
        protected int height;
        protected int width;
        protected int depth;


        protected Cleat cleat = new Cleat();
        protected SideSleeper sideSleeper = new SideSleeper();
        protected FrontSleeper frontSleeper = new FrontSleeper();
        protected BackSleeper backSleeper = new BackSleeper();

        public int Height
        {
            get => height; set
            {
                height = value;
                this.cleat.Height = value;
            }
        }

        public int Width
        {
            get => width; set
            {
                width = value;
                this.frontSleeper.Width = value;
                this.backSleeper.Width = value;
            }
        }

        public int Depth
        {
            get => depth; set
            {
                depth = value;
                sideSleeper.Depth = value;
            }
        }

        public abstract double ComputePrice();
    }
}
