namespace MyPaint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileOpen;
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileSave;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPictureRotate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPictureRotate90 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPictureRotate180 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPictureRotate270 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPictureNegative = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPictureChangeSize = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBrush = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFill = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonColors = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButtonStyle = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemStyleSolid = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStyleDash = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStyleDot = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStyleDahDot = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStyleDashDotDot = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxWidth = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelResolurtion = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStripButtonRectangle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRectangleFill = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEllipse = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEllipseFill = new System.Windows.Forms.ToolStripButton();
            toolStripMenuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenuItemFileOpen
            // 
            toolStripMenuItemFileOpen.Name = "toolStripMenuItemFileOpen";
            toolStripMenuItemFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            toolStripMenuItemFileOpen.Size = new System.Drawing.Size(178, 22);
            toolStripMenuItemFileOpen.Text = "Открыть";
            toolStripMenuItemFileOpen.Click += new System.EventHandler(this.toolStripMenuItemFileOpen_Click);
            // 
            // toolStripMenuItemFileSave
            // 
            toolStripMenuItemFileSave.Name = "toolStripMenuItemFileSave";
            toolStripMenuItemFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            toolStripMenuItemFileSave.Size = new System.Drawing.Size(178, 22);
            toolStripMenuItemFileSave.Text = "Сохранить";
            toolStripMenuItemFileSave.Click += new System.EventHandler(this.toolStripMenuItemFileSave_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemPicture});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.AutoSize = false;
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFileCreate,
            toolStripMenuItemFileOpen,
            toolStripMenuItemFileSave,
            this.toolStripMenuItemFileSaveAs,
            this.toolStripSeparator1,
            this.toolStripMenuItemFileExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(45, 20);
            this.toolStripMenuItemFile.Text = "Файл";
            // 
            // toolStripMenuItemFileCreate
            // 
            this.toolStripMenuItemFileCreate.Name = "toolStripMenuItemFileCreate";
            this.toolStripMenuItemFileCreate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItemFileCreate.Size = new System.Drawing.Size(178, 22);
            this.toolStripMenuItemFileCreate.Text = "Создать";
            this.toolStripMenuItemFileCreate.Click += new System.EventHandler(this.toolStripMenuItemFileCreate_Click);
            // 
            // toolStripMenuItemFileSaveAs
            // 
            this.toolStripMenuItemFileSaveAs.Name = "toolStripMenuItemFileSaveAs";
            this.toolStripMenuItemFileSaveAs.Size = new System.Drawing.Size(178, 22);
            this.toolStripMenuItemFileSaveAs.Text = "Сохранить как...";
            this.toolStripMenuItemFileSaveAs.Click += new System.EventHandler(this.toolStripMenuItemFileSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // toolStripMenuItemFileExit
            // 
            this.toolStripMenuItemFileExit.Name = "toolStripMenuItemFileExit";
            this.toolStripMenuItemFileExit.Size = new System.Drawing.Size(178, 22);
            this.toolStripMenuItemFileExit.Text = "Выход";
            this.toolStripMenuItemFileExit.Click += new System.EventHandler(this.toolStripMenuItemFileExit_Click);
            // 
            // toolStripMenuItemPicture
            // 
            this.toolStripMenuItemPicture.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPictureRotate,
            this.toolStripMenuItemPictureNegative,
            this.toolStripMenuItemPictureChangeSize});
            this.toolStripMenuItemPicture.Name = "toolStripMenuItemPicture";
            this.toolStripMenuItemPicture.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItemPicture.Text = "Рисунок";
            // 
            // toolStripMenuItemPictureRotate
            // 
            this.toolStripMenuItemPictureRotate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPictureRotate90,
            this.toolStripMenuItemPictureRotate180,
            this.toolStripMenuItemPictureRotate270});
            this.toolStripMenuItemPictureRotate.Name = "toolStripMenuItemPictureRotate";
            this.toolStripMenuItemPictureRotate.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItemPictureRotate.Text = "Повернуть";
            // 
            // toolStripMenuItemPictureRotate90
            // 
            this.toolStripMenuItemPictureRotate90.Name = "toolStripMenuItemPictureRotate90";
            this.toolStripMenuItemPictureRotate90.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItemPictureRotate90.Text = "90";
            this.toolStripMenuItemPictureRotate90.Click += new System.EventHandler(this.toolStripMenuItemPictureRotate90_Click);
            // 
            // toolStripMenuItemPictureRotate180
            // 
            this.toolStripMenuItemPictureRotate180.Name = "toolStripMenuItemPictureRotate180";
            this.toolStripMenuItemPictureRotate180.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItemPictureRotate180.Text = "180";
            this.toolStripMenuItemPictureRotate180.Click += new System.EventHandler(this.toolStripMenuItemPictureRotate180_Click);
            // 
            // toolStripMenuItemPictureRotate270
            // 
            this.toolStripMenuItemPictureRotate270.Name = "toolStripMenuItemPictureRotate270";
            this.toolStripMenuItemPictureRotate270.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItemPictureRotate270.Text = "270";
            this.toolStripMenuItemPictureRotate270.Click += new System.EventHandler(this.toolStripMenuItemPictureRotate270_Click);
            // 
            // toolStripMenuItemPictureNegative
            // 
            this.toolStripMenuItemPictureNegative.Name = "toolStripMenuItemPictureNegative";
            this.toolStripMenuItemPictureNegative.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItemPictureNegative.Text = "Обратить цвета";
            this.toolStripMenuItemPictureNegative.Click += new System.EventHandler(this.toolStripMenuItemPictureNegative_Click);
            // 
            // toolStripMenuItemPictureChangeSize
            // 
            this.toolStripMenuItemPictureChangeSize.Name = "toolStripMenuItemPictureChangeSize";
            this.toolStripMenuItemPictureChangeSize.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuItemPictureChangeSize.Text = "Изменить размер";
            this.toolStripMenuItemPictureChangeSize.Click += new System.EventHandler(this.toolStripMenuItemPictureChangeSize_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Безымянный";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPen,
            this.toolStripButtonBrush,
            this.toolStripButtonFill,
            this.toolStripButtonColors,
            this.toolStripButtonLine,
            this.toolStripButtonRectangle,
            this.toolStripButtonRectangleFill,
            this.toolStripButtonEllipse,
            this.toolStripButtonEllipseFill,
            this.toolStripDropDownButtonStyle,
            this.toolStripComboBoxWidth});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(49, 351);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonPen
            // 
            this.toolStripButtonPen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPen.Image = global::MyPaint.Properties.Resources.BitmapPen;
            this.toolStripButtonPen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPen.Margin = new System.Windows.Forms.Padding(3, 10, 0, 2);
            this.toolStripButtonPen.Name = "toolStripButtonPen";
            this.toolStripButtonPen.Size = new System.Drawing.Size(44, 20);
            this.toolStripButtonPen.Text = "Карандаш";
            this.toolStripButtonPen.Click += new System.EventHandler(this.toolStripButtonPen_Click);
            // 
            // toolStripButtonBrush
            // 
            this.toolStripButtonBrush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBrush.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBrush.Image")));
            this.toolStripButtonBrush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBrush.Margin = new System.Windows.Forms.Padding(3, 5, 0, 2);
            this.toolStripButtonBrush.Name = "toolStripButtonBrush";
            this.toolStripButtonBrush.Size = new System.Drawing.Size(44, 20);
            this.toolStripButtonBrush.Text = "Кисть";
            this.toolStripButtonBrush.Click += new System.EventHandler(this.toolStripButtonBrush_Click);
            // 
            // toolStripButtonFill
            // 
            this.toolStripButtonFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFill.Image = global::MyPaint.Properties.Resources.BitmapFill;
            this.toolStripButtonFill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFill.Margin = new System.Windows.Forms.Padding(3, 5, 0, 2);
            this.toolStripButtonFill.Name = "toolStripButtonFill";
            this.toolStripButtonFill.Size = new System.Drawing.Size(44, 20);
            this.toolStripButtonFill.Text = "Заливка";
            this.toolStripButtonFill.Click += new System.EventHandler(this.toolStripButtonFill_Click);
            // 
            // toolStripButtonColors
            // 
            this.toolStripButtonColors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonColors.Image = global::MyPaint.Properties.Resources.BitmapColors;
            this.toolStripButtonColors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColors.Margin = new System.Windows.Forms.Padding(3, 5, 0, 2);
            this.toolStripButtonColors.Name = "toolStripButtonColors";
            this.toolStripButtonColors.Size = new System.Drawing.Size(44, 20);
            this.toolStripButtonColors.Text = "Цвета";
            this.toolStripButtonColors.Click += new System.EventHandler(this.toolStripButtonColors_Click);
            // 
            // toolStripButtonLine
            // 
            this.toolStripButtonLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLine.Image = global::MyPaint.Properties.Resources.BitmapLine;
            this.toolStripButtonLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLine.Margin = new System.Windows.Forms.Padding(3, 5, 0, 2);
            this.toolStripButtonLine.Name = "toolStripButtonLine";
            this.toolStripButtonLine.Size = new System.Drawing.Size(44, 20);
            this.toolStripButtonLine.Text = "Линия";
            this.toolStripButtonLine.Click += new System.EventHandler(this.toolStripButtonLine_Click);
            // 
            // toolStripDropDownButtonStyle
            // 
            this.toolStripDropDownButtonStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemStyleSolid,
            this.toolStripMenuItemStyleDash,
            this.toolStripMenuItemStyleDot,
            this.toolStripMenuItemStyleDahDot,
            this.toolStripMenuItemStyleDashDotDot});
            this.toolStripDropDownButtonStyle.Image = global::MyPaint.Properties.Resources.BitmapStyle;
            this.toolStripDropDownButtonStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonStyle.Margin = new System.Windows.Forms.Padding(10, 5, 0, 2);
            this.toolStripDropDownButtonStyle.Name = "toolStripDropDownButtonStyle";
            this.toolStripDropDownButtonStyle.Size = new System.Drawing.Size(37, 20);
            this.toolStripDropDownButtonStyle.Text = "Стиль";
            // 
            // toolStripMenuItemStyleSolid
            // 
            this.toolStripMenuItemStyleSolid.Image = global::MyPaint.Properties.Resources.BitmapStyleSolid;
            this.toolStripMenuItemStyleSolid.Name = "toolStripMenuItemStyleSolid";
            this.toolStripMenuItemStyleSolid.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItemStyleSolid.Text = "Solid";
            this.toolStripMenuItemStyleSolid.Click += new System.EventHandler(this.toolStripMenuItemStyle_Click);
            // 
            // toolStripMenuItemStyleDash
            // 
            this.toolStripMenuItemStyleDash.Image = global::MyPaint.Properties.Resources.BitmapStyleDash;
            this.toolStripMenuItemStyleDash.Name = "toolStripMenuItemStyleDash";
            this.toolStripMenuItemStyleDash.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItemStyleDash.Text = "Dash";
            this.toolStripMenuItemStyleDash.Click += new System.EventHandler(this.toolStripMenuItemStyle_Click);
            // 
            // toolStripMenuItemStyleDot
            // 
            this.toolStripMenuItemStyleDot.Image = global::MyPaint.Properties.Resources.BitmapStyleDot;
            this.toolStripMenuItemStyleDot.Name = "toolStripMenuItemStyleDot";
            this.toolStripMenuItemStyleDot.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItemStyleDot.Text = "Dot";
            this.toolStripMenuItemStyleDot.Click += new System.EventHandler(this.toolStripMenuItemStyle_Click);
            // 
            // toolStripMenuItemStyleDahDot
            // 
            this.toolStripMenuItemStyleDahDot.Image = global::MyPaint.Properties.Resources.BitmapStyleDashDot;
            this.toolStripMenuItemStyleDahDot.Name = "toolStripMenuItemStyleDahDot";
            this.toolStripMenuItemStyleDahDot.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItemStyleDahDot.Text = "DashDot";
            this.toolStripMenuItemStyleDahDot.Click += new System.EventHandler(this.toolStripMenuItemStyle_Click);
            // 
            // toolStripMenuItemStyleDashDotDot
            // 
            this.toolStripMenuItemStyleDashDotDot.Image = global::MyPaint.Properties.Resources.BitmapStyleDashDotDot;
            this.toolStripMenuItemStyleDashDotDot.Name = "toolStripMenuItemStyleDashDotDot";
            this.toolStripMenuItemStyleDashDotDot.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItemStyleDashDotDot.Text = "DashDotDot";
            this.toolStripMenuItemStyleDashDotDot.Click += new System.EventHandler(this.toolStripMenuItemStyle_Click);
            // 
            // toolStripComboBoxWidth
            // 
            this.toolStripComboBoxWidth.AutoSize = false;
            this.toolStripComboBoxWidth.AutoToolTip = true;
            this.toolStripComboBoxWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.toolStripComboBoxWidth.Margin = new System.Windows.Forms.Padding(3, 5, 1, 0);
            this.toolStripComboBoxWidth.Name = "toolStripComboBoxWidth";
            this.toolStripComboBoxWidth.Size = new System.Drawing.Size(30, 21);
            this.toolStripComboBoxWidth.ToolTipText = "Ширина";
            this.toolStripComboBoxWidth.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxWidth_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelName,
            this.toolStripStatusLabelSize,
            this.toolStripStatusLabelResolurtion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 375);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(683, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Paint += new System.Windows.Forms.PaintEventHandler(this.statusStrip1_Paint);
            // 
            // toolStripStatusLabelName
            // 
            this.toolStripStatusLabelName.Name = "toolStripStatusLabelName";
            this.toolStripStatusLabelName.Size = new System.Drawing.Size(222, 17);
            this.toolStripStatusLabelName.Spring = true;
            this.toolStripStatusLabelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelSize
            // 
            this.toolStripStatusLabelSize.Name = "toolStripStatusLabelSize";
            this.toolStripStatusLabelSize.Size = new System.Drawing.Size(222, 17);
            this.toolStripStatusLabelSize.Spring = true;
            this.toolStripStatusLabelSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelResolurtion
            // 
            this.toolStripStatusLabelResolurtion.Name = "toolStripStatusLabelResolurtion";
            this.toolStripStatusLabelResolurtion.Size = new System.Drawing.Size(222, 17);
            this.toolStripStatusLabelResolurtion.Spring = true;
            this.toolStripStatusLabelResolurtion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(49, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 351);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // toolStripButtonRectangle
            // 
            this.toolStripButtonRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRectangle.Image = global::MyPaint.Properties.Resources.BitmapRectangle;
            this.toolStripButtonRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRectangle.Margin = new System.Windows.Forms.Padding(3, 5, 0, 2);
            this.toolStripButtonRectangle.Name = "toolStripButtonRectangle";
            this.toolStripButtonRectangle.Size = new System.Drawing.Size(44, 20);
            this.toolStripButtonRectangle.Text = "Прямоугольник";
            this.toolStripButtonRectangle.Click += new System.EventHandler(this.toolStripButtonRectangle_Click);
            // 
            // toolStripButtonRectangleFill
            // 
            this.toolStripButtonRectangleFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRectangleFill.Image = global::MyPaint.Properties.Resources.BitmapRectangleFill;
            this.toolStripButtonRectangleFill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRectangleFill.Margin = new System.Windows.Forms.Padding(3, 5, 0, 2);
            this.toolStripButtonRectangleFill.Name = "toolStripButtonRectangleFill";
            this.toolStripButtonRectangleFill.Size = new System.Drawing.Size(44, 20);
            this.toolStripButtonRectangleFill.Text = "Заполненный прямоугольник";
            this.toolStripButtonRectangleFill.Click += new System.EventHandler(this.toolStripButtonRectangleFill_Click);
            // 
            // toolStripButtonEllipse
            // 
            this.toolStripButtonEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEllipse.Image = global::MyPaint.Properties.Resources.BitmapEllipse;
            this.toolStripButtonEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEllipse.Margin = new System.Windows.Forms.Padding(3, 5, 0, 2);
            this.toolStripButtonEllipse.Name = "toolStripButtonEllipse";
            this.toolStripButtonEllipse.Size = new System.Drawing.Size(44, 20);
            this.toolStripButtonEllipse.Text = "Окружность";
            this.toolStripButtonEllipse.Click += new System.EventHandler(this.toolStripButtonEllipse_Click);
            // 
            // toolStripButtonEllipseFill
            // 
            this.toolStripButtonEllipseFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEllipseFill.Image = global::MyPaint.Properties.Resources.BitmapEllipseFill;
            this.toolStripButtonEllipseFill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEllipseFill.Margin = new System.Windows.Forms.Padding(3, 5, 0, 2);
            this.toolStripButtonEllipseFill.Name = "toolStripButtonEllipseFill";
            this.toolStripButtonEllipseFill.Size = new System.Drawing.Size(44, 20);
            this.toolStripButtonEllipseFill.Text = "Заполненная окружность";
            this.toolStripButtonEllipseFill.Click += new System.EventHandler(this.toolStripButtonEllipseFill_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(683, 397);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.Text = "MyPaint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileCreate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileExit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSize;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelResolurtion;
        private System.Windows.Forms.ToolStripButton toolStripButtonPen;
        private System.Windows.Forms.ToolStripButton toolStripButtonBrush;
        private System.Windows.Forms.ToolStripButton toolStripButtonFill;
        private System.Windows.Forms.ToolStripButton toolStripButtonColors;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPicture;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPictureRotate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPictureRotate90;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPictureRotate180;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPictureRotate270;
        private System.Windows.Forms.ToolStripButton toolStripButtonLine;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPictureNegative;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxWidth;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonStyle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStyleSolid;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStyleDash;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStyleDot;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStyleDahDot;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStyleDashDotDot;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPictureChangeSize;
        private System.Windows.Forms.ToolStripButton toolStripButtonRectangle;
        private System.Windows.Forms.ToolStripButton toolStripButtonRectangleFill;
        private System.Windows.Forms.ToolStripButton toolStripButtonEllipse;
        private System.Windows.Forms.ToolStripButton toolStripButtonEllipseFill;

    }
}

