using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace KarmaConvertor
{
    
    /* To do list:
     * - Make it open and close the inventory.(DONE)
     * - Close inventory before going to buy.(In place but needs implementing
     * - Open inventory after buying.(In place but needs implementing
     * - Auto open the mystic forge.
     * - Auto forge the right amount of times.
     * - Open inventory after done with forge.(In place but needs implementing
     * - Make it automatically set the forge, merchant and bag in right posisions.
     */

    public partial class KarmaConvertor : Form
    {
        private BackgroundWorker bw = new BackgroundWorker();

        //________________________VAR LIST:________________________________
        double statusindicator = 0;
        double buysession;
        double forgesession;
        //_________________________________________________________________



        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        public KarmaConvertor()
        {
            InitializeComponent();
        }
        
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        

        public bool isPressed(Keys vKey)
        {
            return Convert.ToBoolean(GetAsyncKeyState(vKey));
        }

        
        // the magic that makes it all happen
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Random r = new Random();
            

            if (isPressed(Keys.F5))
            {
                System.Threading.Thread.Sleep(r.Next(150, 250));
                //Set status:
                statusindicator = 0;
                //Focus on Merchant window
                Cursor.Position = new Point((r.Next(532, 845)), (r.Next(23, 24)));
                System.Threading.Thread.Sleep(r.Next(25, 50));
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                System.Threading.Thread.Sleep(r.Next(50, 100));
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                System.Threading.Thread.Sleep(r.Next(200, 350));

                // Loops throug the buy process till buysession =  var i
                for (int b = 0; b < buysession; b++)  
                {

                    //Set status:
                    statusindicator = 1;
                    
                    //Click buy
                    Cursor.Position = new Point((r.Next(924, 967)), (r.Next(640, 648)));
                    System.Threading.Thread.Sleep(r.Next(50, 75));
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    System.Threading.Thread.Sleep(r.Next(300, 400));

                    // Click yes
                    Cursor.Position = new Point((r.Next(922, 1017)), (r.Next(587, 595)));
                    System.Threading.Thread.Sleep(r.Next(50, 75));
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    System.Threading.Thread.Sleep(r.Next(300, 350));
                }


                //Set status:
                statusindicator = 2;

                //Focus Inventory window
                Cursor.Position = new Point((r.Next(1525, 1777)), (r.Next(15, 28)));
                System.Threading.Thread.Sleep(r.Next(25, 50));
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                System.Threading.Thread.Sleep(r.Next(50, 100));
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                System.Threading.Thread.Sleep(r.Next(50, 100));

                //Set status:
                statusindicator = 3;

                //Open Forge kit(click 2nd bag slot)
                Cursor.Position = new Point((r.Next(1573, 1603)), (r.Next(125, 149)));
                System.Threading.Thread.Sleep(r.Next(50, 75));
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                System.Threading.Thread.Sleep(r.Next(25, 50));
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                System.Threading.Thread.Sleep(r.Next(25));
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                System.Threading.Thread.Sleep(r.Next(25, 50));
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                System.Threading.Thread.Sleep(r.Next(250, 350));

                //Forge looping
                for (int a = 0; a < forgesession; a++)
                {

                    //Set status:
                    statusindicator = 4;

                    //obj 1
                    Cursor.Position = new Point((r.Next(520, 560)), (r.Next(240, 290)));
                    System.Threading.Thread.Sleep(r.Next(50, 201));
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    System.Threading.Thread.Sleep(r.Next(50, 78));
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    System.Threading.Thread.Sleep(r.Next(50, 201));
                    // Obj 2
                    Cursor.Position = new Point((r.Next(577, 627)), (r.Next(240, 290)));
                    System.Threading.Thread.Sleep(r.Next(124, 201));
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    System.Threading.Thread.Sleep(50);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    System.Threading.Thread.Sleep(r.Next(50, 201));
                    //Obj 3
                    Cursor.Position = new Point((r.Next(640, 685)), (r.Next(240, 290)));
                    System.Threading.Thread.Sleep(r.Next(50, 201));
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    System.Threading.Thread.Sleep(50);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    System.Threading.Thread.Sleep(r.Next(50, 201));
                    //obj 4
                    Cursor.Position = new Point((r.Next(695, 745)), (r.Next(240, 290)));
                    System.Threading.Thread.Sleep(r.Next(50, 201));
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    System.Threading.Thread.Sleep(50);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    System.Threading.Thread.Sleep(r.Next(102, 231));
                    //press Ok.
                    Cursor.Position = new Point((r.Next(1080, 1125)), (r.Next(700, 715)));
                    System.Threading.Thread.Sleep(125);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    System.Threading.Thread.Sleep(r.Next(1703, 1852));
                }

                
                //Open Salvage kit(click 1st bag slot)
                Cursor.Position = new Point((r.Next(1525, 1541)), (r.Next(124, 147)));
                System.Threading.Thread.Sleep(r.Next(50, 75));
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                System.Threading.Thread.Sleep(r.Next(25, 50));
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                System.Threading.Thread.Sleep(r.Next(25));
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                System.Threading.Thread.Sleep(r.Next(25, 50));
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                System.Threading.Thread.Sleep(r.Next(250, 350));
                //Set status:
                statusindicator = 5;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Status.ForeColor = System.Drawing.Color.Green;
            Status.Text = "Currently: Pending";
            Forge.Enabled = true;
            Realforge.Enabled = true;
            testTimer1.Enabled = true;
            MouseTrackTimer.Enabled = true;
        }


       // TEST AREA //
        public void button1_Click(object sender, EventArgs e)
        {
            double Value1 = float.Parse(textBox1.Text);
            double divideby = 4;
            double Calcstuff = Value1 / divideby;
            double Rounded1 = Math.Floor(Calcstuff);
            this.buysession = Rounded1 * 4;
            this.forgesession = buysession / 4;
            { 
                lblXas.Text = "you can get " + Rounded1.ToString() +" sets";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are able to buy " + forgesession.ToString() + " forge sets of 4");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync(); 
            }

            if (isPressed(Keys.F6))
            {
                this.Close();
            }

            lblXas.Text = " X =" + " " + Cursor.Position.X;
            lblYas.Text = " Y =" + " " + Cursor.Position.Y;

            //Update otherlable 
            if (statusindicator == 0)
            {
                Status.ForeColor = System.Drawing.Color.Green;
                Status.Text = "Currently: Pending";
            }

            if (statusindicator == 1)
            {
                Status.ForeColor = System.Drawing.Color.Green;
                Status.Text = "Currently: Buying gloves"; ;
            }

            if (statusindicator == 2)
            {
                Status.ForeColor = System.Drawing.Color.Green;
                Status.Text = "Currently: Selecting inventory";
            }

            if (statusindicator == 3)
            {
                Status.ForeColor = System.Drawing.Color.Green;
                Status.Text = "Currently: Opening Forge";
            }

            if (statusindicator == 4)
            {
                Status.ForeColor = System.Drawing.Color.Green;
                Status.Text = "Currently: Forgeing gloves";
            }
            if (statusindicator == 5)
            {
                Status.ForeColor = System.Drawing.Color.Green;
                Status.Text = "Currently: Pending/Wait for salvage";
            }

        }



        // TEST MOVING THE WINDOW //
        private void testTimer1_Tick(object sender, EventArgs e)
        {
            if (isPressed(Keys.F7))
            {
                //    Random r = new Random();
                //Move the window to posision X/Y (BAG)  (WORKS)
                //mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                //Cursor.Position = new Point(1524, 6);
                //System.Threading.Thread.Sleep(125);
                //mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

                //Move the window to posision X/Y (Vendor)  (WORKS)
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                Cursor.Position = new Point(553, 12);
                System.Threading.Thread.Sleep(125);
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

                //Open inventory(WORKS)
                //Cursor.Position = new Point((r.Next(105, 118)), (r.Next(10, 24)));
                //mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                //System.Threading.Thread.Sleep(r.Next(50, 100));
                //mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                //System.Threading.Thread.Sleep(r.Next(50, 100));

                //Focus on Merchant window
                //Cursor.Position = new Point((r.Next(529, 845)), (r.Next(22, 24)));
                //System.Threading.Thread.Sleep(r.Next(25, 50));
                //mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                //System.Threading.Thread.Sleep(r.Next(50, 100));
                //mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                //System.Threading.Thread.Sleep(r.Next(50, 100));

                //Focus Inventory window
                //Cursor.Position = new Point((r.Next(1525, 1777)), (r.Next(15, 28)));
                //System.Threading.Thread.Sleep(r.Next(25, 50));
                //mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                //System.Threading.Thread.Sleep(r.Next(50, 100));
                //mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                //System.Threading.Thread.Sleep(r.Next(50, 100));

                //Open Forge(click 1st bag slot)
                //Cursor.Position = new Point((r.Next(1525, 1541)), (r.Next(124, 147)));
                //System.Threading.Thread.Sleep(r.Next(50, 75));
                //mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                //System.Threading.Thread.Sleep(r.Next(25, 50));
                //mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                //System.Threading.Thread.Sleep(r.Next(25));
                //mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                //System.Threading.Thread.Sleep(r.Next(25, 50));
                //mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                //System.Threading.Thread.Sleep(r.Next(250, 350));
                //this.Close();

            }
        }

        private void Realforge_Tick(object sender, EventArgs e)
        {
            //if (isPressed(Keys.F6))
            //{
            //    Random r = new Random();
            //    //obj 1
            //    Cursor.Position = new Point((r.Next(520, 560)), (r.Next(240, 290)));
            //    System.Threading.Thread.Sleep(r.Next(50, 201));
            //    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            //    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            //    System.Threading.Thread.Sleep(r.Next(50, 78));
            //    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            //    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            //    System.Threading.Thread.Sleep(r.Next(50, 201));
            //    // Obj 2
            //    Cursor.Position = new Point((r.Next(577, 627)), (r.Next(240, 290)));
            //    System.Threading.Thread.Sleep(r.Next(124, 201));
            //    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            //    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            //    System.Threading.Thread.Sleep(50);
            //    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            //    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            //    System.Threading.Thread.Sleep(r.Next(50, 201));
            //    //Obj 3
            //    Cursor.Position = new Point((r.Next(640, 685)), (r.Next(240, 290)));
            //    System.Threading.Thread.Sleep(r.Next(50, 201));
            //    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            //    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            //    System.Threading.Thread.Sleep(50);
            //    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            //    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            //    System.Threading.Thread.Sleep(r.Next(50, 201));
            //    //obj 4
            //    Cursor.Position = new Point((r.Next(695, 745)), (r.Next(240, 290)));
            //    System.Threading.Thread.Sleep(r.Next(50, 201));
            //    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            //    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            //    System.Threading.Thread.Sleep(50);
            //    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            //    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            //    System.Threading.Thread.Sleep(r.Next(102, 231));
            //    //press Ok.
            //    Cursor.Position = new Point((r.Next(1080, 1125)), (r.Next(700, 715)));
            //    System.Threading.Thread.Sleep(125);
            //    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            //    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            //    System.Threading.Thread.Sleep(r.Next(1703, 1852));
            //}

        }








    }
}
