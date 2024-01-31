using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int[] TestArray = new int[16];
        static int intTurnCount = 0;
        static String[,] arrSelection = new String[2,2];
        static int ClickCounter = 0;


        public void GridSetup(bool boolState)
        {
            btnStart.Visible = !boolState;
            lblGameTitle.Visible = !boolState;

            //btnReset.Visible = boolState;

            btnR1C1.Visible = boolState;
            btnR1C2.Visible = boolState;
            btnR1C3.Visible = boolState;
            btnR1C4.Visible = boolState;
            btnR2C1.Visible = boolState;
            btnR2C2.Visible = boolState;
            btnR2C3.Visible = boolState;
            btnR2C4.Visible = boolState;
            btnR3C1.Visible = boolState;
            btnR3C2.Visible = boolState;
            btnR3C3.Visible = boolState;
            btnR3C4.Visible = boolState;
            btnR4C1.Visible = boolState;
            btnR4C2.Visible = boolState;
            btnR4C3.Visible = boolState;
            btnR4C4.Visible = boolState;

            lblClickCounter.Visible = boolState;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            GridSetup(true);

            Random random = new Random();

            HashSet<int> usedColValues = new HashSet<int>();
            int randomNumber;

            for (int row = 0; row < 16; row++)
            {
                do
                {
                    randomNumber = random.Next(1, 17);

                } while (usedColValues.Contains(randomNumber));

                TestArray[row] = randomNumber;

                usedColValues.Add(randomNumber);

            }

            for (int row = 0; row < 16; row++)
            {

                if (TestArray[row] > 8)
                {
                    TestArray[row] = TestArray[row] - 8;
                }


            }
            //setButtons();
            lblGameTitle.Visible = false;

        }

        public void setButtons()
        {
            int ArrayValues = 0;
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    
                    string buttonName = "btnR" + (row + 1).ToString() + "C" + (col + 1).ToString();
                    Button dynamicButton = Controls.Find(buttonName, true).FirstOrDefault() as Button;
                    dynamicButton.Text = TestArray[ArrayValues].ToString();
                    ArrayValues++;
                }

            }

        }

        public void CheckIfDone()
        {

            int Counter = 0;

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {

                    string buttonName = "btnR" + (row + 1).ToString() + "C" + (col + 1).ToString();
                    Button dynamicButton = Controls.Find(buttonName, true).FirstOrDefault() as Button;
                    
                    if (dynamicButton.Enabled == false)
                    {
                        Counter++;
                    }


                }

            }

            if (Counter == 16)
            {
                lblClickCounter.Text = "Click Counter: " + ClickCounter.ToString();
                MessageBox.Show("You won in "+ ClickCounter.ToString() + " clicks!");

                GridSetup(false);

                ClickCounter = 0;
                resetGrid();
                return;
            }


        }


        public void resetGrid()
        {

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {

                    string buttonName = "btnR" + (row + 1).ToString() + "C" + (col + 1).ToString();
                    Button dynamicButton = Controls.Find(buttonName, true).FirstOrDefault() as Button;

                    dynamicButton.Text = "";
                    dynamicButton.Enabled = true;
                                                  
                }

            }
            ClickCounter = 0;
            TestArray = new int[16];
            intTurnCount = 0;
            arrSelection = new String[2, 2];

        }



        public void TheChecker(String btnName, int theValue)
        {

            Button ClickedButton = Controls.Find(btnName, true).FirstOrDefault() as Button;


            if (intTurnCount == 0)
            {
                intTurnCount = 1;
                ClickedButton.Text = theValue.ToString();
                arrSelection[0, 0] = theValue.ToString();
                arrSelection[0, 1] = ClickedButton.Name.ToString();
            }
            else

            if (intTurnCount == 1)
            {
                if (arrSelection[0, 1] != ClickedButton.Name.ToString())
                {

                    intTurnCount = 2;
                    ClickedButton.Text = theValue.ToString();
                    arrSelection[1, 0] = theValue.ToString();
                    arrSelection[1, 1] = ClickedButton.Name.ToString();

                    if (arrSelection[0, 0] == arrSelection[1, 0])
                    {

                        ButtonTextReset(true);
                        arrSelection = new String[2, 2];

                    }

                }
            }
            else if (intTurnCount == 2)
            {
                intTurnCount = 0;

                if (arrSelection[0, 0] == arrSelection[1, 0] && arrSelection[0, 0] != null && arrSelection[1, 0] != null)
                {

                    ButtonTextReset(true);

                    arrSelection = new String[2, 2];

                    TheChecker(btnName, theValue);
                }
                else
                {
                    if (arrSelection[0, 0] == null || arrSelection[1, 0] == null)
                    {
                        intTurnCount = 0;
                        TheChecker(btnName, theValue);
                        return;
                    }

                    ButtonTextReset(false);

                    arrSelection = new String[2, 2];

                    TheChecker(btnName, theValue);
                }



            }

            CheckIfDone();

        }

        public void ButtonTextReset(bool isToDisable)
        {
            for (int x =0; x <2; x++)
            {
                string buttonName = arrSelection[x, 1];
                Button dynamicButton = Controls.Find(buttonName, true).FirstOrDefault() as Button;

                if (isToDisable)
                {
                    dynamicButton.Enabled = false;
                }
                else
                {
                    dynamicButton.Text = "";
                }
                
            }
        }




        private void btnR1C1_Click(object sender, EventArgs e)
        {
            ClickCounter++;
            TheChecker("btnR1C1", TestArray[0]);
            lblClickCounter.Text = "Click Counter: " + ClickCounter.ToString();
        }

        private void btnR1C2_Click(object sender, EventArgs e)
        {
            ClickCounter++;
            TheChecker("btnR1C2", TestArray[1]);
            lblClickCounter.Text = "Click Counter: " + ClickCounter.ToString();
        }

        private void btnR1C3_Click(object sender, EventArgs e)
        {
            ClickCounter++;
            TheChecker("btnR1C3", TestArray[2]);
            lblClickCounter.Text = "Click Counter: " + ClickCounter.ToString();
        }

        private void btnR1C4_Click(object sender, EventArgs e)
        {
            ClickCounter++;
            TheChecker("btnR1C4", TestArray[3]);
            lblClickCounter.Text = "Click Counter: " + ClickCounter.ToString();
        }

        private void btnR2C1_Click(object sender, EventArgs e)
        {
            ClickCounter++;
            TheChecker("btnR2C1", TestArray[4]);
            lblClickCounter.Text = "Click Counter: " + ClickCounter.ToString();
        }

        private void btnR2C2_Click(object sender, EventArgs e)
        {
            ClickCounter++;
            TheChecker("btnR2C2", TestArray[5]);
            lblClickCounter.Text = "Click Counter: " + ClickCounter.ToString();
        }

        private void btnR2C3_Click(object sender, EventArgs e)
        {
            ClickCounter++;
            TheChecker("btnR2C3", TestArray[6]);
            lblClickCounter.Text = "Click Counter: " + ClickCounter.ToString();
        }

        private void btnR2C4_Click(object sender, EventArgs e)
        {
            ClickCounter++;
            TheChecker("btnR2C4", TestArray[7]);
            lblClickCounter.Text = "Click Counter: " + ClickCounter.ToString();
        }

        private void btnR3C1_Click(object sender, EventArgs e)
        {
            ClickCounter++;
            TheChecker("btnR3C1", TestArray[8]);
            lblClickCounter.Text = "Click Counter: " + ClickCounter.ToString();
        }

        private void btnR3C2_Click(object sender, EventArgs e)
        {
            ClickCounter++;
            TheChecker("btnR3C2", TestArray[9]);
            lblClickCounter.Text = "Click Counter: " + ClickCounter.ToString();
        }

        private void btnR3C3_Click(object sender, EventArgs e)
        {
            ClickCounter++;
            TheChecker("btnR3C3", TestArray[10]);
            lblClickCounter.Text = "Click Counter: " + ClickCounter.ToString();
        }

        private void btnR3C4_Click(object sender, EventArgs e)
        {
            ClickCounter++;
            TheChecker("btnR3C4", TestArray[11]);
            lblClickCounter.Text = "Click Counter: " + ClickCounter.ToString();

        }

        private void btnR4C1_Click(object sender, EventArgs e)
        {
            ClickCounter++;
            TheChecker("btnR4C1", TestArray[12]);
            lblClickCounter.Text = "Click Counter: " + ClickCounter.ToString();
        }

        private void btnR4C2_Click(object sender, EventArgs e)
        {
            ClickCounter++;
            TheChecker("btnR4C2", TestArray[13]);
            lblClickCounter.Text = "Click Counter: " + ClickCounter.ToString();
        }

        private void btnR4C3_Click(object sender, EventArgs e)
        {
            ClickCounter++;
            TheChecker("btnR4C3", TestArray[14]);
            lblClickCounter.Text = "Click Counter: " + ClickCounter.ToString();
        }

        private void btnR4C4_Click(object sender, EventArgs e)
        {
            ClickCounter++;
            TheChecker("btnR4C4", TestArray[15]);
            lblClickCounter.Text = "Click Counter: " + ClickCounter.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetGrid();
            btnStart.PerformClick();
        }
    }
}
