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
            panel1 = new Panel();
            openKanjiBtn = new Button();
            kanjiDesktopSaveBtn = new Button();
            TestYourselfButton = new Button();
            rst_btn = new Button();
            btn_kanji = new Button();
            btn_eraser = new Button();
            btn_pencil = new Button();
            SaveButton = new Button();
            pic = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(openKanjiBtn);
            panel1.Controls.Add(kanjiDesktopSaveBtn);
            panel1.Controls.Add(TestYourselfButton);
            panel1.Controls.Add(rst_btn);
            panel1.Controls.Add(btn_kanji);
            panel1.Controls.Add(btn_eraser);
            panel1.Controls.Add(btn_pencil);
            panel1.Controls.Add(SaveButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 101);
            panel1.TabIndex = 0;
            // 
            // openKanjiBtn
            // 
            openKanjiBtn.BackColor = Color.White;
            openKanjiBtn.Location = new Point(745, 15);
            openKanjiBtn.Margin = new Padding(4);
            openKanjiBtn.Name = "openKanjiBtn";
            openKanjiBtn.Size = new Size(105, 71);
            openKanjiBtn.TabIndex = 12;
            openKanjiBtn.Text = "Open Kanji Sets";
            openKanjiBtn.UseVisualStyleBackColor = false;
            openKanjiBtn.Click += button1_Click_1;
            // 
            // kanjiDesktopSaveBtn
            // 
            kanjiDesktopSaveBtn.BackColor = Color.White;
            kanjiDesktopSaveBtn.Location = new Point(632, 15);
            kanjiDesktopSaveBtn.Margin = new Padding(4);
            kanjiDesktopSaveBtn.Name = "kanjiDesktopSaveBtn";
            kanjiDesktopSaveBtn.Size = new Size(105, 71);
            kanjiDesktopSaveBtn.TabIndex = 11;
            kanjiDesktopSaveBtn.Text = "Save Kanji to Desktop";
            kanjiDesktopSaveBtn.UseVisualStyleBackColor = false;
            kanjiDesktopSaveBtn.Click += kanjiDesktopSaveBtn_Click;
            // 
            // TestYourselfButton
            // 
            TestYourselfButton.BackColor = Color.White;
            TestYourselfButton.Location = new Point(502, 0);
            TestYourselfButton.Margin = new Padding(4);
            TestYourselfButton.Name = "TestYourselfButton";
            TestYourselfButton.Size = new Size(122, 101);
            TestYourselfButton.TabIndex = 10;
            TestYourselfButton.Text = "Test yourself";
            TestYourselfButton.UseVisualStyleBackColor = false;
            TestYourselfButton.Click += TestYourselfButton_Click;
            // 
            // rst_btn
            // 
            rst_btn.BackColor = SystemColors.ControlLight;
            rst_btn.FlatAppearance.MouseDownBackColor = Color.Maroon;
            rst_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            rst_btn.FlatStyle = FlatStyle.Flat;
            rst_btn.ForeColor = Color.Black;
            rst_btn.Image = (Image)resources.GetObject("rst_btn.Image");
            rst_btn.Location = new Point(293, 0);
            rst_btn.Margin = new Padding(4);
            rst_btn.Name = "rst_btn";
            rst_btn.Size = new Size(88, 98);
            rst_btn.TabIndex = 9;
            rst_btn.Text = "Clear";
            rst_btn.TextAlign = ContentAlignment.TopCenter;
            rst_btn.UseVisualStyleBackColor = false;
            rst_btn.Click += rst_btn_Click;
            // 
            // btn_kanji
            // 
            btn_kanji.BackColor = SystemColors.ControlLight;
            btn_kanji.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_kanji.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_kanji.FlatStyle = FlatStyle.Flat;
            btn_kanji.ForeColor = Color.Black;
            btn_kanji.Image = (Image)resources.GetObject("btn_kanji.Image");
            btn_kanji.Location = new Point(104, 0);
            btn_kanji.Margin = new Padding(4);
            btn_kanji.Name = "btn_kanji";
            btn_kanji.Size = new Size(88, 98);
            btn_kanji.TabIndex = 8;
            btn_kanji.Text = "Kanji";
            btn_kanji.TextAlign = ContentAlignment.TopCenter;
            btn_kanji.UseVisualStyleBackColor = false;
            btn_kanji.Click += btn_kanji_Click;
            // 
            // btn_eraser
            // 
            btn_eraser.BackColor = SystemColors.ControlLight;
            btn_eraser.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_eraser.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_eraser.FlatStyle = FlatStyle.Flat;
            btn_eraser.ForeColor = Color.Black;
            btn_eraser.Image = (Image)resources.GetObject("btn_eraser.Image");
            btn_eraser.Location = new Point(198, 0);
            btn_eraser.Margin = new Padding(4);
            btn_eraser.Name = "btn_eraser";
            btn_eraser.Size = new Size(88, 98);
            btn_eraser.TabIndex = 7;
            btn_eraser.Text = "Eraser";
            btn_eraser.TextAlign = ContentAlignment.TopCenter;
            btn_eraser.UseVisualStyleBackColor = false;
            btn_eraser.Click += btn_eraser_Click;
            // 
            // btn_pencil
            // 
            btn_pencil.BackColor = SystemColors.ControlLight;
            btn_pencil.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_pencil.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            btn_pencil.FlatStyle = FlatStyle.Flat;
            btn_pencil.ForeColor = Color.Black;
            btn_pencil.Image = (Image)resources.GetObject("btn_pencil.Image");
            btn_pencil.Location = new Point(9, 0);
            btn_pencil.Margin = new Padding(4);
            btn_pencil.Name = "btn_pencil";
            btn_pencil.Size = new Size(88, 98);
            btn_pencil.TabIndex = 6;
            btn_pencil.Text = "Pencil";
            btn_pencil.TextAlign = ContentAlignment.TopCenter;
            btn_pencil.UseVisualStyleBackColor = false;
            btn_pencil.Click += btn_pencil_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.White;
            SaveButton.Location = new Point(389, 15);
            SaveButton.Margin = new Padding(4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(105, 71);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Save as jpg";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // pic
            // 
            pic.BackColor = Color.White;
            pic.Dock = DockStyle.Fill;
            pic.Location = new Point(0, 101);
            pic.Margin = new Padding(4);
            pic.Name = "pic";
            pic.Size = new Size(1017, 553);
            pic.TabIndex = 2;
            pic.TabStop = false;
            pic.Click += pic_Click;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 654);
            Controls.Add(pic);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quintin Kanji Program";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
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
        private Button kanjiDesktopSaveBtn;
        private Button openKanjiBtn;
    }
}