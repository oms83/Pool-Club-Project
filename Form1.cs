using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Club_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctrlTable1_OnTableComplate(object sender, ctrlTable.TableComplateEventArgs e)
        {
            MessageBox.Show($"Time Consumed: {e.TimeText}\nTotal Second: {e.TimeInSecond}\nHourly Rate: {e.RatePerHour}\nTotal Fees: {e.TotalFees}");
        }

        private void ctrlTable2_OnTableComplate(object sender, ctrlTable.TableComplateEventArgs e)
        {
            MessageBox.Show($"Time Consumed: {e.TimeText}\nTotal Second: {e.TimeInSecond}\nHourly Rate: {e.RatePerHour}\nTotal Fees: {e.TotalFees}");
        }

        private void ctrlTable3_OnTableComplate(object sender, ctrlTable.TableComplateEventArgs e)
        {
            MessageBox.Show($"Time Consumed: {e.TimeText}\nTotal Second: {e.TimeInSecond}\nHourly Rate: {e.RatePerHour}\nTotal Fees: {e.TotalFees}");
        }

        private void ctrlTable4_OnTableComplate(object sender, ctrlTable.TableComplateEventArgs e)
        {
            MessageBox.Show($"Time Consumed: {e.TimeText}\nTotal Second: {e.TimeInSecond}\nHourly Rate: {e.RatePerHour}\nTotal Fees: {e.TotalFees}");
        }

        private void ctrlTable5_OnTableComplate(object sender, ctrlTable.TableComplateEventArgs e)
        {
            MessageBox.Show($"Time Consumed: {e.TimeText}\nTotal Second: {e.TimeInSecond}\nHourly Rate: {e.RatePerHour}\nTotal Fees: {e.TotalFees}");
        }

        private void ctrlTable6_OnTableComplate(object sender, ctrlTable.TableComplateEventArgs e)
        {
            MessageBox.Show($"Time Consumed: {e.TimeText}\nTotal Second: {e.TimeInSecond}\nHourly Rate: {e.RatePerHour}\nTotal Fees: {e.TotalFees}");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
