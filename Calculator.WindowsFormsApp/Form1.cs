using System.Drawing.Text;

namespace Calculator.WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public enum Operation
        {
            None,
            Addition,
            Substraction,
            Division,
            MultiPlication
        }
        private String _firstValue;
        private String _secondValue;
        private Operation _currentOperation = Operation.None;
        private bool _isTheResultOnTheScreen;
        public Form1()
        {
            InitializeComponent();
            btnText.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void btnText_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnBtnNumberClick(object sender, EventArgs e)
        {
            var ClickedValue = (sender as Button).Text;

            if (btnText.Text == "0" && ClickedValue != ",")
            {
                btnText.Text = string.Empty;
            }
            if (_isTheResultOnTheScreen)
            {
                _isTheResultOnTheScreen = false;
                btnText.Text = string.Empty;

                if (ClickedValue == "," )
                {
                    ClickedValue = "0,";
                }
            }

            btnText.Text += ClickedValue;
            SetResultBtnState(true);

            if (_currentOperation != Operation.None)
            {
                _secondValue += ClickedValue;
            }
            else
            {
                SetOperationBtnState(true);
            }
        }

        private void OnBtnOperationClick(object sender, EventArgs e)
        {
            _firstValue = btnText.Text;

            var operation = (sender as Button).Text;

            _currentOperation = operation switch
            {
                "+" => Operation.Addition,
                "-" => Operation.Substraction,
                "*" => Operation.MultiPlication,
                "/" => Operation.Division,
                _ => Operation.None,

            };
            

            btnText.Text += $"{operation}";

            if (_isTheResultOnTheScreen)
            {
                _isTheResultOnTheScreen = false;
            }

            SetOperationBtnState(false);
            SetResultBtnState(false);
        }

        private void OnBtnResultClick(object sender, EventArgs e)
        {
            var firstNumber = double.Parse(_firstValue);
            var secondNumber = double.Parse(_secondValue);

            var result = Calculate(firstNumber, secondNumber);

            btnText.Text = result.ToString();
            _secondValue = string.Empty;
            _currentOperation = Operation.None;
            _isTheResultOnTheScreen = true;
            SetOperationBtnState(true);
            SetResultBtnState(true );
        }

        private double Calculate(double firstNumber, double secondNumber)
        {
            switch (_currentOperation)
            {
                case Operation.None:
                    return firstNumber;
                case Operation.Addition:
                    return firstNumber + secondNumber;
                case Operation.Substraction:
                    return firstNumber - secondNumber;
                case Operation.MultiPlication:
                    return firstNumber * secondNumber;
                case Operation.Division:
                    return firstNumber / secondNumber;
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Nie mo¿na dzielic przez 0");
                    }
                    return 0;
                    return firstNumber / secondNumber;
            }
            return 0;
        }

        private void OnBtnClearClick(object sender, EventArgs e)
        {
            btnText.Text = "0";
            _firstValue = string.Empty;
            _secondValue = string.Empty;
            _currentOperation = Operation.None;
        }

        private void SetOperationBtnState(bool value)
        {
            btnDziel.Enabled = value;
            btnMinus.Enabled = value;
            btnPlus.Enabled = value;
            btnTimes.Enabled = value;
        }
        private void SetResultBtnState(bool value)
        {
            btnEquals.Enabled = value;
        }
    }
}
