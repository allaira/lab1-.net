namespace lab1
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
            menuStrip1 = new MenuStrip();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            colX = new DataGridViewTextBoxColumn();
            colY = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(878, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 24);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 1;
            label1.Text = "Xn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 24);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 2;
            label2.Text = "Xk:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(334, 24);
            label3.Name = "label3";
            label3.Size = new Size(20, 20);
            label3.TabIndex = 3;
            label3.Text = "h:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(474, 24);
            label4.Name = "label4";
            label4.Size = new Size(20, 20);
            label4.TabIndex = 4;
            label4.Text = "a:";
            // 
            // button1
            // 
            button1.Location = new Point(596, 44);
            button1.Name = "button1";
            button1.Size = new Size(146, 33);
            button1.TabIndex = 5;
            button1.Text = "Обрахувати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colX, colY });
            dataGridView1.Location = new Point(34, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(302, 410);
            dataGridView1.TabIndex = 6;
            // 
            // colX
            // 
            colX.HeaderText = "X";
            colX.MinimumWidth = 6;
            colX.Name = "colX";
            colX.Width = 125;
            // 
            // colY
            // 
            colY.HeaderText = "Y";
            colY.MinimumWidth = 6;
            colY.Name = "colY";
            colY.Width = 125;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(90, 27);
            textBox1.TabIndex = 7;
            textBox1.Text = "-1,7";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(167, 47);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(88, 27);
            textBox5.TabIndex = 11;
            textBox5.Text = "45,3";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(300, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(89, 27);
            textBox2.TabIndex = 12;
            textBox2.Text = "0,3";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(444, 47);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(83, 27);
            textBox3.TabIndex = 13;
            textBox3.Text = "10";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 558);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox5);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox5;
        private TextBox textBox2;
        private TextBox textBox3;
        private DataGridViewTextBoxColumn colX;
        private DataGridViewTextBoxColumn colY;
    }
}
