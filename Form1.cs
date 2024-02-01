using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int[] arrPairedNum = new int[16];
        static int intTurnCount = 0;
        static String[,] arrPlayerSelection = new String[2,2];
        static int intClickCounter = 0;


        public void SetupGrid(bool boolState)
        {
            btnStart.Visible = !boolState;
            lblGameTitle.Visible = !boolState;

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

            lblintClickCounter.Visible = boolState;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            SetupGrid(true);

            Random random = new Random();

            HashSet<int> usedColValues = new HashSet<int>();
            int intRandomNumber;

            const int intGridSize = 16;

            for (int row = 0; row < intGridSize; row++)
            {
                do
                {
                    intRandomNumber = random.Next(1, intGridSize + 1);

                } while (usedColValues.Contains(intRandomNumber));

                arrPairedNum[row] = intRandomNumber;

                usedColValues.Add(intRandomNumber);

            }

            const int intEqualizer = 8;

            for (int row = 0; row < intGridSize; row++)
            {

                if (arrPairedNum[row] > intEqualizer)
                {
                    arrPairedNum[row] = arrPairedNum[row] - intEqualizer;
                }


            }


            lblGameTitle.Visible = false;

        }

        //public void SetButtons()
        //{
        //    int arrValueIndex = 0;

        //    const int intRow = 4;      
        //    for (int row = 0; row < intRow; row++)
        //    {

        //        const int intCol = 4;
        //        for (int col = 0; col < intCol; col++)
        //        {
                    
        //            //string buttonName = "btnR" + (row + 1).ToString() + "C" + (col + 1).ToString();
        //            string strButtonName = $"btnR{row + 1}C{col + 1}";
        //            Button btnDynamicButton = Controls.Find(strButtonName, true).FirstOrDefault() as Button;
        //            btnDynamicButton.Text = arrPairedNum[arrValueIndex].ToString();
        //            arrValueIndex++;
        //        }

        //    }

        //}

        public void VerifyCompletionStatus()
        {

            int intCounter = 0;


            int intRowLimit = 4;
            for (int row = 0; row < intRowLimit; row++)
            {
                int intColLimit = 4;
                for (int col = 0; col < intColLimit; col++)
                {

                    string strButtonName = $"btnR{row + 1}C{col + 1}";
                    Button btnDynamicButton = Controls.Find(strButtonName, true).FirstOrDefault() as Button;

                    if (btnDynamicButton.Enabled == false)
                    {
                        intCounter++;
                    }


                }

            }

            if (intCounter == 16)
            {
                lblintClickCounter.Text = "Click Counter: " + intClickCounter.ToString();
                MessageBox.Show("You won in "+ intClickCounter.ToString() + " clicks!");

                SetupGrid(false);

                intClickCounter = 0;
                ResetGrid();
                return;
            }


        }


        public void ResetGrid()
        {

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {

                    string strButtonName = $"btnR{row + 1}C{col + 1}";
                    Button btnDynamicButton = Controls.Find(strButtonName, true).FirstOrDefault() as Button;

                    btnDynamicButton.Text = "";
                    btnDynamicButton.Enabled = true;
                                                  
                }

            }
            intClickCounter = 0;
            arrPairedNum = new int[16];
            intTurnCount = 0;
            arrPlayerSelection = new String[2, 2];

        }



        public void CheckGameState(String btnName, int theValue)
        {

            Button btnClickedButton = Controls.Find(btnName, true).FirstOrDefault() as Button;


            if (intTurnCount == 0)
            {
                intTurnCount = 1;
                btnClickedButton.Text = theValue.ToString();
                arrPlayerSelection[0, 0] = theValue.ToString();
                arrPlayerSelection[0, 1] = btnClickedButton.Name.ToString();
            }
            else if (intTurnCount == 1)
            {
                if (arrPlayerSelection[0, 1] != btnClickedButton.Name.ToString())
                {

                    intTurnCount = 2;
                    btnClickedButton.Text = theValue.ToString();
                    arrPlayerSelection[1, 0] = theValue.ToString();
                    arrPlayerSelection[1, 1] = btnClickedButton.Name.ToString();

                    if (arrPlayerSelection[0, 0] == arrPlayerSelection[1, 0])
                    {

                        ResetButtonText(true);
                        arrPlayerSelection = new String[2, 2];

                    }

                }
            }
            else if (intTurnCount == 2)
            {
                intTurnCount = 0;

                if (arrPlayerSelection[0, 0] == arrPlayerSelection[1, 0] && arrPlayerSelection[0, 0] != null && arrPlayerSelection[1, 0] != null)
                {

                    ResetButtonText(true);

                    arrPlayerSelection = new String[2, 2];

                    CheckGameState(btnName, theValue);
                }
                else
                {
                    if (arrPlayerSelection[0, 0] == null || arrPlayerSelection[1, 0] == null)
                    {
                        intTurnCount = 0;
                        CheckGameState(btnName, theValue);
                        return;
                    }

                    ResetButtonText(false);

                    arrPlayerSelection = new String[2, 2];

                    CheckGameState(btnName, theValue);
                }



            }

            VerifyCompletionStatus();

        }

        public void ResetButtonText(bool boolDisable)
        {
            for (int x =0; x <2; x++)
            {
                string strButtonName = arrPlayerSelection[x, 1];
                Button btnDynamicButton = Controls.Find(strButtonName, true).FirstOrDefault() as Button;

                if (boolDisable)
                {
                    btnDynamicButton.Enabled = false;
                }
                else
                {
                    btnDynamicButton.Text = "";
                }
                
            }
        }




        private void btnR1C1_Click(object sender, EventArgs e)
        {
            intClickCounter++;
            CheckGameState("btnR1C1", arrPairedNum[0]);
            lblintClickCounter.Text = "Click Counter: " + intClickCounter.ToString();
        }

        private void btnR1C2_Click(object sender, EventArgs e)
        {
            intClickCounter++;
            CheckGameState("btnR1C2", arrPairedNum[1]);
            lblintClickCounter.Text = "Click Counter: " + intClickCounter.ToString();
        }

        private void btnR1C3_Click(object sender, EventArgs e)
        {
            intClickCounter++;
            CheckGameState("btnR1C3", arrPairedNum[2]);
            lblintClickCounter.Text = "Click Counter: " + intClickCounter.ToString();
        }

        private void btnR1C4_Click(object sender, EventArgs e)
        {
            intClickCounter++;
            CheckGameState("btnR1C4", arrPairedNum[3]);
            lblintClickCounter.Text = "Click Counter: " + intClickCounter.ToString();
        }

        private void btnR2C1_Click(object sender, EventArgs e)
        {
            intClickCounter++;
            CheckGameState("btnR2C1", arrPairedNum[4]);
            lblintClickCounter.Text = "Click Counter: " + intClickCounter.ToString();
        }

        private void btnR2C2_Click(object sender, EventArgs e)
        {
            intClickCounter++;
            CheckGameState("btnR2C2", arrPairedNum[5]);
            lblintClickCounter.Text = "Click Counter: " + intClickCounter.ToString();
        }

        private void btnR2C3_Click(object sender, EventArgs e)
        {
            intClickCounter++;
            CheckGameState("btnR2C3", arrPairedNum[6]);
            lblintClickCounter.Text = "Click Counter: " + intClickCounter.ToString();
        }

        private void btnR2C4_Click(object sender, EventArgs e)
        {
            intClickCounter++;
            CheckGameState("btnR2C4", arrPairedNum[7]);
            lblintClickCounter.Text = "Click Counter: " + intClickCounter.ToString();
        }

        private void btnR3C1_Click(object sender, EventArgs e)
        {
            intClickCounter++;
            CheckGameState("btnR3C1", arrPairedNum[8]);
            lblintClickCounter.Text = "Click Counter: " + intClickCounter.ToString();
        }

        private void btnR3C2_Click(object sender, EventArgs e)
        {
            intClickCounter++;
            CheckGameState("btnR3C2", arrPairedNum[9]);
            lblintClickCounter.Text = "Click Counter: " + intClickCounter.ToString();
        }

        private void btnR3C3_Click(object sender, EventArgs e)
        {
            intClickCounter++;
            CheckGameState("btnR3C3", arrPairedNum[10]);
            lblintClickCounter.Text = "Click Counter: " + intClickCounter.ToString();
        }

        private void btnR3C4_Click(object sender, EventArgs e)
        {
            intClickCounter++;
            CheckGameState("btnR3C4", arrPairedNum[11]);
            lblintClickCounter.Text = "Click Counter: " + intClickCounter.ToString();

        }

        private void btnR4C1_Click(object sender, EventArgs e)
        {
            intClickCounter++;
            CheckGameState("btnR4C1", arrPairedNum[12]);
            lblintClickCounter.Text = "Click Counter: " + intClickCounter.ToString();
        }

        private void btnR4C2_Click(object sender, EventArgs e)
        {
            intClickCounter++;
            CheckGameState("btnR4C2", arrPairedNum[13]);
            lblintClickCounter.Text = "Click Counter: " + intClickCounter.ToString();
        }

        private void btnR4C3_Click(object sender, EventArgs e)
        {
            intClickCounter++;
            CheckGameState("btnR4C3", arrPairedNum[14]);
            lblintClickCounter.Text = "Click Counter: " + intClickCounter.ToString();
        }

        private void btnR4C4_Click(object sender, EventArgs e)
        {
            intClickCounter++;
            CheckGameState("btnR4C4", arrPairedNum[15]);
            lblintClickCounter.Text = "Click Counter: " + intClickCounter.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGrid();
            btnStart.PerformClick();
        }
    }
}
