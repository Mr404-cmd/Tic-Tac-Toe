namespace Tic_Tac_Toe1
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
            this.A20 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A00 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.Ebutton = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Ngbutton = new System.Windows.Forms.Button();
            this.Xwin = new System.Windows.Forms.Label();
            this.Owin = new System.Windows.Forms.Label();
            this.Draws = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A20
            // 
            this.A20.Location = new System.Drawing.Point(111, 177);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(75, 49);
            this.A20.TabIndex = 5;
            this.A20.UseVisualStyleBackColor = true;
            this.A20.Click += new System.EventHandler(this.buttonClick);
            // 
            // A10
            // 
            this.A10.Location = new System.Drawing.Point(111, 122);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(75, 49);
            this.A10.TabIndex = 4;
            this.A10.UseVisualStyleBackColor = true;
            this.A10.Click += new System.EventHandler(this.buttonClick);
            // 
            // A00
            // 
            this.A00.Location = new System.Drawing.Point(111, 67);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(75, 49);
            this.A00.TabIndex = 3;
            this.A00.UseVisualStyleBackColor = true;
            this.A00.Click += new System.EventHandler(this.buttonClick);
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(192, 180);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(75, 49);
            this.A21.TabIndex = 8;
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.buttonClick);
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(192, 125);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(75, 49);
            this.A11.TabIndex = 7;
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.buttonClick);
            // 
            // A01
            // 
            this.A01.Location = new System.Drawing.Point(192, 67);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(75, 49);
            this.A01.TabIndex = 6;
            this.A01.UseVisualStyleBackColor = true;
            this.A01.Click += new System.EventHandler(this.buttonClick);
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(273, 180);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(75, 49);
            this.A22.TabIndex = 11;
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.buttonClick);
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(273, 125);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(75, 49);
            this.A12.TabIndex = 10;
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.buttonClick);
            // 
            // A02
            // 
            this.A02.Location = new System.Drawing.Point(273, 67);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(75, 49);
            this.A02.TabIndex = 9;
            this.A02.UseVisualStyleBackColor = true;
            this.A02.Click += new System.EventHandler(this.buttonClick);
            // 
            // Ebutton
            // 
            this.Ebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ebutton.Location = new System.Drawing.Point(273, 235);
            this.Ebutton.Name = "Ebutton";
            this.Ebutton.Size = new System.Drawing.Size(75, 27);
            this.Ebutton.TabIndex = 14;
            this.Ebutton.Text = "Exit";
            this.Ebutton.UseVisualStyleBackColor = true;
            this.Ebutton.Click += new System.EventHandler(this.Ebutton_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(174, 235);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(61, 27);
            this.Reset.TabIndex = 13;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // Ngbutton
            // 
            this.Ngbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ngbutton.Location = new System.Drawing.Point(111, 232);
            this.Ngbutton.Name = "Ngbutton";
            this.Ngbutton.Size = new System.Drawing.Size(57, 30);
            this.Ngbutton.TabIndex = 12;
            this.Ngbutton.Text = "New Game";
            this.Ngbutton.UseVisualStyleBackColor = true;
            this.Ngbutton.Click += new System.EventHandler(this.Ngbutton_Click);
            // 
            // Xwin
            // 
            this.Xwin.Location = new System.Drawing.Point(375, 76);
            this.Xwin.Name = "Xwin";
            this.Xwin.Size = new System.Drawing.Size(60, 23);
            this.Xwin.TabIndex = 15;
            this.Xwin.Text = "label1";
            // 
            // Owin
            // 
            this.Owin.Location = new System.Drawing.Point(375, 140);
            this.Owin.Name = "Owin";
            this.Owin.Size = new System.Drawing.Size(35, 13);
            this.Owin.TabIndex = 16;
            this.Owin.Text = "label2";
            // 
            // Draws
            // 
            this.Draws.Location = new System.Drawing.Point(375, 195);
            this.Draws.Name = "Draws";
            this.Draws.Size = new System.Drawing.Size(35, 13);
            this.Draws.TabIndex = 17;
            this.Draws.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Draws);
            this.Controls.Add(this.Owin);
            this.Controls.Add(this.Xwin);
            this.Controls.Add(this.Ebutton);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Ngbutton);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A00);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button Ebutton;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Ngbutton;
        private System.Windows.Forms.Label Xwin;
        private System.Windows.Forms.Label Owin;
        private System.Windows.Forms.Label Draws;
    }
}

