using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class FormSize : Form
    {
        public FormSize()
        {
            InitializeComponent();
        }

        public int WidthValue
        {
            set { 
                this.textBoxWidth.Text = value.ToString(); 
            }
            get 
            { 
                int returnValue;
                try {
                returnValue = Int32.Parse (this.textBoxWidth.Text);
                }
                catch (Exception ex)
                {
                    throw new Exception (ex.Message);
                }
                return returnValue;
            }
        }

        public int HeightValue
        {
            set
            {
                this.textBoxHeight.Text = value.ToString();
            }
            get
            {
                int returnValue;
                try
                {
                    returnValue = Int32.Parse(this.textBoxHeight.Text);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return returnValue;
            }
        }
    }
}