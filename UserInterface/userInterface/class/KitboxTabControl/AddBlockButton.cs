using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userInterface
{
    class AddBlockButton: Button
    {
        public AddBlockButton(System.EventHandler callback): base()
        {
            this.Location = new System.Drawing.Point(488, 333);
            this.Name = "AddBlockButton";
            this.Size = new System.Drawing.Size(75, 23);
            this.TabIndex = 1;
            this.Text = "Add block";
            this.UseVisualStyleBackColor = true;
            this.Click += new System.EventHandler(callback);
        }
    }
}
