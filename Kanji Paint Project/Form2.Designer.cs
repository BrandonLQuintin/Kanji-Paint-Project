namespace Kanji_Paint_Project
{
    partial class Form2
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
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            mostStrokesBtn = new Button();
            sortBiggestDescriptionBtn = new Button();
            sortLeastStrokesBtn = new Button();
            sortSmallestDescriptionBtn = new Button();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(197, 469);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(215, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(511, 338);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(730, 86);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(195, 264);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // mostStrokesBtn
            // 
            mostStrokesBtn.Location = new Point(730, 383);
            mostStrokesBtn.Name = "mostStrokesBtn";
            mostStrokesBtn.Size = new Size(98, 46);
            mostStrokesBtn.TabIndex = 3;
            mostStrokesBtn.Text = "Sort Most Strokes";
            mostStrokesBtn.UseVisualStyleBackColor = true;
            mostStrokesBtn.Click += mostStrokesBtn_Click;
            // 
            // sortBiggestDescriptionBtn
            // 
            sortBiggestDescriptionBtn.Location = new Point(730, 436);
            sortBiggestDescriptionBtn.Name = "sortBiggestDescriptionBtn";
            sortBiggestDescriptionBtn.Size = new Size(98, 46);
            sortBiggestDescriptionBtn.TabIndex = 4;
            sortBiggestDescriptionBtn.Text = "Sort Biggest Description";
            sortBiggestDescriptionBtn.UseVisualStyleBackColor = true;
            sortBiggestDescriptionBtn.Click += sortBiggestDescriptionBtn_Click;
            // 
            // sortLeastStrokesBtn
            // 
            sortLeastStrokesBtn.Location = new Point(834, 383);
            sortLeastStrokesBtn.Name = "sortLeastStrokesBtn";
            sortLeastStrokesBtn.Size = new Size(98, 46);
            sortLeastStrokesBtn.TabIndex = 5;
            sortLeastStrokesBtn.Text = "Sort Least Strokes";
            sortLeastStrokesBtn.UseVisualStyleBackColor = true;
            sortLeastStrokesBtn.Click += sortLeastStrokesBtn_Click;
            // 
            // sortSmallestDescriptionBtn
            // 
            sortSmallestDescriptionBtn.Location = new Point(834, 436);
            sortSmallestDescriptionBtn.Name = "sortSmallestDescriptionBtn";
            sortSmallestDescriptionBtn.Size = new Size(98, 45);
            sortSmallestDescriptionBtn.TabIndex = 6;
            sortSmallestDescriptionBtn.Text = "Sort Smallest Description";
            sortSmallestDescriptionBtn.UseVisualStyleBackColor = true;
            sortSmallestDescriptionBtn.Click += sortSmallestDescriptionBtn_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(730, 12);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(195, 31);
            richTextBox2.TabIndex = 7;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(730, 49);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(195, 31);
            richTextBox3.TabIndex = 8;
            richTextBox3.Text = "";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 487);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(sortSmallestDescriptionBtn);
            Controls.Add(sortLeastStrokesBtn);
            Controls.Add(sortBiggestDescriptionBtn);
            Controls.Add(mostStrokesBtn);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            MaximizeBox = false;
            Name = "Form2";
            Text = "Kanji Reviewer";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private PictureBox pictureBox1;
        private RichTextBox kanjiDescription;
        private RichTextBox richTextBox1;
        private Button mostStrokesBtn;
        private Button sortBiggestDescriptionBtn;
        private Button sortLeastStrokesBtn;
        private Button sortSmallestDescriptionBtn;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
    }
}