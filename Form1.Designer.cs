
namespace GraphColoring
{
    partial class Form1
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
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Coloring = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.EdgesListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.White;
            this.Picture.Location = new System.Drawing.Point(12, 12);
            this.Picture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(1457, 868);
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            this.Picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pricture_MouseDown);
            // 
            // Coloring
            // 
            this.Coloring.Location = new System.Drawing.Point(18, 923);
            this.Coloring.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Coloring.Name = "Coloring";
            this.Coloring.Size = new System.Drawing.Size(83, 37);
            this.Coloring.TabIndex = 1;
            this.Coloring.Text = "button1";
            this.Coloring.UseVisualStyleBackColor = true;
            this.Coloring.Click += new System.EventHandler(this.Coloring_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 923);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(227, 923);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Clean
            // 
            this.Clean.Location = new System.Drawing.Point(342, 923);
            this.Clean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(83, 37);
            this.Clean.TabIndex = 4;
            this.Clean.Text = "Очистить";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(1188, 923);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(101, 34);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // EdgesListBox
            // 
            this.EdgesListBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EdgesListBox.FormattingEnabled = true;
            this.EdgesListBox.ItemHeight = 16;
            this.EdgesListBox.Location = new System.Drawing.Point(1492, 12);
            this.EdgesListBox.Name = "EdgesListBox";
            this.EdgesListBox.Size = new System.Drawing.Size(398, 868);
            this.EdgesListBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1600, 923);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EdgesListBox);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Coloring);
            this.Controls.Add(this.Picture);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Раскраска графа";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Button Coloring;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ListBox EdgesListBox;
        private System.Windows.Forms.Button button1;
    }
}

