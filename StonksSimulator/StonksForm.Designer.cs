namespace StonksSimulator
{
    partial class StonksForm
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
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(387, 553);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 0;
            button1.Text = "Vlož Akcie!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(367, 515);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(137, 27);
            numericUpDown1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(3, 16);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(897, 475);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Location = new Point(701, 515);
            label1.Name = "label1";
            label1.Size = new Size(200, 31);
            label1.TabIndex = 3;
            label1.Text = "Peníze: 5$";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StonksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 600);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StonksForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private NumericUpDown numericUpDown1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
    }
}
