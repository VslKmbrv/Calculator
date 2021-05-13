
namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MultiplicationButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.DecimalComa = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.AdditionButton = new System.Windows.Forms.Button();
            this.SubtractionButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.SquareRootButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.ClearEntryButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BackspaceButton = new System.Windows.Forms.Button();
            this.MClearButton = new System.Windows.Forms.Button();
            this.MRecallButton = new System.Windows.Forms.Button();
            this.MPlusButton = new System.Windows.Forms.Button();
            this.MMinusButton = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.lblShowOperations = new System.Windows.Forms.Label();
            this.MSbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MultiplicationButton.Location = new System.Drawing.Point(355, 372);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(108, 50);
            this.MultiplicationButton.TabIndex = 0;
            this.MultiplicationButton.Text = "×";
            this.MultiplicationButton.UseVisualStyleBackColor = true;
            this.MultiplicationButton.Click += new System.EventHandler(this.operators_Click);
            // 
            // NineButton
            // 
            this.NineButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NineButton.Location = new System.Drawing.Point(241, 372);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(108, 50);
            this.NineButton.TabIndex = 1;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.numbers_Only);
            // 
            // EightButton
            // 
            this.EightButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EightButton.Location = new System.Drawing.Point(127, 372);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(108, 50);
            this.EightButton.TabIndex = 2;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.numbers_Only);
            // 
            // SevenButton
            // 
            this.SevenButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SevenButton.Location = new System.Drawing.Point(13, 372);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(108, 50);
            this.SevenButton.TabIndex = 3;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.numbers_Only);
            // 
            // FourButton
            // 
            this.FourButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FourButton.Location = new System.Drawing.Point(13, 428);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(108, 50);
            this.FourButton.TabIndex = 4;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.numbers_Only);
            // 
            // FiveButton
            // 
            this.FiveButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FiveButton.Location = new System.Drawing.Point(127, 428);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(108, 50);
            this.FiveButton.TabIndex = 5;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.numbers_Only);
            // 
            // OneButton
            // 
            this.OneButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OneButton.Location = new System.Drawing.Point(13, 484);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(108, 50);
            this.OneButton.TabIndex = 6;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.numbers_Only);
            // 
            // TwoButton
            // 
            this.TwoButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TwoButton.Location = new System.Drawing.Point(127, 484);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(108, 50);
            this.TwoButton.TabIndex = 7;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.numbers_Only);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThreeButton.Location = new System.Drawing.Point(240, 484);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(108, 50);
            this.ThreeButton.TabIndex = 8;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.numbers_Only);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ZeroButton.Location = new System.Drawing.Point(14, 540);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(221, 50);
            this.ZeroButton.TabIndex = 9;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.numbers_Only);
            // 
            // DecimalComa
            // 
            this.DecimalComa.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DecimalComa.Location = new System.Drawing.Point(240, 540);
            this.DecimalComa.Name = "DecimalComa";
            this.DecimalComa.Size = new System.Drawing.Size(108, 50);
            this.DecimalComa.TabIndex = 10;
            this.DecimalComa.Text = ",";
            this.DecimalComa.UseVisualStyleBackColor = true;
            this.DecimalComa.Click += new System.EventHandler(this.numbers_Only);
            // 
            // EqualButton
            // 
            this.EqualButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EqualButton.Location = new System.Drawing.Point(354, 540);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(108, 50);
            this.EqualButton.TabIndex = 11;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = true;
            this.EqualButton.Click += new System.EventHandler(this.bntEquals_Click);
            // 
            // AdditionButton
            // 
            this.AdditionButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdditionButton.Location = new System.Drawing.Point(355, 484);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(108, 50);
            this.AdditionButton.TabIndex = 12;
            this.AdditionButton.Text = "+";
            this.AdditionButton.UseVisualStyleBackColor = true;
            this.AdditionButton.Click += new System.EventHandler(this.operators_Click);
            // 
            // SubtractionButton
            // 
            this.SubtractionButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubtractionButton.Location = new System.Drawing.Point(355, 428);
            this.SubtractionButton.Name = "SubtractionButton";
            this.SubtractionButton.Size = new System.Drawing.Size(108, 50);
            this.SubtractionButton.TabIndex = 13;
            this.SubtractionButton.Text = "-";
            this.SubtractionButton.UseVisualStyleBackColor = true;
            this.SubtractionButton.Click += new System.EventHandler(this.operators_Click);
            // 
            // DivisionButton
            // 
            this.DivisionButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DivisionButton.Location = new System.Drawing.Point(354, 316);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(108, 50);
            this.DivisionButton.TabIndex = 15;
            this.DivisionButton.Text = "÷";
            this.DivisionButton.UseVisualStyleBackColor = true;
            this.DivisionButton.Click += new System.EventHandler(this.operators_Click);
            // 
            // SquareRootButton
            // 
            this.SquareRootButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SquareRootButton.Location = new System.Drawing.Point(240, 316);
            this.SquareRootButton.Name = "SquareRootButton";
            this.SquareRootButton.Size = new System.Drawing.Size(108, 50);
            this.SquareRootButton.TabIndex = 16;
            this.SquareRootButton.Text = "√";
            this.SquareRootButton.UseVisualStyleBackColor = true;
            this.SquareRootButton.Click += new System.EventHandler(this.SquareRootButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SixButton.Location = new System.Drawing.Point(240, 428);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(108, 50);
            this.SixButton.TabIndex = 18;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.numbers_Only);
            // 
            // ClearEntryButton
            // 
            this.ClearEntryButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearEntryButton.Location = new System.Drawing.Point(240, 261);
            this.ClearEntryButton.Name = "ClearEntryButton";
            this.ClearEntryButton.Size = new System.Drawing.Size(108, 50);
            this.ClearEntryButton.TabIndex = 21;
            this.ClearEntryButton.Text = "CE";
            this.ClearEntryButton.UseVisualStyleBackColor = true;
            this.ClearEntryButton.Click += new System.EventHandler(this.ClearEntryButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(354, 261);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(108, 50);
            this.ClearButton.TabIndex = 22;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // BackspaceButton
            // 
            this.BackspaceButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackspaceButton.Location = new System.Drawing.Point(240, 205);
            this.BackspaceButton.Name = "BackspaceButton";
            this.BackspaceButton.Size = new System.Drawing.Size(222, 50);
            this.BackspaceButton.TabIndex = 23;
            this.BackspaceButton.Text = "⌫";
            this.BackspaceButton.UseVisualStyleBackColor = true;
            this.BackspaceButton.Click += new System.EventHandler(this.BackspaceButton_Click);
            // 
            // MClearButton
            // 
            this.MClearButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MClearButton.Location = new System.Drawing.Point(14, 205);
            this.MClearButton.Name = "MClearButton";
            this.MClearButton.Size = new System.Drawing.Size(108, 50);
            this.MClearButton.TabIndex = 24;
            this.MClearButton.Text = "MC";
            this.MClearButton.UseVisualStyleBackColor = true;
            this.MClearButton.Click += new System.EventHandler(this.MC_Click);
            // 
            // MRecallButton
            // 
            this.MRecallButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MRecallButton.Location = new System.Drawing.Point(128, 205);
            this.MRecallButton.Name = "MRecallButton";
            this.MRecallButton.Size = new System.Drawing.Size(108, 50);
            this.MRecallButton.TabIndex = 25;
            this.MRecallButton.Text = "MR";
            this.MRecallButton.UseVisualStyleBackColor = true;
            this.MRecallButton.Click += new System.EventHandler(this.MR_Click);
            // 
            // MPlusButton
            // 
            this.MPlusButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MPlusButton.Location = new System.Drawing.Point(14, 261);
            this.MPlusButton.Name = "MPlusButton";
            this.MPlusButton.Size = new System.Drawing.Size(108, 50);
            this.MPlusButton.TabIndex = 26;
            this.MPlusButton.Text = "M+";
            this.MPlusButton.UseVisualStyleBackColor = true;
            this.MPlusButton.Click += new System.EventHandler(this.MPlus_Click);
            // 
            // MMinusButton
            // 
            this.MMinusButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MMinusButton.Location = new System.Drawing.Point(128, 261);
            this.MMinusButton.Name = "MMinusButton";
            this.MMinusButton.Size = new System.Drawing.Size(108, 50);
            this.MMinusButton.TabIndex = 27;
            this.MMinusButton.Text = "M-";
            this.MMinusButton.UseVisualStyleBackColor = true;
            this.MMinusButton.Click += new System.EventHandler(this.MMinus_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDisplay.Location = new System.Drawing.Point(14, 135);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(450, 64);
            this.txtDisplay.TabIndex = 28;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblShowOperations
            // 
            this.lblShowOperations.AutoSize = true;
            this.lblShowOperations.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShowOperations.Location = new System.Drawing.Point(386, 104);
            this.lblShowOperations.Name = "lblShowOperations";
            this.lblShowOperations.Size = new System.Drawing.Size(0, 25);
            this.lblShowOperations.TabIndex = 29;
            // 
            // MSbutton
            // 
            this.MSbutton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MSbutton.Location = new System.Drawing.Point(14, 316);
            this.MSbutton.Name = "MSbutton";
            this.MSbutton.Size = new System.Drawing.Size(222, 50);
            this.MSbutton.TabIndex = 30;
            this.MSbutton.Text = "MS";
            this.MSbutton.UseVisualStyleBackColor = true;
            this.MSbutton.Click += new System.EventHandler(this.MS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 602);
            this.Controls.Add(this.MSbutton);
            this.Controls.Add(this.lblShowOperations);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.MMinusButton);
            this.Controls.Add(this.MPlusButton);
            this.Controls.Add(this.MRecallButton);
            this.Controls.Add(this.MClearButton);
            this.Controls.Add(this.BackspaceButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ClearEntryButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.SquareRootButton);
            this.Controls.Add(this.DivisionButton);
            this.Controls.Add(this.SubtractionButton);
            this.Controls.Add(this.AdditionButton);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.DecimalComa);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.MultiplicationButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator by Vasil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MultiplicationButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button DecimalComa;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button AdditionButton;
        private System.Windows.Forms.Button SubtractionButton;
        private System.Windows.Forms.Button DivisionButton;
        private System.Windows.Forms.Button SquareRootButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button ClearEntryButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button BackspaceButton;
        private System.Windows.Forms.Button MClearButton;
        private System.Windows.Forms.Button MRecallButton;
        private System.Windows.Forms.Button MPlusButton;
        private System.Windows.Forms.Button MMinusButton;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label lblShowOperations;
        private System.Windows.Forms.Button MSbutton;
    }
}

