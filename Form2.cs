using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
            TV_Library.TV BufferObject;
            TV_Library.TV.s_TV_Desc BDesc;
            public Form2()
            {
                InitializeComponent();

                BufferObject = new TV_Library.TV(new TV_Library.TV.s_TV_Desc());

                label1.Text = BufferObject.ParamsName()[0];
                label2.Text = BufferObject.ParamsName()[1];
                label3.Text = BufferObject.ParamsName()[2];
                label4.Text = BufferObject.ParamsName()[3];
                label5.Text = BufferObject.ParamsName()[4];
                label6.Text = BufferObject.ParamsName()[5];
                label7.Text = BufferObject.ParamsName()[6];
                label8.Text = BufferObject.ParamsName()[7];
            }

            private void B_Cancel_Click(object sender, System.EventArgs e)
            {
                BufferObject = null;
                this.Close();
            }

            private void B_Save_Click(object sender, System.EventArgs e)
            {
                BDesc.width = Convert.ToInt32(textBox1.Text);
                BDesc.height = Convert.ToInt32(textBox2.Text);
                BDesc.diagonal = Convert.ToInt32(textBox4.Text);
                BDesc.resolution.X_Res = Convert.ToInt32(textBox3.Text); BDesc.resolution.Y_Res = Convert.ToInt32(textBox9.Text);
                BDesc.modelName = (textBox5.Text);
                BDesc.manufacturer = (textBox6.Text);
                BDesc.price = Convert.ToInt32(textBox6.Text.Replace('.', ','));
                BDesc.weight = Convert.ToInt32(textBox7.Text);

                BufferObject = new TV_Library.TV(BDesc);
                TV_ObjectBuffer.TV_BufferObject = BufferObject;
                this.Close();
            }
        }
}
