namespace RF_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonBold = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonItalic = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonUnderline = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonStrike = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonFSize = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonFColor = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonFont = new MaterialSkin.Controls.MaterialRaisedButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonRight = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonCenter = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonLeft = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton7 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton8 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton9 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton10 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton11 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lp_off = new MaterialSkin.Controls.MaterialRadioButton();
            this.lp_on = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRaisedButton12 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // buttonBold
            // 
            this.buttonBold.Depth = 0;
            this.buttonBold.Font = new System.Drawing.Font("Open Sans Extrabold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBold.Location = new System.Drawing.Point(12, 68);
            this.buttonBold.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBold.Name = "buttonBold";
            this.buttonBold.Primary = true;
            this.buttonBold.Size = new System.Drawing.Size(27, 25);
            this.buttonBold.TabIndex = 0;
            this.buttonBold.Text = "B";
            this.buttonBold.UseVisualStyleBackColor = true;
            this.buttonBold.Click += new System.EventHandler(this.buttonBold_Click);
            // 
            // buttonItalic
            // 
            this.buttonItalic.Depth = 0;
            this.buttonItalic.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItalic.Location = new System.Drawing.Point(45, 68);
            this.buttonItalic.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonItalic.Name = "buttonItalic";
            this.buttonItalic.Primary = true;
            this.buttonItalic.Size = new System.Drawing.Size(27, 25);
            this.buttonItalic.TabIndex = 1;
            this.buttonItalic.Text = "I";
            this.buttonItalic.UseVisualStyleBackColor = true;
            this.buttonItalic.Click += new System.EventHandler(this.buttonItalic_Click);
            // 
            // buttonUnderline
            // 
            this.buttonUnderline.Depth = 0;
            this.buttonUnderline.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnderline.Location = new System.Drawing.Point(78, 68);
            this.buttonUnderline.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonUnderline.Name = "buttonUnderline";
            this.buttonUnderline.Primary = true;
            this.buttonUnderline.Size = new System.Drawing.Size(27, 25);
            this.buttonUnderline.TabIndex = 2;
            this.buttonUnderline.Text = "U";
            this.buttonUnderline.UseVisualStyleBackColor = true;
            this.buttonUnderline.Click += new System.EventHandler(this.buttonUnderline_Click);
            // 
            // buttonStrike
            // 
            this.buttonStrike.Depth = 0;
            this.buttonStrike.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStrike.Location = new System.Drawing.Point(111, 68);
            this.buttonStrike.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonStrike.Name = "buttonStrike";
            this.buttonStrike.Primary = true;
            this.buttonStrike.Size = new System.Drawing.Size(27, 25);
            this.buttonStrike.TabIndex = 3;
            this.buttonStrike.Text = "S";
            this.buttonStrike.UseVisualStyleBackColor = true;
            this.buttonStrike.Click += new System.EventHandler(this.buttonStrike_Click);
            // 
            // buttonFSize
            // 
            this.buttonFSize.Depth = 0;
            this.buttonFSize.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFSize.Location = new System.Drawing.Point(202, 69);
            this.buttonFSize.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonFSize.Name = "buttonFSize";
            this.buttonFSize.Primary = true;
            this.buttonFSize.Size = new System.Drawing.Size(78, 25);
            this.buttonFSize.TabIndex = 6;
            this.buttonFSize.Text = "Font Size";
            this.buttonFSize.UseVisualStyleBackColor = true;
            this.buttonFSize.Click += new System.EventHandler(this.buttonFSize_Click);
            // 
            // buttonFColor
            // 
            this.buttonFColor.Depth = 0;
            this.buttonFColor.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFColor.Location = new System.Drawing.Point(286, 69);
            this.buttonFColor.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonFColor.Name = "buttonFColor";
            this.buttonFColor.Primary = true;
            this.buttonFColor.Size = new System.Drawing.Size(94, 25);
            this.buttonFColor.TabIndex = 7;
            this.buttonFColor.Text = "Font Color";
            this.buttonFColor.UseVisualStyleBackColor = true;
            this.buttonFColor.Click += new System.EventHandler(this.buttonFColor_Click);
            // 
            // buttonFont
            // 
            this.buttonFont.Depth = 0;
            this.buttonFont.Font = new System.Drawing.Font("Open Sans Extrabold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFont.Location = new System.Drawing.Point(144, 68);
            this.buttonFont.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Primary = true;
            this.buttonFont.Size = new System.Drawing.Size(52, 25);
            this.buttonFont.TabIndex = 5;
            this.buttonFont.Text = "Font";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(12, 130);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(872, 382);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // buttonRight
            // 
            this.buttonRight.Depth = 0;
            this.buttonRight.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRight.Location = new System.Drawing.Point(505, 70);
            this.buttonRight.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Primary = true;
            this.buttonRight.Size = new System.Drawing.Size(50, 25);
            this.buttonRight.TabIndex = 10;
            this.buttonRight.Text = "Right";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonCenter
            // 
            this.buttonCenter.Depth = 0;
            this.buttonCenter.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCenter.Location = new System.Drawing.Point(434, 70);
            this.buttonCenter.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonCenter.Name = "buttonCenter";
            this.buttonCenter.Primary = true;
            this.buttonCenter.Size = new System.Drawing.Size(65, 25);
            this.buttonCenter.TabIndex = 9;
            this.buttonCenter.Text = "Center";
            this.buttonCenter.UseVisualStyleBackColor = true;
            this.buttonCenter.Click += new System.EventHandler(this.buttonCenter_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Depth = 0;
            this.buttonLeft.Font = new System.Drawing.Font("Open Sans Extrabold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeft.Location = new System.Drawing.Point(386, 69);
            this.buttonLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Primary = true;
            this.buttonLeft.Size = new System.Drawing.Size(42, 25);
            this.buttonLeft.TabIndex = 8;
            this.buttonLeft.Text = "Left";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton1.Location = new System.Drawing.Point(642, 70);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(73, 25);
            this.materialRaisedButton1.TabIndex = 12;
            this.materialRaisedButton1.Text = "Num List";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton2.Location = new System.Drawing.Point(561, 70);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(75, 25);
            this.materialRaisedButton2.TabIndex = 11;
            this.materialRaisedButton2.Text = "Bull List";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton3.Location = new System.Drawing.Point(721, 70);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(73, 25);
            this.materialRaisedButton3.TabIndex = 13;
            this.materialRaisedButton3.Text = "New Line";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton4.Location = new System.Drawing.Point(800, 70);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(43, 25);
            this.materialRaisedButton4.TabIndex = 14;
            this.materialRaisedButton4.Text = "IMG";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            this.materialRaisedButton4.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // materialRaisedButton5
            // 
            this.materialRaisedButton5.Depth = 0;
            this.materialRaisedButton5.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton5.Location = new System.Drawing.Point(849, 70);
            this.materialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton5.Name = "materialRaisedButton5";
            this.materialRaisedButton5.Primary = true;
            this.materialRaisedButton5.Size = new System.Drawing.Size(35, 25);
            this.materialRaisedButton5.TabIndex = 15;
            this.materialRaisedButton5.Text = "VID";
            this.materialRaisedButton5.UseVisualStyleBackColor = true;
            this.materialRaisedButton5.Click += new System.EventHandler(this.materialRaisedButton5_Click);
            // 
            // materialRaisedButton6
            // 
            this.materialRaisedButton6.Depth = 0;
            this.materialRaisedButton6.Font = new System.Drawing.Font("Open Sans Extrabold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton6.Location = new System.Drawing.Point(12, 99);
            this.materialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton6.Name = "materialRaisedButton6";
            this.materialRaisedButton6.Primary = true;
            this.materialRaisedButton6.Size = new System.Drawing.Size(40, 25);
            this.materialRaisedButton6.TabIndex = 16;
            this.materialRaisedButton6.Text = "Link";
            this.materialRaisedButton6.UseVisualStyleBackColor = true;
            this.materialRaisedButton6.Click += new System.EventHandler(this.materialRaisedButton6_Click);
            // 
            // materialRaisedButton7
            // 
            this.materialRaisedButton7.Depth = 0;
            this.materialRaisedButton7.Font = new System.Drawing.Font("Open Sans Extrabold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton7.Location = new System.Drawing.Point(58, 99);
            this.materialRaisedButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton7.Name = "materialRaisedButton7";
            this.materialRaisedButton7.Primary = true;
            this.materialRaisedButton7.Size = new System.Drawing.Size(47, 25);
            this.materialRaisedButton7.TabIndex = 17;
            this.materialRaisedButton7.Text = "Code";
            this.materialRaisedButton7.UseVisualStyleBackColor = true;
            this.materialRaisedButton7.Click += new System.EventHandler(this.materialRaisedButton7_Click);
            // 
            // materialRaisedButton8
            // 
            this.materialRaisedButton8.Depth = 0;
            this.materialRaisedButton8.Font = new System.Drawing.Font("Open Sans Extrabold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton8.Location = new System.Drawing.Point(111, 99);
            this.materialRaisedButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton8.Name = "materialRaisedButton8";
            this.materialRaisedButton8.Primary = true;
            this.materialRaisedButton8.Size = new System.Drawing.Size(74, 25);
            this.materialRaisedButton8.TabIndex = 18;
            this.materialRaisedButton8.Text = "PHP Code";
            this.materialRaisedButton8.UseVisualStyleBackColor = true;
            this.materialRaisedButton8.Click += new System.EventHandler(this.materialRaisedButton8_Click);
            // 
            // materialRaisedButton9
            // 
            this.materialRaisedButton9.Depth = 0;
            this.materialRaisedButton9.Font = new System.Drawing.Font("Open Sans Extrabold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton9.Location = new System.Drawing.Point(191, 99);
            this.materialRaisedButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton9.Name = "materialRaisedButton9";
            this.materialRaisedButton9.Primary = true;
            this.materialRaisedButton9.Size = new System.Drawing.Size(55, 25);
            this.materialRaisedButton9.TabIndex = 19;
            this.materialRaisedButton9.Text = "Quote";
            this.materialRaisedButton9.UseVisualStyleBackColor = true;
            this.materialRaisedButton9.Click += new System.EventHandler(this.materialRaisedButton9_Click);
            // 
            // materialRaisedButton10
            // 
            this.materialRaisedButton10.Depth = 0;
            this.materialRaisedButton10.Font = new System.Drawing.Font("Open Sans Extrabold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton10.Location = new System.Drawing.Point(747, 99);
            this.materialRaisedButton10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton10.Name = "materialRaisedButton10";
            this.materialRaisedButton10.Primary = true;
            this.materialRaisedButton10.Size = new System.Drawing.Size(84, 25);
            this.materialRaisedButton10.TabIndex = 20;
            this.materialRaisedButton10.Text = "Copy Code";
            this.materialRaisedButton10.UseVisualStyleBackColor = true;
            this.materialRaisedButton10.Click += new System.EventHandler(this.materialRaisedButton10_Click);
            // 
            // materialRaisedButton11
            // 
            this.materialRaisedButton11.Depth = 0;
            this.materialRaisedButton11.Font = new System.Drawing.Font("Open Sans Extrabold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton11.Location = new System.Drawing.Point(677, 99);
            this.materialRaisedButton11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton11.Name = "materialRaisedButton11";
            this.materialRaisedButton11.Primary = true;
            this.materialRaisedButton11.Size = new System.Drawing.Size(64, 25);
            this.materialRaisedButton11.TabIndex = 21;
            this.materialRaisedButton11.Text = "Preview";
            this.materialRaisedButton11.UseVisualStyleBackColor = true;
            this.materialRaisedButton11.Click += new System.EventHandler(this.materialRaisedButton11_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(485, 101);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(92, 19);
            this.materialLabel1.TabIndex = 22;
            this.materialLabel1.Text = "Live Preview";
            // 
            // lp_off
            // 
            this.lp_off.AutoSize = true;
            this.lp_off.Depth = 0;
            this.lp_off.Font = new System.Drawing.Font("Roboto", 10F);
            this.lp_off.Location = new System.Drawing.Point(580, 96);
            this.lp_off.Margin = new System.Windows.Forms.Padding(0);
            this.lp_off.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lp_off.MouseState = MaterialSkin.MouseState.HOVER;
            this.lp_off.Name = "lp_off";
            this.lp_off.Ripple = true;
            this.lp_off.Size = new System.Drawing.Size(48, 30);
            this.lp_off.TabIndex = 23;
            this.lp_off.Text = "Off";
            this.lp_off.UseVisualStyleBackColor = true;
            // 
            // lp_on
            // 
            this.lp_on.AutoSize = true;
            this.lp_on.Checked = true;
            this.lp_on.Depth = 0;
            this.lp_on.Font = new System.Drawing.Font("Roboto", 10F);
            this.lp_on.Location = new System.Drawing.Point(628, 96);
            this.lp_on.Margin = new System.Windows.Forms.Padding(0);
            this.lp_on.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lp_on.MouseState = MaterialSkin.MouseState.HOVER;
            this.lp_on.Name = "lp_on";
            this.lp_on.Ripple = true;
            this.lp_on.Size = new System.Drawing.Size(46, 30);
            this.lp_on.TabIndex = 24;
            this.lp_on.TabStop = true;
            this.lp_on.Text = "On";
            this.lp_on.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton12
            // 
            this.materialRaisedButton12.Depth = 0;
            this.materialRaisedButton12.Font = new System.Drawing.Font("Open Sans Extrabold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton12.Location = new System.Drawing.Point(835, 99);
            this.materialRaisedButton12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton12.Name = "materialRaisedButton12";
            this.materialRaisedButton12.Primary = true;
            this.materialRaisedButton12.Size = new System.Drawing.Size(49, 25);
            this.materialRaisedButton12.TabIndex = 25;
            this.materialRaisedButton12.Text = "Save";
            this.materialRaisedButton12.UseVisualStyleBackColor = true;
            this.materialRaisedButton12.Click += new System.EventHandler(this.materialRaisedButton12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 524);
            this.Controls.Add(this.materialRaisedButton12);
            this.Controls.Add(this.lp_on);
            this.Controls.Add(this.lp_off);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialRaisedButton11);
            this.Controls.Add(this.materialRaisedButton10);
            this.Controls.Add(this.materialRaisedButton9);
            this.Controls.Add(this.materialRaisedButton8);
            this.Controls.Add(this.materialRaisedButton7);
            this.Controls.Add(this.materialRaisedButton6);
            this.Controls.Add(this.materialRaisedButton5);
            this.Controls.Add(this.materialRaisedButton4);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonCenter);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonFColor);
            this.Controls.Add(this.buttonFSize);
            this.Controls.Add(this.buttonFont);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonStrike);
            this.Controls.Add(this.buttonUnderline);
            this.Controls.Add(this.buttonItalic);
            this.Controls.Add(this.buttonBold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(896, 462);
            this.Name = "Form1";
            this.Text = "External MyBB Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton buttonBold;
        private MaterialSkin.Controls.MaterialRaisedButton buttonItalic;
        private MaterialSkin.Controls.MaterialRaisedButton buttonUnderline;
        private MaterialSkin.Controls.MaterialRaisedButton buttonStrike;
        private MaterialSkin.Controls.MaterialRaisedButton buttonFSize;
        private MaterialSkin.Controls.MaterialRaisedButton buttonFColor;
        private MaterialSkin.Controls.MaterialRaisedButton buttonFont;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private MaterialSkin.Controls.MaterialRaisedButton buttonRight;
        private MaterialSkin.Controls.MaterialRaisedButton buttonCenter;
        private MaterialSkin.Controls.MaterialRaisedButton buttonLeft;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton5;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton6;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton7;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton8;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton9;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton10;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton11;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRadioButton lp_off;
        private MaterialSkin.Controls.MaterialRadioButton lp_on;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton12;
    }
}

