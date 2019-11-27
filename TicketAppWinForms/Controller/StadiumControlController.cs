using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TicketAppWinForms.DataAccess;
using TicketAppWinForms.Model;
using TicketAppWinForms.View;

namespace TicketAppWinForms.Controller
{
    class StadiumControlController
    {
        #region Variables
        private StadiumControl stadiumControl;
        private Match match;
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

        string resourceDirectory;


        private Point pitchLocation;
        private int pitchSizeX;
        private int pitchSizeY;
        Size pitchSize;
        #endregion

        public StadiumControlController(StadiumControl stadiumControl, Match match)
        {
            this.match = match;
            this.stadiumControl = stadiumControl;
            InitializeStadium();
        }

        private void InitializeStadium()
        {
            //Init Starting locations
            InitializeStartingValues();

            //Init Left Stand
            InitializeStand(leftLocation, leftStartingLocationX, leftMaxRows, leftMaxColumns);
            //Init Upper Stand
            InitializeStand(upperLocation, upperStartingLocationX, upperMaxRows, upperMaxColumns);
            //Init Lower Stand
            InitializeStand(lowerLocation, lowerStartingLocationX, lowerMaxRows, lowerMaxColumns);
            //Init Right Stand
            InitializeStand(rightLocation, rightStartingLocationX, rightMaxRows, rightMaxColumns);

            //Init Pitch
            InitializePitch();
        }

        private void InitializePitch()
        {
            string imageFileDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\TicketApp\Resources\Pitch.png";
            var pitchImage = Image.FromFile(imageFileDir);  

            var pictureBox = new PictureBox
            {
                Image = pitchImage,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            pictureBox.Size = pitchSize;
            pictureBox.Location = pitchLocation;
            stadiumControl.Controls.Add(pictureBox);
        }

        private void InitializeStartingValues()
        {
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

            

            pitchSizeX = upperMaxColumns * buttonSizeX;
            pitchSizeY = leftMaxRows * buttonSizeY;
            pitchSize = new Size(pitchSizeX, pitchSizeY);
        }

        private void InitializeStand(Point standLocation, int standStartingLocationX, int standMaxRows, int standMaxColumns)
        {
            for (int i = 0; i < standMaxRows; i++)
            {
                columnId = 1;
                for (int j = 0; j < standMaxColumns; j++)
                {
                    Button b = new Button
                    {
                        Size = new Size(buttonSizeX, buttonSizeY),
                        Location = standLocation,
                    };

                    if (j == standMaxColumns - 1)
                    {
                        standLocation.X = standStartingLocationX;
                        standLocation.Y += b.Height;
                    }
                    else
                    {
                        standLocation.Offset(b.Width, 0);
                    }
                    Seat seat = new Seat(seatId);
                    seat.SetName(rowId, columnId);
                    Seats.Add(seat);
                    SqLite.AddSeat(seat);
                    b.Text = seat.Name;
                    b.Name = b.Text;
                    b.Click += new EventHandler(this.btnEvent_click);

                    stadiumControl.Controls.Add(b);
                    seatId++;
                    columnId++;
                }
                rowId++;
            }
        }

        void btnEvent_click(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.Red;
            Seat seat = Seats.Find(x => x.Name == ((Control)sender).Text);
            
            SqLite.SelectTicket(seat.Id, match.Id);
        }
    }
}
