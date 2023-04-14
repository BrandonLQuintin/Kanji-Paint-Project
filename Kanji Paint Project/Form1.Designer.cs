namespace Kanji_Paint_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TestYourselfButton = new System.Windows.Forms.Button();
            this.rst_btn = new System.Windows.Forms.Button();
            this.btn_kanji = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.TestYourselfButton);
            this.panel1.Controls.Add(this.rst_btn);
            this.panel1.Controls.Add(this.btn_kanji);
            this.panel1.Controls.Add(this.btn_eraser);
            this.panel1.Controls.Add(this.btn_pencil);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 81);
            this.panel1.TabIndex = 0;
            // 
            // TestYourselfButton
            // 
            this.TestYourselfButton.BackColor = System.Drawing.Color.White;
            this.TestYourselfButton.Location = new System.Drawing.Point(517, 12);
            this.TestYourselfButton.Name = "TestYourselfButton";
            this.TestYourselfButton.Size = new System.Drawing.Size(174, 57);
            this.TestYourselfButton.TabIndex = 10;
            this.TestYourselfButton.Text = "Test yourself";
            this.TestYourselfButton.UseVisualStyleBackColor = false;
            this.TestYourselfButton.Click += new System.EventHandler(this.TestYourselfButton_Click);
            // 
            // rst_btn
            // 
            this.rst_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rst_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.rst_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rst_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rst_btn.ForeColor = System.Drawing.Color.Black;
            this.rst_btn.Image = ((System.Drawing.Image)(resources.GetObject("rst_btn.Image")));
            this.rst_btn.Location = new System.Drawing.Point(251, 0);
            this.rst_btn.Name = "rst_btn";
            this.rst_btn.Size = new System.Drawing.Size(75, 78);
            this.rst_btn.TabIndex = 9;
            this.rst_btn.Text = "Clear";
            this.rst_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rst_btn.UseVisualStyleBackColor = false;
            this.rst_btn.Click += new System.EventHandler(this.rst_btn_Click);
            // 
            // btn_kanji
            // 
            this.btn_kanji.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_kanji.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_kanji.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_kanji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kanji.ForeColor = System.Drawing.Color.Black;
            this.btn_kanji.Image = ((System.Drawing.Image)(resources.GetObject("btn_kanji.Image")));
            this.btn_kanji.Location = new System.Drawing.Point(89, 0);
            this.btn_kanji.Name = "btn_kanji";
            this.btn_kanji.Size = new System.Drawing.Size(75, 78);
            this.btn_kanji.TabIndex = 8;
            this.btn_kanji.Text = "Kanji";
            this.btn_kanji.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_kanji.UseVisualStyleBackColor = false;
            this.btn_kanji.Click += new System.EventHandler(this.btn_kanji_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.ForeColor = System.Drawing.Color.Black;
            this.btn_eraser.Image = ((System.Drawing.Image)(resources.GetObject("btn_eraser.Image")));
            this.btn_eraser.Location = new System.Drawing.Point(170, 0);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(75, 78);
            this.btn_eraser.TabIndex = 7;
            this.btn_eraser.Text = "Eraser";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_eraser.UseVisualStyleBackColor = false;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.ForeColor = System.Drawing.Color.Black;
            this.btn_pencil.Image = ((System.Drawing.Image)(resources.GetObject("btn_pencil.Image")));
            this.btn_pencil.Location = new System.Drawing.Point(8, 0);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(75, 78);
            this.btn_pencil.TabIndex = 6;
            this.btn_pencil.Text = "Pencil";
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_pencil.UseVisualStyleBackColor = false;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(390, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(90, 57);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save as jpg";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 81);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(872, 442);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 523);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quintin Kanji Program";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button SaveButton;
        private PictureBox pic;
        private Button btn_kanji;
        private Button btn_eraser;
        private Button btn_pencil;
        private Button rst_btn;
        private Button TestYourselfButton;
    }
}