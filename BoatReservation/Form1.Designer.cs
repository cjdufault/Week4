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
            this.numAdults = new System.Windows.Forms.NumericUpDown();
            this.numKids = new System.Windows.Forms.NumericUpDown();
            this.cmboBoatType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheckRes = new System.Windows.Forms.Button();
            this.lblCheckRes = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAdults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKids)).BeginInit();
            this.SuspendLayout();
            // 
            // numAdults
            // 
            this.numAdults.Location = new System.Drawing.Point(257, 94);
            this.numAdults.Name = "numAdults";
            this.numAdults.Size = new System.Drawing.Size(57, 20);
            this.numAdults.TabIndex = 2;
            // 
            // numKids
            // 
            this.numKids.Location = new System.Drawing.Point(257, 147);
            this.numKids.Name = "numKids";
            this.numKids.Size = new System.Drawing.Size(57, 20);
            this.numKids.TabIndex = 3;
            // 
            // cmboBoatType
            // 
            this.cmboBoatType.FormattingEnabled = true;
            this.cmboBoatType.Location = new System.Drawing.Point(193, 40);
            this.cmboBoatType.Name = "cmboBoatType";
            this.cmboBoatType.Size = new System.Drawing.Size(121, 21);
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
            // btnCheckRes
            // 
            this.btnCheckRes.Location = new System.Drawing.Point(50, 222);
            this.btnCheckRes.Name = "btnCheckRes";
            this.btnCheckRes.Size = new System.Drawing.Size(106, 23);
            this.btnCheckRes.TabIndex = 8;
            this.btnCheckRes.Text = "Check Reservation";
            this.btnCheckRes.UseVisualStyleBackColor = true;
            this.btnCheckRes.Click += new System.EventHandler(this.btnCheckRes_Click);
            // 
            // lblCheckRes
            // 
            this.lblCheckRes.Location = new System.Drawing.Point(193, 222);
            this.lblCheckRes.Name = "lblCheckRes";
            this.lblCheckRes.Size = new System.Drawing.Size(121, 23);
            this.lblCheckRes.TabIndex = 9;
            this.lblCheckRes.Text = "Not checked";
            this.lblCheckRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReserve
            // 
            this.btnReserve.Enabled = false;
            this.btnReserve.Location = new System.Drawing.Point(50, 267);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(75, 23);
            this.btnReserve.TabIndex = 10;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 336);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.lblCheckRes);
            this.Controls.Add(this.btnCheckRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboBoatType);
            this.Controls.Add(this.numKids);
            this.Controls.Add(this.numAdults);
            this.Name = "Form1";
            this.Text = "Rental Form";
            ((System.ComponentModel.ISupportInitialize)(this.numAdults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKids)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numAdults;
        private System.Windows.Forms.NumericUpDown numKids;
        private System.Windows.Forms.ComboBox cmboBoatType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheckRes;
        private System.Windows.Forms.Label lblCheckRes;
        private System.Windows.Forms.Button btnReserve;
    }
}

