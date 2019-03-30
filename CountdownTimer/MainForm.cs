using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountdownTimer
{
    public partial class MainForm : Form
    {
        private Status _status = Status.Stop;
        private int _currentSec = 0;
        private Setting _setting = Setting.GetSetting();

        public MainForm()
        {
            InitializeComponent();

            Task.Run(async () =>
            {
                while (true)
                {
                    if (_status != Status.Stop)
                    {
                        if (_currentSec > 0)
                        {
                            _currentSec--;
                        }
                        else if (_currentSec == 0)
                        {
                            _status = Status.Alert;
                        }

                        Reflash();
                    }

                    await Task.Delay(1000);
                }
            });
        }

        private void Reflash()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => { Reflash(); }));
                return;
            }

            switch (_status)
            {
                case Status.Stop:
                    btnOnOff.Text = "開始";
                    btnOnOff.BackColor = Color.Lime;
                    BackColor = Color.White;
                    break;
                case Status.Running:
                    btnOnOff.Text = "停止";
                    btnOnOff.BackColor = Color.Red;
                    BackColor = Color.White;
                    break;
                case Status.Alert:
                    if (BackColor == Color.White)
                    {
                        BackColor = Color.Yellow;
                    }
                    else
                    {
                        BackColor = Color.White;
                    }
                    break;
            }

            barTime.Value = _currentSec;

            TimeSpan time = TimeSpan.FromSeconds(_currentSec);
            lbRemainingTime.Text = time.ToString(@"hh\:mm\:ss");
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            switch (_status)
            {
                case Status.Stop:
                    //設為啟動
                    _status = Status.Running;
                    barTime.Maximum = GetMax();
                    _currentSec = GetMax();
                    break;
                default:
                    //設為停止
                    _status = Status.Stop;
                    _currentSec = 0;
                    break;
            }

            Reflash();
        }

        private int GetMax()
        {
            int.TryParse(txtHour.Text, out int hour);
            int.TryParse(txtMinute.Text, out int minute);
            int.TryParse(txtSecond.Text, out int second);

            return hour * 60 * 60 + minute * 60 + second;
        }

        private enum Status
        {
            Stop,
            Running,
            Alert
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var formTool = Tools.AuthResizeFormTool.Get(this);
            _setting.FormTool = formTool;
            _setting.Hour = txtHour.Text;
            _setting.Minute = txtMinute.Text;
            _setting.Second = txtSecond.Text;
            _setting.Save();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text += _setting.Version;

            var formTool = _setting.FormTool ?? new Tools.AuthResizeFormTool.FormInfo();
            Tools.AuthResizeFormTool.Set(this, formTool.Size, formTool.State, formTool.Location);

            txtHour.Text = _setting.Hour;
            txtMinute.Text = _setting.Minute;
            txtSecond.Text = _setting.Second;
        }
    }
}
