using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kanji_Paint_Project
{
    internal class KanjiStrokes
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int StrokeCount { get; set; }
        public int BeginningOrEnd { get; set; } // Keeps track of Penup or Pendown
        public int CurrentStrokeType { get; set; } // Asks if user is on input = 2 or 4
        public int[,,,] KanjiEnd { get; set; } // Explained in KanjiStrokes()
        
        public KanjiStrokes()
        {
            int[,,,] KanjiEndinitial = new int[1000, 10, 10, 10];

            // KanjiEnd stores StrokeCount, if it's penup or down, the X and Y, if it's the kanji strokes or test strokes.
            // Kanji end is used to compare coordinates of the first stroke and test stroke.
            KanjiEnd = KanjiEndinitial;
        }
        public void inputStrokePoint(int iStrokeCount, int iBeginningOrEnd)
        {
            StrokeCount = iStrokeCount;
            BeginningOrEnd = iBeginningOrEnd;
        }
        public void inputCoordinates(int x, int y, int iCurrentStrokeType)
        {
            X = x;
            Y = y;
            // also takes if the stroke is a kanji stroke or a test kanji stroke.
            CurrentStrokeType = iCurrentStrokeType;

        }
        public void updateArray()
        {
            for (int x = 0; x < 2; x++)
            {
                if (x == 0)
                {
                    // Sets Kanji list to keep track of X. It initializes to 0 before doing that.
                    KanjiEnd[StrokeCount, BeginningOrEnd, x, CurrentStrokeType] = 0;
                    KanjiEnd[StrokeCount, BeginningOrEnd, x, CurrentStrokeType] = X;
                }
                if (x == 1)
                {
                    KanjiEnd[StrokeCount, BeginningOrEnd, x, CurrentStrokeType] = 0;
                    KanjiEnd[StrokeCount, BeginningOrEnd, x, CurrentStrokeType] = Y;
                }
            }
        }
        public int returnFirstX(int currentStrokeCount)
        {
            int firstStrokeX = KanjiEnd[currentStrokeCount, 0, 0, 1];
            return firstStrokeX;
        }
        public int returnFirstY(int currentStrokeCount)
        {
            int firstStrokeY = KanjiEnd[currentStrokeCount, 0, 1, 1];
            return firstStrokeY;
        }
        
        public int isCompareStrokeSame(int currentStrokeCount)
        {
            // This function ONLY checks the first x,y coordinates for both strokes,
            // not the end because it is hard for the user to replicate the kanji stroke.
            int firstStrokeX = KanjiEnd[currentStrokeCount, 0, 0, 0];
            int firstStrokeY = KanjiEnd[currentStrokeCount, 1, 1, 0];
            int testStrokeX = KanjiEnd[currentStrokeCount, 0, 0, 1];
            int testStrokeY = KanjiEnd[currentStrokeCount, 1, 1, 1];

            if (testStrokeX > firstStrokeX - 100 && testStrokeX < firstStrokeX + 100 && testStrokeY > firstStrokeY - 100 && testStrokeY < firstStrokeY + 100)
            {
                return 1;
            }
            else
            {
                MessageBox.Show("X and Y are NOT within 200x200 pixels!");
                return 0;
            }
        }
        
        public override string ToString()
        {
            return "X: " + KanjiEnd[StrokeCount, BeginningOrEnd, 0, CurrentStrokeType].ToString() + " Y: "+ KanjiEnd[StrokeCount, BeginningOrEnd, 1, CurrentStrokeType].ToString();
        }
    }
}
