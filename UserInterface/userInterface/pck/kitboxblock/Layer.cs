﻿
using System.Collections.Generic;
using System.Drawing;

namespace userInterface
{
    class Layer : Block
    {
        private Door doorType;
        private BackPanel backPanel = new BackPanel();
        private LeftRightPanel leftRightPanel = new LeftRightPanel();
        private TopBottomPanel topBottomPanel = new TopBottomPanel();

        public Layer(int width, int depth)
        {
            this.Width = width;
            this.Depth = depth;
        }

        public Color PanelColor {
            set
            {
                backPanel.Color = value;
                leftRightPanel.Color = value;
                topBottomPanel.Color = value;
            }
        }

        public new int Height
        {
            get => this.height;
            set
            {
                base.Height = value;
                this.backPanel.Height = value;
                this.leftRightPanel.Height = value;
            }

        }

        public new int Width { get => width; set
            {
                base.Width = value;
                this.width = value;
                this.backPanel.Width = value;
                this.topBottomPanel.Width = value;
            }

        }

        public new int Depth
        {
            get => this.depth; set
            {
                base.Depth = value;
                this.depth = value;
                this.topBottomPanel.Depth = value;
                this.leftRightPanel.Depth = value;
            }
        }

        internal Door DoorType { get => doorType; set => doorType = value; }

        public override double ComputePrice()
        {
            throw new System.NotImplementedException();
        }

        public override void GetCodes()
        {
            List<string> codes = new List<string> { };
            codes.Add(this.backPanel.GetCode());
            codes.Add(this.leftRightPanel.GetCode());
            codes.Add(this.topBottomPanel.GetCode());
            codes.Add(this.cleat.GetCode());
            codes.Add(this.doorType.GetCode());

        }
    }
}
