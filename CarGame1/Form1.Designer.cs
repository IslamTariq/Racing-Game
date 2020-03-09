namespace CarGame1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.over = new System.Windows.Forms.Label();
            this.enemycar2 = new System.Windows.Forms.PictureBox();
            this.enemycar1 = new System.Windows.Forms.PictureBox();
            this.car = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enemycar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemycar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // over
            // 
            this.over.AutoSize = true;
            this.over.BackColor = System.Drawing.Color.Maroon;
            this.over.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.over.ForeColor = System.Drawing.Color.Gold;
            this.over.Location = new System.Drawing.Point(156, 264);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(169, 32);
            this.over.TabIndex = 9;
            this.over.Text = "Game Over";
            // 
            // enemycar2
            // 
            this.enemycar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemycar2.Image = global::CarGame1.Properties.Resources.enemycar;
            this.enemycar2.Location = new System.Drawing.Point(284, 123);
            this.enemycar2.Name = "enemycar2";
            this.enemycar2.Size = new System.Drawing.Size(29, 84);
            this.enemycar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemycar2.TabIndex = 8;
            this.enemycar2.TabStop = false;
            // 
            // enemycar1
            // 
            this.enemycar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemycar1.Image = global::CarGame1.Properties.Resources.enemycar;
            this.enemycar1.Location = new System.Drawing.Point(73, 100);
            this.enemycar1.Name = "enemycar1";
            this.enemycar1.Size = new System.Drawing.Size(34, 85);
            this.enemycar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemycar1.TabIndex = 7;
            this.enemycar1.TabStop = false;
            // 
            // car
            // 
            this.car.BackColor = System.Drawing.Color.Gray;
            this.car.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.car.Image = global::CarGame1.Properties.Resources.carimage2___Copy;
            this.car.Location = new System.Drawing.Point(171, 417);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(44, 97);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.car.TabIndex = 6;
            this.car.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Location = new System.Drawing.Point(460, -16);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(15, 593);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Location = new System.Drawing.Point(2, -30);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(15, 593);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(232, 505);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(15, 129);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(232, 123);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 129);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(232, 318);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 129);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(232, -72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 129);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // coin2
            // 
            this.coin2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coin2.Image = global::CarGame1.Properties.Resources.coinimage;
            this.coin2.Location = new System.Drawing.Point(28, 198);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(32, 31);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2.TabIndex = 11;
            this.coin2.TabStop = false;
            // 
            // coin3
            // 
            this.coin3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coin3.Image = global::CarGame1.Properties.Resources.coinimage;
            this.coin3.Location = new System.Drawing.Point(28, 265);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(32, 31);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin3.TabIndex = 12;
            this.coin3.TabStop = false;
            // 
            // coin1
            // 
            this.coin1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coin1.Image = global::CarGame1.Properties.Resources.coinimage;
            this.coin1.Location = new System.Drawing.Point(341, 154);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(32, 31);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 13;
            this.coin1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Coins: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(478, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.over);
            this.Controls.Add(this.enemycar2);
            this.Controls.Add(this.enemycar1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Created by Islam Tariq";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.enemycar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemycar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox enemycar1;
        private System.Windows.Forms.PictureBox enemycar2;
        private System.Windows.Forms.Label over;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.Label label1;
    }
}

