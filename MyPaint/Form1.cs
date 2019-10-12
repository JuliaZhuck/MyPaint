using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MyPaint
{
    public enum WhatToDraw
    {
         DrawAfrerMouse = 0, 
         DrawCommonLine,
         DrawEmptyRectangle,
         DrawFillRectangle,
         DrawEmptyEllipse,
         DrawFillEllipse
    };
    public partial class Form1 : Form
    {
        //form for changing size of image
        FormSize formSizeImage;
        //width and heigth of empty bitmap
        const int EmptyBitmapWidth = 800;
        const int EmptyBitmapHeigth = 600;
        //bitmap empty or loaded from file using as shadow bitmap
        Bitmap currentBitmap;
        Graphics grfCurrentBitmap;
        //true - file is not saved; saveFileDialog will be called
        bool mustSaveBitmap;
        //enum for mouse-events helps to define what to draw
        WhatToDraw drawObject = WhatToDraw.DrawAfrerMouse;
        //for pen or brush; loaded from colorDialog
        Color currentColor = Color.Black;
        //for pen or brush
        int currentWidth = 2;
        //pen for draw
        Pen currentPen = new Pen(Color.Black, 2);
        //true - can draw 
        bool mustDraw = false;
        //this fields help in drawing 
        Point ptLast;
        Point ptBegin;
        Rectangle rectForFigures = new Rectangle();

        public Form1()
        {
            InitializeComponent();
            this.ResizeRedraw = true;
            CreateEmptyBitmap();
            this.toolStripComboBoxWidth.SelectedIndex = currentWidth - 1;
        }

        protected void CreateEmptyBitmap()
        {
            if (this.pictureBox1.Image != null)
            {
                DialogResult result = MessageBox.Show(
                      "Сохранить изменения в файле \"" + this.Text + "\"?",
                      "MyPaint", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (result)
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.No:
                        mustSaveBitmap = false;
                        break;
                    case DialogResult.Yes:
                        SavingFileAs();
                        break;
                }
                currentBitmap.Dispose();
                grfCurrentBitmap.Dispose();
            }
            currentBitmap = new Bitmap(EmptyBitmapWidth, EmptyBitmapHeigth);
            this.panel1.AutoScrollMinSize = new Size(EmptyBitmapWidth, EmptyBitmapHeigth);
            grfCurrentBitmap = Graphics.FromImage(currentBitmap);
            grfCurrentBitmap.Clear(Color.White);
            this.Text = "Безымянный";
            mustSaveBitmap = true;
            this.pictureBox1.Image = currentBitmap;
        }


        protected void SavingFileAs()
        {
            this.saveFileDialog1.Filter = 
                "BMP | *.bmp |GIF | *.gif |JPEG | *.jpeg |PNG | *.png";
            this.saveFileDialog1.FilterIndex = 1;
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    currentBitmap = (Bitmap)this.pictureBox1.Image;
                    switch (this.saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            currentBitmap.Save(this.saveFileDialog1.FileName,
                                ImageFormat.Bmp);
                            break;
                        case 2:
                            currentBitmap.Save(this.saveFileDialog1.FileName,
                                ImageFormat.Gif);
                            break;
                        case 3:
                            currentBitmap.Save(this.saveFileDialog1.FileName,
                                ImageFormat.Jpeg);
                            break;
                        case 4:
                            currentBitmap.Save(this.saveFileDialog1.FileName,
                                ImageFormat.Png);
                            break;
                    }
                    this.Text = this.saveFileDialog1.FileName;
                    mustSaveBitmap = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "MyPaint", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.ScaleTransform(1.0f, 1.0f);
            e.Graphics.TranslateTransform(this.panel1.AutoScrollPosition.X,
                 this.panel1.AutoScrollPosition.Y);
            this.pictureBox1.Invalidate();
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            this.toolStripStatusLabelName.Text = "Имя: " + Path.GetFileName(this.Text);
            this.toolStripStatusLabelSize.Text = "Размер: " +
                currentBitmap.Size.Width + "x" + currentBitmap.Size.Height;
            this.toolStripStatusLabelResolurtion.Text = "Разрешение: " +
                currentBitmap.HorizontalResolution + "x" +
                currentBitmap.VerticalResolution;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            switch (drawObject)
            {
                case WhatToDraw.DrawCommonLine:
                    e.Graphics.DrawLine(currentPen, ptLast, ptBegin);
                    break;
                case WhatToDraw.DrawEmptyRectangle:
                    e.Graphics.DrawRectangle(currentPen, rectForFigures);
                    break;
                case WhatToDraw.DrawEmptyEllipse:
                    e.Graphics.DrawEllipse(currentPen, rectForFigures);
                    break;
                case WhatToDraw.DrawFillRectangle:
                    e.Graphics.FillRectangle(new SolidBrush(currentColor), rectForFigures);
                    break;
                case WhatToDraw.DrawFillEllipse:
                    e.Graphics.FillEllipse(new SolidBrush(currentColor), rectForFigures);
                    break;
            }

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                 return;
             ptLast = new Point(e.X, e.Y);
             mustDraw = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            if (!mustDraw)
                return;
            Graphics grf = this.pictureBox1.CreateGraphics();
            switch (drawObject)
            {
                case WhatToDraw.DrawAfrerMouse:
                    Point ptNew = new Point(e.X, e.Y);
                    grf.DrawLine(currentPen, ptLast, ptNew);
                    grfCurrentBitmap.DrawLine(currentPen, ptLast, ptNew);
                    ptLast = ptNew;
                    break;
                case WhatToDraw.DrawCommonLine:
                    ptBegin = new Point(e.X, e.Y);
                    this.pictureBox1.Invalidate();
                    break;

                case WhatToDraw.DrawEmptyRectangle:
                case WhatToDraw.DrawFillRectangle:
                case WhatToDraw.DrawEmptyEllipse:
                case WhatToDraw.DrawFillEllipse:
                    rectForFigures.Size = new Size(Math.Abs(e.X - ptLast.X),
                    Math.Abs(e.Y - ptLast.Y));
                    if (e.X > ptLast.X && e.Y < ptLast.Y)
                    {
                        rectForFigures.X = ptLast.X;
                        rectForFigures.Y = ptLast.Y - rectForFigures.Height;
                    }
                    if (e.X < ptLast.X && e.Y < ptLast.Y)
                    {
                        rectForFigures.X = e.X;
                        rectForFigures.Y = e.Y;
                    }
                    if (e.X < ptLast.X && e.Y > ptLast.Y)
                    {
                        rectForFigures.X = e.X;
                        rectForFigures.Y = e.Y - rectForFigures.Height;
                    }
                    if (e.X > ptLast.X && e.Y > ptLast.Y)
                    {
                        rectForFigures.X = ptLast.X;
                        rectForFigures.Y = ptLast.Y;
                    }
                    this.pictureBox1.Invalidate();
                    break;
            }
            grf.Dispose();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawObject == WhatToDraw.DrawCommonLine)
                grfCurrentBitmap.DrawLine(currentPen, ptLast, ptBegin);
            else if (drawObject == WhatToDraw.DrawEmptyRectangle)
                grfCurrentBitmap.DrawRectangle(currentPen, rectForFigures);
            else if (drawObject == WhatToDraw.DrawEmptyEllipse)
                grfCurrentBitmap.DrawEllipse(currentPen, rectForFigures);
            else if (drawObject == WhatToDraw.DrawFillRectangle)
                grfCurrentBitmap.FillRectangle(new SolidBrush(currentColor), rectForFigures);
            else if (drawObject == WhatToDraw.DrawFillEllipse)
                grfCurrentBitmap.FillEllipse(new SolidBrush(currentColor), rectForFigures);
            mustDraw = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (currentBitmap != null && mustSaveBitmap == true)
            {
                DialogResult result = MessageBox.Show(
                      "Сохранить изменения в файле \"" + this.Text + "\"?",
                      "MyPaint", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (result)
                {
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    case DialogResult.No:
                        mustSaveBitmap = false;
                        break;
                    case DialogResult.Yes:
                        SavingFileAs();
                        break;
                }
            }
        }
    


        // menu File

        //create
        private void toolStripMenuItemFileCreate_Click(object sender, EventArgs e)
        {
            CreateEmptyBitmap();
        }

        //open
        private void toolStripMenuItemFileOpen_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null && mustSaveBitmap == true)
            {
                DialogResult result = MessageBox.Show(
                                      "Сохранить изменения в файле \"" + this.Text + "\"?",
                                      "MyPaint", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (result)
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.No:
                        mustSaveBitmap = false;
                        break;
                    case DialogResult.Yes:
                        SavingFileAs();
                        break;
                }
            }
            this.openFileDialog1.Filter =
                "BMP | *.bmp |GIF | *.gif |JPEG | *.jpeg |PNG | *.png |All files | *.*";
            this.openFileDialog1.FilterIndex = 5;
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {               
                try
                {
                    currentBitmap.Dispose();
                    grfCurrentBitmap.Dispose();
                    currentBitmap = (Bitmap)Image.FromFile(this.openFileDialog1.FileName);
                    grfCurrentBitmap = Graphics.FromImage(currentBitmap);
                    this.panel1.AutoScrollMinSize = new Size((int)(currentBitmap.Width * 1.5),
                        (int)(currentBitmap.Height * 1.5));
                    mustSaveBitmap = true;
                    this.Text = this.openFileDialog1.FileName;
                    this.pictureBox1.Image = currentBitmap;/*Image.FromFile(this.openFileDialog1.FileName);*/
                    this.statusStrip1.Invalidate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "MyPaint", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }
        }

        //save
        private void toolStripMenuItemFileSave_Click(object sender, EventArgs e)
        {
            if (this.Text == "Безымянный")
                SavingFileAs();
            else
            {
                try
                {
                    currentBitmap.Save(this.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "MyPaint", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }
        }

        //saveas
        private void toolStripMenuItemFileSaveAs_Click(object sender, EventArgs e)
        {
            SavingFileAs();
        }

        //exit
        private void toolStripMenuItemFileExit_Click(object sender, EventArgs e)
        {       
                this.Close();
        }

        //picture

        //rotate
        private void toolStripMenuItemPictureRotate90_Click(object sender, EventArgs e)
        {
            currentBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            this.pictureBox1.Image = currentBitmap;
        }
        private void toolStripMenuItemPictureRotate180_Click(object sender, EventArgs e)
        {
            currentBitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
            this.pictureBox1.Image = currentBitmap;
        }

        private void toolStripMenuItemPictureRotate270_Click(object sender, EventArgs e)
        {
            currentBitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
            this.pictureBox1.Image = currentBitmap;
        }


        //toolstrip

        //colors
        private void toolStripButtonColors_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog1.Color;
                currentPen = new Pen(currentColor, currentWidth);
            }
        }

        private void toolStripButtonPen_Click(object sender, EventArgs e)
        {
            drawObject = WhatToDraw.DrawAfrerMouse;
            currentWidth = 2;
            currentPen = new Pen(currentColor, currentWidth);
        }

        private void toolStripButtonBrush_Click(object sender, EventArgs e)
        {
            drawObject = WhatToDraw.DrawAfrerMouse;
            currentWidth = 10;
            currentPen = new Pen(currentColor, currentWidth);
        }

        private void toolStripButtonFill_Click(object sender, EventArgs e)
        {
            drawObject = WhatToDraw.DrawAfrerMouse;
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle (new Rectangle (this.pictureBox1.Location, 
                this.pictureBox1.Image.Size));
            SolidBrush brush = new SolidBrush (currentColor);
            grfCurrentBitmap.FillPath(brush, path);
            pictureBox1.Image = currentBitmap;

        }

        private void toolStripButtonLine_Click(object sender, EventArgs e)
        {
            drawObject = WhatToDraw.DrawCommonLine;
        }

        private void toolStripButtonRectangle_Click(object sender, EventArgs e)
        {
            drawObject = WhatToDraw.DrawEmptyRectangle;
        }

        private void toolStripButtonRectangleFill_Click(object sender, EventArgs e)
        {
            drawObject = WhatToDraw.DrawFillRectangle;
        }

        private void toolStripButtonEllipse_Click(object sender, EventArgs e)
        {
            drawObject = WhatToDraw.DrawEmptyEllipse;
        }

        private void toolStripButtonEllipseFill_Click(object sender, EventArgs e)
        {
            drawObject = WhatToDraw.DrawFillEllipse;
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            this.pictureBox1.Invalidate();
        }

        private void toolStripMenuItemPictureNegative_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < currentBitmap.Width; x++)
            {
                for (int y = 0; y < currentBitmap.Height; y++)
                {
                    Color pixelColor = currentBitmap.GetPixel(x, y);
                    currentBitmap.SetPixel(x, y,
                        Color.FromArgb (255-pixelColor.R,
                                        255 - pixelColor.G,
                                        255 - pixelColor.B));
                }
            }
            this.pictureBox1.Image = currentBitmap;
        }

        private void toolStripComboBoxWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentWidth = (this.toolStripComboBoxWidth.SelectedIndex + 1);
            currentPen = new Pen(currentColor, currentWidth);
        }

        private void toolStripMenuItemStyle_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            switch (item.Text)
            {
                case "Solid":
                    currentPen.DashStyle = DashStyle.Solid;
                    break;
                case "Dash":
                    currentPen.DashStyle = DashStyle.Dash;
                    break;
                case "Dot":
                    currentPen.DashStyle = DashStyle.Dot;
                    break;
                case "DashDot":
                    currentPen.DashStyle = DashStyle.DashDot;
                    break;
                case "DashDotDot":
                    currentPen.DashStyle = DashStyle.DashDotDot;
                    break;
            }
        }

        private void toolStripMenuItemPictureChangeSize_Click(object sender, EventArgs e)
        {
            formSizeImage = new FormSize();
            formSizeImage.WidthValue = currentBitmap.Width;
            formSizeImage.HeightValue = currentBitmap.Height;
            if (formSizeImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Size newSize = new Size(
                        formSizeImage.WidthValue, formSizeImage.HeightValue);
                    Bitmap tempBitmap = new Bitmap(currentBitmap, newSize);
                    currentBitmap.Dispose();
                    grfCurrentBitmap.Dispose();
                    currentBitmap = (Bitmap)tempBitmap.Clone();
                    grfCurrentBitmap = Graphics.FromImage(currentBitmap);
                    this.pictureBox1.Image = currentBitmap;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "MyPaint",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }












    }
}