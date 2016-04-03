using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleships
{
    public partial class frm_Battleships : Form
    {
        static int seaSize = 100;
        int score = 0;
        int remainingMissiles = 70;
        int usedMissiles = 0;

        int[] boardSquares = new int[seaSize];


        public frm_Battleships()
        {
            InitializeComponent();
        }



        private void btn_PlayGame_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int shipType = 0;

            //Disable Play Button
            btn_PlayGame.Enabled = false;
            btn_EasyLevel.Enabled = false;
            btn_IntermediateLevel.Enabled = false;
            btn_HardLevel.Enabled = false;

            //For all of the squares
            for (int currentSquare = 0; currentSquare < seaSize; currentSquare++)
            {
                //Create and add a box to screen
                CreateBox(currentSquare, shipType);

                //Decide the ship type if a ship exists
                shipType = rnd.Next(1, 16);


                switch (shipType)
                {
                   
                    case 1:
                        //2 length boat
                        if (currentSquare + 1 < seaSize)
                        {
                            currentSquare++;

                            CreateBox(currentSquare, shipType);
                        }
                        else
                        {
                            shipType = 0;

                            CreateBox(currentSquare, shipType);
                        }
                        
                        break;


                    case 2:
                        //3 length boat
                        if (currentSquare + 2 < seaSize)
                        {
                            currentSquare++;

                            CreateBox(currentSquare, shipType);

                            currentSquare++;

                            CreateBox(currentSquare, shipType);

                        }
                        else
                        {
                            shipType = 0;

                            CreateBox(currentSquare, shipType);
                        }
                        
                        break;


                    case 3:
                        //4 length boat
                        if (currentSquare + 3 < seaSize)
                        {
                            currentSquare++;

                            CreateBox(currentSquare, shipType);

                            currentSquare++;

                            CreateBox(currentSquare, shipType);

                            currentSquare++;

                            CreateBox(currentSquare, shipType);
                        }
                        else
                        {
                            shipType = 0;

                            CreateBox(currentSquare, shipType);
                        }
                                                
                        break;


                    case 4:
                        //5 length boat
                        if (currentSquare + 4 < seaSize)
                        {
                            currentSquare++;

                            CreateBox(currentSquare, shipType);

                            currentSquare++;

                            CreateBox(currentSquare, shipType);

                            currentSquare++;

                            CreateBox(currentSquare, shipType);

                            currentSquare++;

                            CreateBox(currentSquare, shipType);

                        }
                        else
                        {
                            shipType = 0;

                            CreateBox(currentSquare, shipType);
                        }
                        
                        break;

                    default:
                        //No boat
                        break;

                }//End Switch

            }//End For

        }//End PlayGameClick



        private void CreateBox(int currentSquare, int shipType)
        {
            int boxSize = 50;

            //Create the box
            PictureBox pbx = new PictureBox();

            pbx.Height = boxSize;
            pbx.Width = boxSize;

            //Assign the name
            pbx.Name = currentSquare.ToString();

            //Assign to the array
            boardSquares[currentSquare] = shipType;

            //Add colour
            pbx.BackColor = Color.Black;

            //Add to board
            flp_Board.Controls.Add(pbx);

            //Add mouse click handler
            pbx.MouseClick += pbx_MouseClick;
        }



        void pbx_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pbxClicked = sender as PictureBox;

            //Ensure picture is positioned and sized correctly
            pbxClicked.SizeMode = PictureBoxSizeMode.StretchImage;

            if (pbxClicked.Image == null)
            {

                //Check if missiles remain
                if (usedMissiles < remainingMissiles)
                {
                    //Find the array position
                    int arrayPositionOfBox = Convert.ToInt32(pbxClicked.Name.ToString());


                    switch (boardSquares[arrayPositionOfBox])
                    {

                        case 1://Hit a submarine

                            pbxClicked.Image = imgLst_Ships.Images[1];

                            //Add Score
                            score = score + 10;

                            //Increase number of missiles used
                            usedMissiles++;

                            break;

                        case 2://Hit a frigate

                            pbxClicked.Image = imgLst_Ships.Images[2];

                            //Add Score
                            score = score + 20;

                            //Increase number of missiles used
                            usedMissiles++;

                            break;

                        case 3://Hit a destroyer

                            pbxClicked.Image = imgLst_Ships.Images[3];

                            //Add Score
                            score = score + 30;

                            //Increase number of missiles used
                            usedMissiles++;

                            break;

                        case 4://Hit a Battleship

                            pbxClicked.Image = imgLst_Ships.Images[4];

                            //Add Score
                            score = score + 40;

                            //Increase number of missiles used
                            usedMissiles++;

                            break;

                        default:
                            //Miss
                            pbxClicked.Image = imgLst_Ships.Images[0];

                            //Increase number of missiles used
                            usedMissiles++;

                            break;

                    }//End Switch

                    //Set labels
                    lbl_Score.Text = "Score: " + score.ToString();
                    lbl_Missiles.Text = "Missiles: " + usedMissiles.ToString() + "/" + remainingMissiles.ToString();
                }
                else
                {
                    MessageBox.Show("Game Over");

                    //Re-enable buttons
                    btn_PlayGame.Enabled = true;
                    btn_EasyLevel.Enabled = true;
                    btn_IntermediateLevel.Enabled = true;
                    btn_HardLevel.Enabled = true;

                    //Reset variables
                    flp_Board.Controls.Clear();
                    score = 0;
                    usedMissiles = 0;

                    lbl_Score.Text = "Score: " + score.ToString();
                    lbl_Missiles.Text = "Missiles: " + usedMissiles.ToString() + "/" + remainingMissiles.ToString();

                }//End if

            }
            else
            {
                MessageBox.Show("That was already clicked");

                usedMissiles++;
            }//End if

        }//End pbx_MouseClick



        private void btn_EasyLevel_Click(object sender, EventArgs e)
        {
            remainingMissiles = 70;

            btn_PlayGame.Enabled = true;
        }



        private void btn_IntermediateLevel_Click(object sender, EventArgs e)
        {
            remainingMissiles = 50;

            btn_PlayGame.Enabled = true;

        }



        private void btn_HardLevel_Click(object sender, EventArgs e)
        {
            remainingMissiles = 30;

            btn_PlayGame.Enabled = true;
        }



    }
}

