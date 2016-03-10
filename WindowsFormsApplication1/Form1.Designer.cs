namespace WindowsFormsApplication1
{
    partial class CalcForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcForm));
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ClearEntryButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.PercentButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.PlusMinusButton = new System.Windows.Forms.Button();
            this.ModButton = new System.Windows.Forms.Button();
            this.SinButton = new System.Windows.Forms.Button();
            this.CosButton = new System.Windows.Forms.Button();
            this.TanButton = new System.Windows.Forms.Button();
            this.FacButton = new System.Windows.Forms.Button();
            this.LogButton = new System.Windows.Forms.Button();
            this.ExpButton = new System.Windows.Forms.Button();
            this.RadikalButton = new System.Windows.Forms.Button();
            this.CotButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.BackColor = System.Drawing.Color.Peru;
            this.DisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisplayTextBox.ForeColor = System.Drawing.Color.Black;
            this.DisplayTextBox.Location = new System.Drawing.Point(12, 12);
            this.DisplayTextBox.Multiline = true;
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.ReadOnly = true;
            this.DisplayTextBox.Size = new System.Drawing.Size(477, 32);
            this.DisplayTextBox.TabIndex = 0;
            this.DisplayTextBox.Text = "0";
            this.DisplayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.Color.Crimson;
            this.OneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OneButton.ForeColor = System.Drawing.Color.White;
            this.OneButton.Location = new System.Drawing.Point(12, 173);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(64, 44);
            this.OneButton.TabIndex = 1;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.Crimson;
            this.TwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TwoButton.ForeColor = System.Drawing.Color.White;
            this.TwoButton.Location = new System.Drawing.Point(82, 173);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(64, 44);
            this.TwoButton.TabIndex = 2;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.Color.Crimson;
            this.ThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThreeButton.ForeColor = System.Drawing.Color.White;
            this.ThreeButton.Location = new System.Drawing.Point(152, 173);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(64, 44);
            this.ThreeButton.TabIndex = 3;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultiplyButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MultiplyButton.Location = new System.Drawing.Point(311, 149);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(46, 31);
            this.MultiplyButton.TabIndex = 4;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = false;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.DivideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DivideButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DivideButton.Location = new System.Drawing.Point(363, 149);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(44, 31);
            this.DivideButton.TabIndex = 5;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = false;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.MinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinusButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinusButton.Location = new System.Drawing.Point(363, 112);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(44, 31);
            this.MinusButton.TabIndex = 10;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = false;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlusButton.Location = new System.Drawing.Point(311, 112);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(46, 31);
            this.PlusButton.TabIndex = 9;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = false;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.Color.Crimson;
            this.SixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SixButton.ForeColor = System.Drawing.Color.White;
            this.SixButton.Location = new System.Drawing.Point(152, 123);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(64, 44);
            this.SixButton.TabIndex = 8;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.Color.Crimson;
            this.FiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FiveButton.ForeColor = System.Drawing.Color.White;
            this.FiveButton.Location = new System.Drawing.Point(82, 123);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(64, 44);
            this.FiveButton.TabIndex = 7;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.Crimson;
            this.FourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FourButton.ForeColor = System.Drawing.Color.White;
            this.FourButton.Location = new System.Drawing.Point(12, 123);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(64, 44);
            this.FourButton.TabIndex = 6;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearButton.Location = new System.Drawing.Point(363, 73);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(44, 33);
            this.ClearButton.TabIndex = 15;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ClearEntryButton
            // 
            this.ClearEntryButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClearEntryButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearEntryButton.Location = new System.Drawing.Point(311, 73);
            this.ClearEntryButton.Name = "ClearEntryButton";
            this.ClearEntryButton.Size = new System.Drawing.Size(46, 33);
            this.ClearEntryButton.TabIndex = 14;
            this.ClearEntryButton.Text = "CE";
            this.ClearEntryButton.UseVisualStyleBackColor = false;
            this.ClearEntryButton.Click += new System.EventHandler(this.ClearEntryButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.Color.Crimson;
            this.NineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NineButton.ForeColor = System.Drawing.Color.White;
            this.NineButton.Location = new System.Drawing.Point(152, 73);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(64, 44);
            this.NineButton.TabIndex = 13;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.Color.Crimson;
            this.EightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EightButton.ForeColor = System.Drawing.Color.White;
            this.EightButton.Location = new System.Drawing.Point(82, 73);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(64, 44);
            this.EightButton.TabIndex = 12;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.Crimson;
            this.SevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SevenButton.ForeColor = System.Drawing.Color.White;
            this.SevenButton.Location = new System.Drawing.Point(12, 73);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(64, 44);
            this.SevenButton.TabIndex = 11;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // EqualButton
            // 
            this.EqualButton.BackColor = System.Drawing.Color.Red;
            this.EqualButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqualButton.ForeColor = System.Drawing.SystemColors.Control;
            this.EqualButton.Location = new System.Drawing.Point(423, 225);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(88, 42);
            this.EqualButton.TabIndex = 20;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = false;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // PercentButton
            // 
            this.PercentButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.PercentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PercentButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PercentButton.Location = new System.Drawing.Point(311, 186);
            this.PercentButton.Name = "PercentButton";
            this.PercentButton.Size = new System.Drawing.Size(46, 33);
            this.PercentButton.TabIndex = 19;
            this.PercentButton.Text = "%";
            this.PercentButton.UseVisualStyleBackColor = false;
            this.PercentButton.Click += new System.EventHandler(this.PercentButton_Click);
            // 
            // DotButton
            // 
            this.DotButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DotButton.Location = new System.Drawing.Point(152, 223);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(64, 44);
            this.DotButton.TabIndex = 18;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = false;
            this.DotButton.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.Color.Crimson;
            this.ZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZeroButton.ForeColor = System.Drawing.Color.White;
            this.ZeroButton.Location = new System.Drawing.Point(82, 223);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(64, 44);
            this.ZeroButton.TabIndex = 17;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // PlusMinusButton
            // 
            this.PlusMinusButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PlusMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusMinusButton.Location = new System.Drawing.Point(12, 223);
            this.PlusMinusButton.Name = "PlusMinusButton";
            this.PlusMinusButton.Size = new System.Drawing.Size(64, 44);
            this.PlusMinusButton.TabIndex = 16;
            this.PlusMinusButton.Text = "+/-";
            this.PlusMinusButton.UseVisualStyleBackColor = false;
            this.PlusMinusButton.Click += new System.EventHandler(this.PlusMinusButton_Click);
            // 
            // ModButton
            // 
            this.ModButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ModButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModButton.Location = new System.Drawing.Point(363, 186);
            this.ModButton.Name = "ModButton";
            this.ModButton.Size = new System.Drawing.Size(44, 33);
            this.ModButton.TabIndex = 21;
            this.ModButton.Text = "Mod";
            this.ModButton.UseVisualStyleBackColor = false;
            this.ModButton.Click += new System.EventHandler(this.ModButton_Click);
            // 
            // SinButton
            // 
            this.SinButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SinButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SinButton.Location = new System.Drawing.Point(413, 73);
            this.SinButton.Name = "SinButton";
            this.SinButton.Size = new System.Drawing.Size(46, 33);
            this.SinButton.TabIndex = 22;
            this.SinButton.Text = "sin";
            this.SinButton.UseVisualStyleBackColor = false;
            this.SinButton.Click += new System.EventHandler(this.SinButton_Click);
            // 
            // CosButton
            // 
            this.CosButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CosButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CosButton.Location = new System.Drawing.Point(413, 112);
            this.CosButton.Name = "CosButton";
            this.CosButton.Size = new System.Drawing.Size(46, 31);
            this.CosButton.TabIndex = 23;
            this.CosButton.Text = "cos";
            this.CosButton.UseVisualStyleBackColor = false;
            this.CosButton.Click += new System.EventHandler(this.CosButton_Click);
            // 
            // TanButton
            // 
            this.TanButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.TanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TanButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TanButton.Location = new System.Drawing.Point(413, 149);
            this.TanButton.Name = "TanButton";
            this.TanButton.Size = new System.Drawing.Size(46, 31);
            this.TanButton.TabIndex = 24;
            this.TanButton.Text = "tan";
            this.TanButton.UseVisualStyleBackColor = false;
            this.TanButton.Click += new System.EventHandler(this.TanButton_Click);
            // 
            // FacButton
            // 
            this.FacButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.FacButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FacButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FacButton.Location = new System.Drawing.Point(465, 73);
            this.FacButton.Name = "FacButton";
            this.FacButton.Size = new System.Drawing.Size(46, 33);
            this.FacButton.TabIndex = 26;
            this.FacButton.Text = "n!";
            this.FacButton.UseVisualStyleBackColor = false;
            this.FacButton.Click += new System.EventHandler(this.FacButton_Click);
            // 
            // LogButton
            // 
            this.LogButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.LogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LogButton.Location = new System.Drawing.Point(465, 111);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(46, 33);
            this.LogButton.TabIndex = 27;
            this.LogButton.Text = "log";
            this.LogButton.UseVisualStyleBackColor = false;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // ExpButton
            // 
            this.ExpButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ExpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExpButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExpButton.Location = new System.Drawing.Point(465, 148);
            this.ExpButton.Name = "ExpButton";
            this.ExpButton.Size = new System.Drawing.Size(46, 33);
            this.ExpButton.TabIndex = 28;
            this.ExpButton.Text = "Exp";
            this.ExpButton.UseVisualStyleBackColor = false;
            this.ExpButton.Click += new System.EventHandler(this.ExpButton_Click);
            // 
            // RadikalButton
            // 
            this.RadikalButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.RadikalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadikalButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RadikalButton.Location = new System.Drawing.Point(465, 186);
            this.RadikalButton.Name = "RadikalButton";
            this.RadikalButton.Size = new System.Drawing.Size(46, 33);
            this.RadikalButton.TabIndex = 29;
            this.RadikalButton.Text = "√";
            this.RadikalButton.UseVisualStyleBackColor = false;
            this.RadikalButton.Click += new System.EventHandler(this.RadikalButton_Click);
            // 
            // CotButton
            // 
            this.CotButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CotButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CotButton.Location = new System.Drawing.Point(413, 186);
            this.CotButton.Name = "CotButton";
            this.CotButton.Size = new System.Drawing.Size(46, 33);
            this.CotButton.TabIndex = 25;
            this.CotButton.Text = "^2";
            this.CotButton.UseVisualStyleBackColor = false;
            this.CotButton.Click += new System.EventHandler(this.CotButton_Click);
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(530, 365);
            this.Controls.Add(this.RadikalButton);
            this.Controls.Add(this.ExpButton);
            this.Controls.Add(this.LogButton);
            this.Controls.Add(this.FacButton);
            this.Controls.Add(this.CotButton);
            this.Controls.Add(this.TanButton);
            this.Controls.Add(this.CosButton);
            this.Controls.Add(this.SinButton);
            this.Controls.Add(this.ModButton);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.PercentButton);
            this.Controls.Add(this.DotButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.PlusMinusButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ClearEntryButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.DisplayTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalcForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator_by_Manas_Programmers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DisplayTextBox;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ClearEntryButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button PercentButton;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button PlusMinusButton;
        private System.Windows.Forms.Button ModButton;
        private System.Windows.Forms.Button SinButton;
        private System.Windows.Forms.Button CosButton;
        private System.Windows.Forms.Button TanButton;
        private System.Windows.Forms.Button FacButton;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.Button ExpButton;
        private System.Windows.Forms.Button RadikalButton;
        private System.Windows.Forms.Button CotButton;
    }
}

