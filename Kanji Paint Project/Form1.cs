using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// https://www.youtube.com/watch?v=m7Ohm52TIhw
// Rohit Programming - I used some of this video's code to see how to paint
// on the screen, and to save the file.

namespace Kanji_Paint_Project
{
    public partial class Form1 : Form
    {
        public void drawGrid()
        {
            Pen blackPen = new Pen(Color.GhostWhite, 3);

            // 100x100 px squares to generate a grid.
            float Spacing = 100;

            // Draw horizontal
            for (int i = 0; i < 5; i++)
            {
                g.DrawLine(blackPen, 0.0F, Spacing, 1000.0f, Spacing);
                Spacing += 100;
            }
            Spacing = 100;
            // Draw vertical
            for (int i = 0; i < 10; i++)
            {
                g.DrawLine(blackPen, Spacing, 0.0f, Spacing, 1000.0f);
                Spacing += 100;
            }

        }
        public Form1()
        {
            // Sets up the drawable canvas

            InitializeComponent();
            this.Width = 900;
            this.Height = 700;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);

            g.Clear(Color.White);
            pic.Image = bm;
            drawGrid();
        }

        string[] colors = new string[] { "Red", "Green", "Purple", "Blue" };

        // The font is later used to draw the numbers for the stroke count
        Font myFont = new Font("Arial", 15);
        Font myFontFinal = new Font("Arial", 30);
        Brush myBrush = new SolidBrush(Color.Red);

        Bitmap bm;
        Graphics g;
        Point px, py;

        Bitmap[] btm = new Bitmap[100];
        int test = 0;
        int bitmapIndex = 0;
        // This form will display the correct strokes in a different window.
        Form form = new Form { Name = "Screenshot Displayer", Size = new System.Drawing.Size(800, 800), Location = new System.Drawing.Point(140, 170), Visible = true };
        PictureBox P = new PictureBox();

        Pen p = new Pen(Color.White, 30);
        Pen tp = new Pen(Color.White, 5);
        KanjiStrokes KanjiArray = new KanjiStrokes();

        int previousColor = 0;
        bool paint = false;
        int index;
        int strokeCount = 0;
        int testYourselfStrokeCount = 0;

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            if (index == 2)
            {
                // Takes the X and Y for the stroke's initial placement
                KanjiArray.inputCoordinates(e.X, e.Y, 0);
                KanjiArray.inputStrokePoint(strokeCount, 0);
                KanjiArray.updateArray();
            }
            if (index == 4)
            {
                
                KanjiArray.inputCoordinates(e.X, e.Y, 1);
                KanjiArray.inputStrokePoint(testYourselfStrokeCount, 0);
                KanjiArray.updateArray();

            }
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint == true)
            {
                if (index == 1) // Pencil
                {
                    Pen p = new Pen(Color.Black, 5);
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                    p.Dispose();
                }
                else if (index == 2) // Kanji Pencil
                {
                    
                    Pen p = new Pen(Color.FromName(colors[previousColor]), 5);
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                    
                }
                else if (index == 3) // Eraser
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                else if (index == 4) // "Test yourself" option
                {
                    tp.Color = Color.Green;
                    px = e.Location;
                    g.DrawLine(tp, px, py);
                    py = px;

                    
                }
            }
            pic.Refresh();
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            if (index == 2)
            {
                // inputs x and y for the stroke when it ends.
                KanjiArray.inputCoordinates(e.X, e.Y, 0);
                KanjiArray.inputStrokePoint(strokeCount, 1);
                KanjiArray.updateArray();

                // Program checks if next color is not the same as the previous one
                Random r = new Random();
                int genRand = r.Next(0, 4);
                while (genRand == previousColor)
                {
                    genRand = r.Next(0, 4);
                }
                previousColor = genRand;
                strokeCount += 1;

                float xCord = e.X;
                float yCord = e.Y;

                
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                g.DrawString(strokeCount.ToString(), myFont, myBrush, xCord, yCord);


                btm[bitmapIndex] = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                bitmapIndex += 1;

                
                



            }
            if (index == 4)
            {
                KanjiArray.inputCoordinates(e.X, e.Y, 1);
                KanjiArray.inputStrokePoint(testYourselfStrokeCount, 1);
                KanjiArray.updateArray();

                // This line below is written because it will prevent more message boxes from
                // appearing after they got all the strokes.
                if (strokeCount > testYourselfStrokeCount)
                {
                    // this if statement allows the code to run to see if the strokes are the same.
                    // if they aren't, it returns 0 and pops up a message box saying so.
                    if (KanjiArray.isCompareStrokeSame(testYourselfStrokeCount) == 1)
                    {
                        

                        testYourselfStrokeCount += 1;
                        float xCord = e.X;
                        float yCord = e.Y;
                        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                        g.DrawString(testYourselfStrokeCount.ToString(), myFontFinal, myBrush, xCord, yCord);

                        // The code below displays original stroke in a different window.
                        // P and form lines were generated by ChatGPT.
                       
                        P.Image = btm[testYourselfStrokeCount - 1];
                        P.Dock = DockStyle.Fill;

                        if (form.IsHandleCreated == false)
                        {
                            form = new Form { Name = "Screenshot Displayer", Size = new System.Drawing.Size(800, 800), Location = new System.Drawing.Point(140, 170), Visible = true };
                            P = new PictureBox();
                        }
                        form.Controls.Add(P);
                        form.Show();

                        
                    }
                }
                
                if (strokeCount == testYourselfStrokeCount)
                {
                    MessageBox.Show("You got all the strokes!");
                    testYourselfStrokeCount += 1;
                }
            }
        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btn_kanji_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btn_eraser_Click(object sender, EventArgs e)
        {
            index = 3;
            
        }

        bool isWindowOpen = false;
        private void TestYourselfButton_Click(object sender, EventArgs e)
        {
            index = 4;
            if (form.IsHandleCreated == false)
            {
                form = new Form { Name = "Screenshot Displayer", Size = new System.Drawing.Size(800, 800), Location = new System.Drawing.Point(140, 170), Visible = true };
                P = new PictureBox();
            }


            // Clears the screen
            g.Clear(Color.White);
            drawGrid();
            testYourselfStrokeCount = 0;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                btm[bitmapIndex] = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm[bitmapIndex].Save(sfd.FileName,ImageFormat.Jpeg);
                
                MessageBox.Show("Saved Successfully!");
            }
        }

        private void rst_btn_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            drawGrid();
            strokeCount = 0;
            testYourselfStrokeCount = 0;
            bitmapIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        

        private void pic_Click(object sender, EventArgs e)
        {

        }
    }
}