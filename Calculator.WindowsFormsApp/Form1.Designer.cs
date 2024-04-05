namespace Calculator.WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnText = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            btnComma = new Button();
            btnDziel = new Button();
            btnMinus = new Button();
            btnTimes = new Button();
            btnPlus = new Button();
            btnEquals = new Button();
            btnC = new Button();
            SuspendLayout();
            // 
            // btnText
            // 
            btnText.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnText.Location = new Point(12, 12);
            btnText.Name = "btnText";
            btnText.Size = new Size(625, 43);
            btnText.TabIndex = 0;
            btnText.TextAlign = HorizontalAlignment.Right;
            btnText.TextChanged += btnText_TextChanged;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(192, 255, 192);
            btn7.Location = new Point(12, 70);
            btn7.Name = "btn7";
            btn7.Size = new Size(110, 90);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += OnBtnNumberClick;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(192, 255, 192);
            btn8.Location = new Point(141, 70);
            btn8.Name = "btn8";
            btn8.Size = new Size(103, 90);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += OnBtnNumberClick;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(192, 255, 192);
            btn9.Location = new Point(273, 70);
            btn9.Name = "btn9";
            btn9.Size = new Size(103, 90);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += OnBtnNumberClick;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(192, 255, 192);
            btn4.Location = new Point(12, 189);
            btn4.Name = "btn4";
            btn4.Size = new Size(103, 90);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += OnBtnNumberClick;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(192, 255, 192);
            btn5.Location = new Point(141, 189);
            btn5.Name = "btn5";
            btn5.Size = new Size(103, 90);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += OnBtnNumberClick;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(192, 255, 192);
            btn6.Location = new Point(273, 189);
            btn6.Name = "btn6";
            btn6.Size = new Size(103, 90);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += OnBtnNumberClick;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(192, 255, 192);
            btn1.Location = new Point(12, 304);
            btn1.Name = "btn1";
            btn1.Size = new Size(103, 90);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += OnBtnNumberClick;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(192, 255, 192);
            btn2.Location = new Point(141, 304);
            btn2.Name = "btn2";
            btn2.Size = new Size(103, 90);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += OnBtnNumberClick;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(192, 255, 192);
            btn3.Location = new Point(273, 304);
            btn3.Name = "btn3";
            btn3.Size = new Size(103, 90);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += OnBtnNumberClick;
            // 
            // btn0
            // 
            btn0.Location = new Point(12, 407);
            btn0.Name = "btn0";
            btn0.Size = new Size(232, 90);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += OnBtnNumberClick;
            // 
            // btnComma
            // 
            btnComma.Location = new Point(273, 407);
            btnComma.Name = "btnComma";
            btnComma.Size = new Size(103, 90);
            btnComma.TabIndex = 11;
            btnComma.Text = ",";
            btnComma.UseVisualStyleBackColor = true;
            btnComma.Click += OnBtnNumberClick;
            // 
            // btnDziel
            // 
            btnDziel.BackColor = Color.LightCoral;
            btnDziel.Location = new Point(396, 70);
            btnDziel.Name = "btnDziel";
            btnDziel.Size = new Size(103, 90);
            btnDziel.TabIndex = 12;
            btnDziel.Text = "/";
            btnDziel.UseVisualStyleBackColor = false;
            btnDziel.Click += OnBtnOperationClick;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.LightCoral;
            btnMinus.Location = new Point(396, 189);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(103, 90);
            btnMinus.TabIndex = 13;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += OnBtnOperationClick;
            // 
            // btnTimes
            // 
            btnTimes.BackColor = Color.LightCoral;
            btnTimes.Location = new Point(396, 304);
            btnTimes.Name = "btnTimes";
            btnTimes.Size = new Size(103, 90);
            btnTimes.TabIndex = 14;
            btnTimes.Text = "*";
            btnTimes.UseVisualStyleBackColor = false;
            btnTimes.Click += OnBtnOperationClick;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(527, 70);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(103, 209);
            btnPlus.TabIndex = 15;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += OnBtnOperationClick;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(527, 304);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(103, 193);
            btnEquals.TabIndex = 16;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += OnBtnResultClick;
            // 
            // btnC
            // 
            btnC.Location = new Point(396, 412);
            btnC.Name = "btnC";
            btnC.Size = new Size(103, 90);
            btnC.TabIndex = 17;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += OnBtnClearClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(655, 520);
            Controls.Add(btnC);
            Controls.Add(btnEquals);
            Controls.Add(btnPlus);
            Controls.Add(btnTimes);
            Controls.Add(btnMinus);
            Controls.Add(btnDziel);
            Controls.Add(btnComma);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox btnText;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn0;
        private Button btnComma;
        private Button btnDziel;
        private Button btnMinus;
        private Button btnTimes;
        private Button btnPlus;
        private Button btnEquals;
        private Button btnC;
    }
}
