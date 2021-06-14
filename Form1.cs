using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TV_Library;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        List<TV_Library.TV> DataList = new List<TV>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TV_ObjectBuffer.TV_BufferObject = new TV_Library.TV(new TV_Library.TV.s_TV_Desc());
            Form2 newWindow = new Form2();
            newWindow.ShowDialog();
            if (TV_ObjectBuffer.TV_BufferObject != null)
                this.DataList.Add(TV_ObjectBuffer.TV_BufferObject);
            UpdateDGVData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataList.Clear();
            UpdateDGVData();
        }
        private void UpdateDGVData()
        {
            DGV_Data.Rows.Clear();
            int rowCount = DataList.Count;
            for (int row = 0; row < rowCount; row++)
            {
                DGV_Data.Rows.Add();
                DGV_Data.Rows[row].Cells[0].Value = DataList[row].DataForDGV()[0];
                DGV_Data.Rows[row].Cells[1].Value = DataList[row].DataForDGV()[1];
                DGV_Data.Rows[row].Cells[2].Value = DataList[row].DataForDGV()[2];
                DGV_Data.Rows[row].Cells[3].Value = DataList[row].DataForDGV()[3];
                DGV_Data.Rows[row].Cells[4].Value = DataList[row].DataForDGV()[4];
                DGV_Data.Rows[row].Cells[5].Value = DataList[row].DataForDGV()[5];
                DGV_Data.Rows[row].Cells[6].Value = DataList[row].DataForDGV()[6];
                DGV_Data.Rows[row].Cells[7].Value = DataList[row].DataForDGV()[7];
            }
        }
    }
    public class TV_ObjectBuffer
    {
        public static TV_Library.TV TV_BufferObject { get; set; }
    }
}
