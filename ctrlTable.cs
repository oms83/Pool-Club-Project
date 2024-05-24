using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Pool_Club_Project
{
    public partial class ctrlTable : UserControl
    {
        public ctrlTable()
        {
            InitializeComponent();
        }

        private bool _IsTimerEnabled = false;
        private int elapsedSeconds = 0;

        private float _HourlyRate = 10;
        private string _TablePlayer = "Player Name";
        private string _TableTitle = "Table";


        [
            Category("Pool Config"),
            Description("Rate per hour")
        ]
        public float HourlyRate
        {
            get => _HourlyRate;
            set => _HourlyRate = value;
        }


        [
            Category("Pool Config"),
            Description("The player name")
        ]
        public string TablePlayer
        {
            get => _TablePlayer;
            set
            {

                _TablePlayer = value;
                lblPlayerName.Text = _TablePlayer;
            }
        }


        [
           Category("Pool Config"),
           Description("The table name")
        ]
        public string TableTitle
        {
            get { return _TableTitle; }
            set
            {
                _TableTitle = value;
                gbTable.Text = _TableTitle;
            }
        }

        public class TableComplateEventArgs : EventArgs
        {
            public float RatePerHour {  get; }
            public string TimeText { get; }
            public int TimeInSecond { get; }
            public float TotalFees { get; }

            public TableComplateEventArgs(float RateParHour, float TotalFees, int TimeInSecond, string TimeText)
            {
                this.RatePerHour = RateParHour;
                this.TotalFees = TotalFees;
                this.TimeText = TimeText;
                this.TimeInSecond = TimeInSecond;
            }
        }

        public event EventHandler<TableComplateEventArgs> OnTableComplate;
        protected virtual void RaiseTableComplate(TableComplateEventArgs e)
        {
            OnTableComplate?.Invoke(this, e);
        }
        public void RaiseTableComplate()
        {
            RaiseTableComplate(new TableComplateEventArgs(_HourlyRate, _GetTotalFees(), elapsedSeconds, lblTimer.Text));
        }

        private float _GetTotalFees()
        {
            return ((float)(HourlyRate) * ((float)(elapsedSeconds) / 3600));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++;
            TimeSpan elapsedTime = TimeSpan.FromSeconds(elapsedSeconds);    
            lblTimer.Text = elapsedTime.ToString(@"hh\:mm\:ss");
        }

        private void _StartTimer()
        {
            timer1.Start();
            btnEnd.Enabled = true;
        }
        
        private void _StopTimer()
        {
            timer1.Stop();
        }

        private void _Reset()
        {
            elapsedSeconds = 0;
            lblTimer.Text = "00:00:00";
            _IsTimerEnabled = false;
            btnStart.Text = "Start";
            btnEnd.Enabled = false;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            _StopTimer();
            RaiseTableComplate();
            _Reset();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!_IsTimerEnabled)
            {
                _StartTimer();
                btnStart.Text = "Stop";
            }
            else
            {
                btnStart.Text = "Start";
                _StopTimer();
            }

            _IsTimerEnabled = !_IsTimerEnabled;
        }

        private void ctrlTable_Load(object sender, EventArgs e)
        {
            if (elapsedSeconds == 0)
            {
                btnEnd.Enabled = false;
            }
        }

        private void btnEnd_EnabledChanged(object sender, EventArgs e)
        {
            if (btnEnd.Enabled)
            {
                btnEnd.ForeColor = Color.Red;
            }
        }
    }
}
