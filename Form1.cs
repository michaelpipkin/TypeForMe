using System.Security.Cryptography;

namespace TypeForMe
{
    public partial class Form1 : Form
    {
        private int _interval = 60;
        private bool _type = false;
        private CancellationTokenSource _source = new();
        private const int LOWERBOUND = 97;
        private const int UPPERBOUND = 123;

        public Form1() {
            InitializeComponent();
            SecondsTextBox.Text = _interval.ToString();
            if (!RandomCheckBox.Checked) {
                KeyTextBox.Text = GetRandomCharacter();
            }
        }

        private async void Button_Click(object sender, EventArgs e) {
            var button = (Button)sender;
            if (_type) {
                _type = false;
                _source.Cancel();
                button.Text = "Start";
                countdownLabel.Text = string.Empty;
            } else {
                _type = true;
                var timeRemaining = _interval;
                button.Text = "Stop";
                countdownLabel.Text = _interval.ToString();
                _source = new CancellationTokenSource();
                if (string.IsNullOrEmpty(KeyTextBox.Text)) {
                    RandomCheckBox.Checked = true;
                }
                while (!_source.IsCancellationRequested) {
                    try {
                        await Task.Delay(1000, _source.Token);
                        countdownLabel.Text = (--timeRemaining).ToString();
                        if (timeRemaining == 0) {
                            if (RandomCheckBox.Checked) {
                                SendKeys.Send(GetRandomCharacter());
                            } else {
                                SendKeys.Send(KeyTextBox.Text);
                            }
                            if (DeleteCheckBox.Checked) {
                                SendKeys.Send("{BACKSPACE}");
                            }
                            timeRemaining = _interval;
                            countdownLabel.Text = _interval.ToString();
                        }
                    }
                    catch (OperationCanceledException) {
                        _source.Dispose();
                    }
                }
            }
        }

        private void SecondsTextBox_TextChanged(object sender, EventArgs e) {
            if (int.TryParse(((TextBox)sender).Text, out int seconds)) {
                _interval = seconds;
            } else {
                SecondsTextBox.Text = "60";
                _interval = 60;
                SecondsTextBox.Text = _interval.ToString();
            }
        }

        private void RandomCheckBox_CheckedChanged(object sender, EventArgs e) {
            var ckb = (CheckBox)sender;
            if (ckb.Checked) {
                KeyTextBox.Enabled = false;
                KeyTextBox.Text = string.Empty;
            } else {
                KeyTextBox.Enabled = true;
                KeyTextBox.Text = GetRandomCharacter();
            }
        }

        private static string GetRandomCharacter() {
            var character = (char)RandomNumberGenerator.GetInt32(LOWERBOUND, UPPERBOUND);
            if (RandomNumberGenerator.GetInt32(0, 2) == 1) {
                character -= (char)32;
            }
            return character.ToString();
        }
    }
}