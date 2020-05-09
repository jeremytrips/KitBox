using System;
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
                if(value<62)
                {
                    this.doorType = new ClassicDoor(Color.White);
                    this.doorType.Height = value;
                    Console.WriteLine(doorType.Height);
                }
                else
                {
                    this.doorType = null;
                }
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

        internal Door DoorType
        {
            get => doorType; set
            {
                doorType = value;
                if (value != null) {
                    this.doorType.Width = this.width;
                    this.doorType.Height = this.height;
                }
            }
        }

        public override double ComputePrice()
        {
            throw new System.NotImplementedException();
        }

        public override List<string> GetCodes()
        {
            List<string> codes = new List<string> { };
            codes.Add(this.backPanel.GetCode());
            codes.Add(this.leftRightPanel.GetCode());
            codes.Add(this.topBottomPanel.GetCode());
            codes.Add(this.cleat.GetCode());
            if(this.doorType != null) {
                if (this.doorType is GlassDoor)
                {
                    codes.Add(this.doorType.GetCode());
                } else
                {
                    codes.Add(this.doorType.GetCode());
                    codes.Add(this.doorType.GetCupCode());
                }
                
            }
            codes.Add(this.frontSleeper.GetCode());
            codes.Add(this.sideSleeper.GetCode());
            codes.Add(this.backSleeper.GetCode());
            return codes;
        }
    }
}
