namespace ExcahngeRates
{
    partial class MainPage
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(144, 173);
            button1.Name = "button1";
            button1.Size = new Size(167, 61);
            button1.TabIndex = 0;
            button1.Text = "Exchange Table";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.NavajoWhite;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(478, 173);
            button2.Name = "button2";
            button2.Size = new Size(167, 61);
            button2.TabIndex = 1;
            button2.Text = "Exchange Calculator";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(282, 33);
            label1.Name = "label1";
            label1.Size = new Size(218, 37);
            label1.TabIndex = 2;
            label1.Text = "Foreign Currency";
            // 
            // button3
            // 
            button3.BackColor = Color.LemonChiffon;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(310, 281);
            button3.Name = "button3";
            button3.Size = new Size(167, 61);
            button3.TabIndex = 3;
            button3.Text = "Gold  Price";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainPage";
            Text = "MainPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
    }
}