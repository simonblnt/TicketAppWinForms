using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketAppWinForms.Model;
using TicketAppWinForms.View;

namespace TicketAppWinForms.Controller
{
    class StadiumController
    {
        #region Variables
        private StadiumControl stadiumControl;
        private int buttonSizeX;
        private int buttonSizeY;

        private int upperMaxRows;
        private int upperMaxColumns;
        private int lowerMaxRows;
        private int lowerMaxColumns;

        private int leftMaxRows;
        private int leftMaxColumns;
        private int rightMaxRows;
        private int rightMaxColumns;

        private List<Seat> Seats;
        private int seatId;
        private int rowId;
        private int columnId;

        private int leftStartingLocationX;
        private int leftStartingLocationY;

        private int upperStartingLocationX;
        private int upperStartingLocationY;

        private int lowerStartingLocationX;
        private int lowerStartingLocationY;

        private int rightStartingLocationX;
        private int rightStartingLocationY;

        private int pitchStartingLocationX;
        private int pitchStartingLocationY;

        private Point upperLocation;
        private Point leftLocation;
        private Point lowerLocation;
        private Point rightLocation;

        private Point pitchLocation;
        private int pitchSizeX;
        private int pitchSizeY;
        #endregion

        public StadiumController(StadiumControl stadiumControl)
        {
            this.stadiumControl = stadiumControl;
            buttonSizeX = 35;
            buttonSizeY = 35;

            upperMaxRows = 4;
            upperMaxColumns = 10;
            lowerMaxRows = 4;
            lowerMaxColumns = 10;

            leftMaxRows = 3;
            leftMaxColumns = 4;
            rightMaxRows = 3;
            rightMaxColumns = 4;

            Seats = new List<Seat>();
            seatId = 0;
            rowId = 1;
            columnId = 1;
        }


        public void InitializeStadium()
        {
            InitializeStartingLocations();

            InitializeLeftStand(leftLocation, leftStartingLocationX);
            InitializeUpperStand(upperLocation, upperStartingLocationX);
            InitializeLowerStand(lowerLocation, lowerStartingLocationX);
            InitializeRightStand(rightLocation, rightStartingLocationX);

            InitializePitch();
        }

        private void InitializePitch()
        {
            Directory.SetCurrentDirectory(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName);
            
            string resDir = Directory.GetCurrentDirectory() + "\\Resources";
            string pitchImage = "Pitch.png";

            

            var picture = Image.FromFile(Path.Combine(resDir, pitchImage));

            pitchSizeX = upperMaxColumns * buttonSizeX;
            pitchSizeY = leftMaxRows * buttonSizeY;

            Size pitchSize = new Size(pitchSizeX, pitchSizeY);

            var pictureBox = new PictureBox
            {
                Image = picture,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            pictureBox.Size = pitchSize;
            pictureBox.Location = pitchLocation;
            stadiumControl.Controls.Add(pictureBox);
        }

        private void InitializeStartingLocations()
        {
            leftStartingLocationX = (stadiumControl.Location.X + 10);    //Left border
            leftStartingLocationY = upperMaxRows * (buttonSizeX + 3);

            upperStartingLocationX = leftMaxColumns * (buttonSizeY + 3);
            upperStartingLocationY = (stadiumControl.Location.Y + 10);

            lowerStartingLocationX = upperStartingLocationX;
            lowerStartingLocationY = leftStartingLocationY + leftMaxRows * (buttonSizeY);

            rightStartingLocationX = upperStartingLocationX + upperMaxColumns * (buttonSizeX);
            rightStartingLocationY = leftStartingLocationY;

            pitchStartingLocationX = leftStartingLocationX + leftMaxColumns * buttonSizeX;
            pitchStartingLocationY = upperStartingLocationY + upperMaxRows * buttonSizeY;

            upperLocation = new Point(upperStartingLocationX, upperStartingLocationY);
            leftLocation = new Point(leftStartingLocationX, leftStartingLocationY);
            lowerLocation = new Point(lowerStartingLocationX, lowerStartingLocationY);
            rightLocation = new Point(rightStartingLocationX, rightStartingLocationY);

            pitchLocation = new Point(pitchStartingLocationX, pitchStartingLocationY);
        }

        private void InitializeLeftStand(Point leftLocation, int leftStartingLocationX) {
            //Left Stand
            for (int i = 0; i < leftMaxRows; i++)
            {
                columnId = 1;
                for (int j = 0; j < leftMaxColumns; j++)
                {
                    Button b = new Button
                    {
                        Size = new Size(buttonSizeX, buttonSizeY),
                        Location = leftLocation,
                    };

                    if (j == leftMaxColumns - 1)
                    {
                        leftLocation.X = leftStartingLocationX;
                        leftLocation.Y += b.Height;
                    }
                    else
                    {
                        leftLocation.Offset(b.Width, 0);
                    }
                    Seat seat = new Seat(seatId, ref b);
                    seat.SetName(rowId, columnId);
                    Seats.Add(seat);
                    b.Text = seat.GetName();

                    stadiumControl.Controls.Add(b);
                    seatId++;
                    columnId++;
                }
                rowId++;
            }

        }

        private void InitializeUpperStand(Point upperLocation, int upperStartingLocationX)
        {
            //Upper Stand
            for (int i = 0; i < upperMaxRows; i++)
            {
                columnId = 1;
                for (int j = 0; j < upperMaxColumns; j++)
                {
                    Button b = new Button
                    {
                        Size = new Size(buttonSizeX, buttonSizeY),
                        Location = upperLocation,
                    };

                    if (j == upperMaxColumns - 1)
                    {
                        upperLocation.X = upperStartingLocationX;
                        upperLocation.Y += b.Height;
                    }
                    else
                    {
                        upperLocation.Offset(b.Width, 0);
                    }
                    Seat seat = new Seat(seatId, ref b);
                    seat.SetName(rowId, columnId);
                    Seats.Add(seat);
                    b.Text = seat.GetName();

                    stadiumControl.Controls.Add(b);
                    seatId++;
                    columnId++;
                }
                rowId++;
            }

        }

        private void InitializeLowerStand(Point lowerLocation, int lowerStartingLocationX)
        {
            //Lower Stand
            for (int i = 0; i < lowerMaxRows; i++)
            {
                columnId = 1;
                for (int j = 0; j < lowerMaxColumns; j++)
                {
                    Button b = new Button
                    {
                        Size = new Size(buttonSizeX, buttonSizeY),
                        Location = lowerLocation,
                    };

                    if (j == lowerMaxColumns - 1)
                    {
                        lowerLocation.X = lowerStartingLocationX;
                        lowerLocation.Y += b.Height;
                    }
                    else
                    {
                        lowerLocation.Offset(b.Width, 0);
                    }
                    Seat seat = new Seat(seatId, ref b);
                    seat.SetName(rowId, columnId);
                    Seats.Add(seat);
                    b.Text = seat.GetName();

                    stadiumControl.Controls.Add(b);
                    seatId++;
                    columnId++;
                }
                rowId++;
            }

        }

        private void InitializeRightStand(Point rightLocation, int rightStartingLocationX)
        {
            //Right Stand
            for (int i = 0; i < rightMaxRows; i++)
            {
                columnId = 1;
                for (int j = 0; j < rightMaxColumns; j++)
                {
                    Button b = new Button
                    {
                        Size = new Size(buttonSizeX, buttonSizeY),
                        Location = rightLocation,
                    };

                    if (j == rightMaxColumns - 1)
                    {
                        rightLocation.X = rightStartingLocationX;
                        rightLocation.Y += b.Height;
                    }
                    else
                    {
                        rightLocation.Offset(b.Width, 0);
                    }
                    Seat seat = new Seat(seatId, ref b);
                    seat.SetName(rowId, columnId);
                    Seats.Add(seat);
                    b.Text = seat.GetName();

                    stadiumControl.Controls.Add(b);
                    seatId++;
                    columnId++;
                }
                rowId++;
            }


        }


        
    }
}
