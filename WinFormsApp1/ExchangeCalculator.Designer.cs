namespace ExcahngeRates
{
    partial class ExchangeCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            label50 = new Label();
            label49 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(260, 29);
            label1.Name = "label1";
            label1.Size = new Size(256, 37);
            label1.TabIndex = 0;
            label1.Text = "Exchange Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(357, 152);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 1;
            label2.Text = "From:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(584, 152);
            label3.Name = "label3";
            label3.Size = new Size(36, 28);
            label3.TabIndex = 2;
            label3.Text = "To:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(301, 183);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(178, 23);
            comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(514, 183);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(180, 23);
            comboBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 23);
            textBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(151, 152);
            label4.Name = "label4";
            label4.Size = new Size(87, 28);
            label4.TabIndex = 6;
            label4.Text = "Amount:";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(310, 323);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 23);
            textBox2.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(324, 241);
            button1.Name = "button1";
            button1.Size = new Size(123, 57);
            button1.TabIndex = 9;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(236, 318);
            label5.Name = "label5";
            label5.Size = new Size(68, 28);
            label5.TabIndex = 10;
            label5.Text = "Result:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(236, 347);
            label6.Name = "label6";
            label6.Size = new Size(55, 28);
            label6.TabIndex = 12;
            label6.Text = "Rate:";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(310, 352);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(109, 23);
            textBox3.TabIndex = 11;
            // 
            // label50
            // 
            label50.BackColor = SystemColors.ActiveCaption;
            label50.Location = new Point(597, 18);
            label50.Name = "label50";
            label50.Size = new Size(81, 15);
            label50.TabIndex = 52;
            label50.Text = "Update Date:";
            label50.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label49
            // 
            label49.BackColor = SystemColors.ActiveCaption;
            label49.Location = new Point(679, 19);
            label49.Name = "label49";
            label49.Size = new Size(109, 15);
            label49.TabIndex = 51;
            label49.TextAlign = ContentAlignment.BottomCenter;
            // 
            // ExchangeCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label50);
            Controls.Add(label49);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ExchangeCalculator";
            Text = "ExchangeCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Button button1;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private Label label50;
        private Label label49;
    }
}