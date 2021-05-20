using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Puzzle02
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pB01.AllowDrop = true;
            pB02.AllowDrop = true;
            pB03.AllowDrop = true;
            pB04.AllowDrop = true;
            pB05.AllowDrop = true;
            pB06.AllowDrop = true;
            pB07.AllowDrop = true;
            pB08.AllowDrop = true;
            pB09.AllowDrop = true;

        }

    


        private void pB7_MouseClick_1(object sender, MouseEventArgs e)
        {

        }

        private void pB7_MouseDown(object sender, MouseEventArgs e)
        {
            pB7.DoDragDrop(pB7.Image, DragDropEffects.Move);
        }

        private void pB9_MouseClick_1(object sender, MouseEventArgs e)
        {

        }

        private void pB9_MouseDown_1(object sender, MouseEventArgs e)
        {
            pB9.DoDragDrop(pB9.Image, DragDropEffects.Move);
        }

        private void pB3_MouseClick_1(object sender, MouseEventArgs e)
        {

        }

        private void pB3_MouseDown_1(object sender, MouseEventArgs e)
        {
            pB3.DoDragDrop(pB3.Image, DragDropEffects.Move);
        }

        private void pB8_MouseClick_1(object sender, MouseEventArgs e)
        {

        }

        private void pB8_MouseDown_1(object sender, MouseEventArgs e)
        {
            pB8.DoDragDrop(pB8.Image, DragDropEffects.Move);
        }

        private void pB5_MouseClick_1(object sender, MouseEventArgs e)
        {

        }

        private void pB5_MouseDown_1(object sender, MouseEventArgs e)
        {
            pB5.DoDragDrop(pB5.Image, DragDropEffects.Move);
        }

        private void pB1_MouseClick_1(object sender, MouseEventArgs e)
        {

        }

        private void pB1_MouseDown_1(object sender, MouseEventArgs e)
        {
            pB1.DoDragDrop(pB1.Image, DragDropEffects.Move);
        }

        private void pB6_MouseClick_1(object sender, MouseEventArgs e)
        {

        }

        private void pB6_MouseDown_1(object sender, MouseEventArgs e)
        {
            pB6.DoDragDrop(pB6.Image, DragDropEffects.Move);
        }

        private void pB4_MouseClick_1(object sender, MouseEventArgs e)
        {

        }

        private void pB4_MouseDown_1(object sender, MouseEventArgs e)
        {
            pB4.DoDragDrop(pB4.Image, DragDropEffects.Move);
        }

        private void pB2_MouseClick_1(object sender, MouseEventArgs e)
        {

        }

        private void pB2_MouseDown_1(object sender, MouseEventArgs e)
        {
            pB2.DoDragDrop(pB2.Image, DragDropEffects.Move);
        }

        private void pB01_DragEnter_1(object sender, DragEventArgs e)
        {

            e.Effect = e.AllowedEffect;
        }

        
        private void pB01_DragDrop_1(object sender, DragEventArgs e)
        {
           
            pB01.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pB01.BorderStyle = System.Windows.Forms.BorderStyle.None;
            if (pB01.Image != pB1.Image)
                pB01.Image = null;

        }


        private void pB02_DragEnter(object sender, DragEventArgs e)
        {

            e.Effect = e.AllowedEffect;
        }

        private void pB02_DragDrop(object sender, DragEventArgs e)
        {

            pB02.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pB02.BorderStyle = System.Windows.Forms.BorderStyle.None;
            if (pB02.Image != pB2.Image)
                pB02.Image = null;
           
        }

        private void pB03_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pB03_DragDrop(object sender, DragEventArgs e)
        {
            pB03.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pB03.BorderStyle = System.Windows.Forms.BorderStyle.None;
            if (pB03.Image != pB3.Image)
                pB03.Image = null;
           
        }

        private void pB04_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pB04_DragDrop(object sender, DragEventArgs e)
        {
            pB04.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pB04.BorderStyle = System.Windows.Forms.BorderStyle.None;
            if (pB04.Image != pB4.Image)
                pB04.Image = null;
           
        }

        private void pB05_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pB05_DragDrop(object sender, DragEventArgs e)
        {
            pB05.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pB05.BorderStyle = System.Windows.Forms.BorderStyle.None;
            if (pB05.Image != pB5.Image)
                pB05.Image = null;
            
        }

        private void pB06_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pB06_DragDrop(object sender, DragEventArgs e)
        {
            pB06.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pB06.BorderStyle = System.Windows.Forms.BorderStyle.None;
            if (pB06.Image != pB6.Image)
                pB06.Image = null;
           
        }

        private void pB07_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pB07_DragDrop(object sender, DragEventArgs e)
        {
            pB07.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pB07.BorderStyle = System.Windows.Forms.BorderStyle.None;
            if (pB07.Image != pB7.Image)
                pB07.Image = null;
            
        }

        private void pB08_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pB08_DragDrop(object sender, DragEventArgs e)
        {
            pB08.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pB08.BorderStyle = System.Windows.Forms.BorderStyle.None;
            if (pB08.Image != pB8.Image)
                pB08.Image = null;
            
        }

        private void pB09_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pB09_DragDrop(object sender, DragEventArgs e)
        {
            pB09.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pB09.BorderStyle = System.Windows.Forms.BorderStyle.None;
            if (pB09.Image != pB9.Image)
                pB09.Image = null;
            
        }

        
    }
}
