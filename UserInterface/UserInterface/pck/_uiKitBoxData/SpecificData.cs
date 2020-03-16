using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Todo :   - Fix the set and get data function
 *          - May be set this class as an interface and create a class for every kind of block
 * 
 */

namespace userInterface
{
    class SpecificDataPanel: DataPanel
    {
        static int a = 0;
        private Label test = new Label();
        private int id;
        public SpecificDataPanel(int id): base()
        {
            this.MountLayout();
            a++;
        }

        private void MountLayout()
        {
            // Mounting layout
            this.Location = new System.Drawing.Point(30, 219);
            this.Size = new System.Drawing.Size(400, 350);
            this.BackColor = System.Drawing.Color.Red;

            // Moutning test label
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(161, 160);
            this.test.Size = new System.Drawing.Size(35, 13);
            this.test.Text = "label" + a;

            this.Controls.Add(this.test);
        }

        public override Dictionary<String, object> GetData()
        {
            return new Dictionary<String, object>
            {
                {"color", System.Drawing.Color.Red}
            };
        }

        public override void SetData(Dictionary<String, object> dataToSet)
        {

        }
    }
}
