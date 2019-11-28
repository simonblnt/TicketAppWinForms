using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TicketAppWinForms.DataAccess;
using TicketAppWinForms.Model;
using TicketAppWinForms.View;
using System.Data.SQLite;
using System.Linq;

namespace TicketAppWinForms.Controller
{
    class StadiumControlController
    {
        #region Variables
        private StadiumControl stadiumControl;
        private Match match;
        private User user;
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
        Size pitchSize;

        internal List<Ticket> SelectedTickets { get; set; }
        #endregion

        public StadiumControlController(StadiumControl stadiumControl, Match match, User user)
        {
            this.match = match;
            this.stadiumControl = stadiumControl;
            this.user = user;
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
                    b.Text = seat.Name;
                    b.Name = b.Text;
                    b.Click += new EventHandler(this.btnEvent_click);


                    

                    if (SqLite.GetVIPSeatList().Contains(seat.Name))
                        b.ForeColor = Color.Gold;

                    if (SqLite.IsSeatAdded(seat.Name))
                    {
                        if (SqLite.IsTicketSelected(seat.Id, match.Id))
                        {
                            if (SqLite.IsTicketSelectedByUser(seat.Id, match.Id, user.Id))
                            {
                                b.BackColor = Color.Yellow;
                            }
                            else
                            {
                                b.BackColor = Color.Orange;
                            }
                        }
                        else if (SqLite.IsTicketOwned(seat.Id, match.Id))
                        {
                            if (SqLite.IsTicketOwnedByUser(seat.Id, match.Id, user.Id))
                            {
                                b.BackColor = Color.Green;
                            }
                            else
                            {
                                b.BackColor = Color.Red;
                            } 
                        }
                        else
                        {
                            b.BackColor = Color.White;
                        }
                    }
                    else
                    {
                        SqLite.AddSeat(seat);
                    }

                    stadiumControl.Controls.Add(b);
                    seatId++;
                    columnId++;
                }
                rowId++;
            }
        }

        private void btnEvent_click(object sender, EventArgs e)
        {
            Seat seat = Seats.Find(x => x.Name == ((Control)sender).Text);

            if (SqLite.IsTicketSelectedByUser(seat.Id, match.Id, user.Id))
            {
                SqLite.UnselectTicket(seat.Id, match.Id);
                ((Control)sender).BackColor = Color.White;
            }
            else if (SqLite.IsTicketOwnedByUser(seat.Id, match.Id, user.Id))
            {
                string message = "This ticket is already yours.";
                MessageBox.Show(message);
            }
            else if (SqLite.IsTicketSelected(seat.Id, match.Id) || SqLite.IsTicketOwned(seat.Id, match.Id))
            {
                string message = "This ticket is not available.";
                MessageBox.Show(message);
            }
            else
            {
                SqLite.SelectTicket(seat.Id, match.Id, user.Id);
                ((Control)sender).BackColor = Color.Yellow;
            }
        }

        public void OpenCheckoutWindow()
        {
            SelectedTickets = SqLite.QuerySelectedTickets(match.Id, user.Id);
            CheckoutWindow checkoutWindow = new CheckoutWindow(match, user, SelectedTickets);
            checkoutWindow.Show();
            ((Form)stadiumControl.TopLevelControl).Close();
        }
    }
}
