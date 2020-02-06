namespace BoatReservation
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
            this.cmboBoatType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmboAdults = new System.Windows.Forms.ComboBox();
            this.cmboKids = new System.Windows.Forms.ComboBox();
            this.btnCheckRes = new System.Windows.Forms.Button();
            this.lblCheckRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmboBoatType
            // 
            this.cmboBoatType.FormattingEnabled = true;
            this.cmboBoatType.Location = new System.Drawing.Point(206, 40);
            this.cmboBoatType.Name = "cmboBoatType";
            this.cmboBoatType.Size = new System.Drawing.Size(108, 21);
            this.cmboBoatType.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "What type of boat?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "How many adults?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "How many children?";
            // 
            // btnReserve
            // 
            this.btnReserve.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReserve.Enabled = false;
            this.btnReserve.Location = new System.Drawing.Point(51, 264);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(75, 23);
            this.btnReserve.TabIndex = 10;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(51, 307);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(239, 306);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmboAdults
            // 
            this.cmboAdults.FormattingEnabled = true;
            this.cmboAdults.Location = new System.Drawing.Point(263, 93);
            this.cmboAdults.Name = "cmboAdults";
            this.cmboAdults.Size = new System.Drawing.Size(51, 21);
            this.cmboAdults.TabIndex = 13;
            // 
            // cmboKids
            // 
            this.cmboKids.FormattingEnabled = true;
            this.cmboKids.Location = new System.Drawing.Point(263, 146);
            this.cmboKids.Name = "cmboKids";
            this.cmboKids.Size = new System.Drawing.Size(51, 21);
            this.cmboKids.TabIndex = 14;
            // 
            // btnCheckRes
            // 
            this.btnCheckRes.Location = new System.Drawing.Point(50, 208);
            this.btnCheckRes.Name = "btnCheckRes";
            this.btnCheckRes.Size = new System.Drawing.Size(108, 23);
            this.btnCheckRes.TabIndex = 15;
            this.btnCheckRes.Text = "Check Reservation";
            this.btnCheckRes.UseVisualStyleBackColor = true;
            this.btnCheckRes.Click += new System.EventHandler(this.btnCheckRes_Click);
            // 
            // lblCheckRes
            // 
            this.lblCheckRes.AutoSize = true;
            this.lblCheckRes.Location = new System.Drawing.Point(215, 213);
            this.lblCheckRes.Name = "lblCheckRes";
            this.lblCheckRes.Size = new System.Drawing.Size(69, 13);
            this.lblCheckRes.TabIndex = 16;
            this.lblCheckRes.Text = "Not checked";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(364, 350);
            this.Controls.Add(this.lblCheckRes);
            this.Controls.Add(this.btnCheckRes);
            this.Controls.Add(this.cmboKids);
            this.Controls.Add(this.cmboAdults);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboBoatType);
            this.Name = "Form1";
            this.Text = "Rental Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmboBoatType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmboAdults;
        private System.Windows.Forms.ComboBox cmboKids;
        private System.Windows.Forms.Button btnCheckRes;
        private System.Windows.Forms.Label lblCheckRes;
    }
}

