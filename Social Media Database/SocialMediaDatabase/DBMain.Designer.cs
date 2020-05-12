namespace SOFT562Week18
{
    partial class DBMain
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
            this.titleMainName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.userIDgrid = new System.Windows.Forms.DataGridView();
            this.dgdEducation = new System.Windows.Forms.DataGridView();
            this.dgdFriendships = new System.Windows.Forms.DataGridView();
            this.dgdMessages = new System.Windows.Forms.DataGridView();
            this.dgdWorkplace = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userIDgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdEducation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdFriendships)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdWorkplace)).BeginInit();
            this.SuspendLayout();
            // 
            // titleMainName
            // 
            this.titleMainName.AutoSize = true;
            this.titleMainName.BackColor = System.Drawing.Color.Transparent;
            this.titleMainName.Font = new System.Drawing.Font("Segoe Print", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleMainName.ForeColor = System.Drawing.Color.White;
            this.titleMainName.Location = new System.Drawing.Point(519, 0);
            this.titleMainName.Name = "titleMainName";
            this.titleMainName.Size = new System.Drawing.Size(648, 168);
            this.titleMainName.TabIndex = 4;
            this.titleMainName.Text = "MindSpeech";
            this.titleMainName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(3, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 71);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(163, 9);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(154, 71);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // userIDgrid
            // 
            this.userIDgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userIDgrid.Location = new System.Drawing.Point(510, 212);
            this.userIDgrid.Name = "userIDgrid";
            this.userIDgrid.Size = new System.Drawing.Size(722, 87);
            this.userIDgrid.TabIndex = 10;
            // 
            // dgdEducation
            // 
            this.dgdEducation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdEducation.Location = new System.Drawing.Point(706, 619);
            this.dgdEducation.Name = "dgdEducation";
            this.dgdEducation.Size = new System.Drawing.Size(338, 142);
            this.dgdEducation.TabIndex = 11;
            // 
            // dgdFriendships
            // 
            this.dgdFriendships.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdFriendships.Location = new System.Drawing.Point(57, 341);
            this.dgdFriendships.Name = "dgdFriendships";
            this.dgdFriendships.Size = new System.Drawing.Size(338, 573);
            this.dgdFriendships.TabIndex = 11;
            // 
            // dgdMessages
            // 
            this.dgdMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdMessages.Location = new System.Drawing.Point(1297, 128);
            this.dgdMessages.Name = "dgdMessages";
            this.dgdMessages.Size = new System.Drawing.Size(595, 448);
            this.dgdMessages.TabIndex = 14;
            // 
            // dgdWorkplace
            // 
            this.dgdWorkplace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdWorkplace.Location = new System.Drawing.Point(706, 397);
            this.dgdWorkplace.Name = "dgdWorkplace";
            this.dgdWorkplace.Size = new System.Drawing.Size(338, 142);
            this.dgdWorkplace.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1513, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 64);
            this.label2.TabIndex = 16;
            this.label2.Text = "Messages";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(125, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 64);
            this.label3.TabIndex = 17;
            this.label3.Text = "Friends";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(771, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 64);
            this.label1.TabIndex = 18;
            this.label1.Text = "Workplace";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(771, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 64);
            this.label4.TabIndex = 19;
            this.label4.Text = "Education";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DBMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SOFT562Week18.Properties.Resources.Nice_Gradient_Wallpaper;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgdWorkplace);
            this.Controls.Add(this.dgdMessages);
            this.Controls.Add(this.dgdFriendships);
            this.Controls.Add(this.dgdEducation);
            this.Controls.Add(this.userIDgrid);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.titleMainName);
            this.Name = "DBMain";
            this.Text = "DBMain";
            ((System.ComponentModel.ISupportInitialize)(this.userIDgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdEducation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdFriendships)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdWorkplace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleMainName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView userIDgrid;
        private System.Windows.Forms.DataGridView dgdEducation;
        private System.Windows.Forms.DataGridView dgdFriendships;
        private System.Windows.Forms.DataGridView dgdMessages;
        private System.Windows.Forms.DataGridView dgdWorkplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}