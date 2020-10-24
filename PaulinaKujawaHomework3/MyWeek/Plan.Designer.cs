namespace PaulinaKujawaHomework3.MyWeek
{
    partial class Plan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plan));
            this.dataGridViewPlan = new System.Windows.Forms.DataGridView();
            this.buttonDetails = new System.Windows.Forms.Button();
            this.labelDeadline = new System.Windows.Forms.Label();
            this.labelDuty = new System.Windows.Forms.Label();
            this.labelSubject2 = new System.Windows.Forms.Label();
            this.buttonDelete2 = new System.Windows.Forms.Button();
            this.textBoxDeadline = new System.Windows.Forms.TextBox();
            this.textBoxDuty = new System.Windows.Forms.TextBox();
            this.textBoxSubject2 = new System.Windows.Forms.TextBox();
            this.buttonAdd2 = new System.Windows.Forms.Button();
            this.buttonRefreshPlan = new System.Windows.Forms.Button();
            this.labelHowlong = new System.Windows.Forms.Label();
            this.textBoxHowlong = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPlan
            // 
            this.dataGridViewPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlan.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewPlan.Name = "dataGridViewPlan";
            this.dataGridViewPlan.Size = new System.Drawing.Size(442, 304);
            this.dataGridViewPlan.TabIndex = 0;
            // 
            // buttonDetails
            // 
            this.buttonDetails.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetails.Location = new System.Drawing.Point(732, 40);
            this.buttonDetails.Name = "buttonDetails";
            this.buttonDetails.Size = new System.Drawing.Size(120, 44);
            this.buttonDetails.TabIndex = 20;
            this.buttonDetails.Text = "Details";
            this.buttonDetails.UseVisualStyleBackColor = true;
            this.buttonDetails.Click += new System.EventHandler(this.buttonDetails_Click);
            // 
            // labelDeadline
            // 
            this.labelDeadline.AutoSize = true;
            this.labelDeadline.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeadline.Location = new System.Drawing.Point(678, 150);
            this.labelDeadline.Name = "labelDeadline";
            this.labelDeadline.Size = new System.Drawing.Size(65, 19);
            this.labelDeadline.TabIndex = 19;
            this.labelDeadline.Text = "Deadline";
            // 
            // labelDuty
            // 
            this.labelDuty.AutoSize = true;
            this.labelDuty.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuty.Location = new System.Drawing.Point(574, 150);
            this.labelDuty.Name = "labelDuty";
            this.labelDuty.Size = new System.Drawing.Size(41, 19);
            this.labelDuty.TabIndex = 18;
            this.labelDuty.Text = "Duty";
            // 
            // labelSubject2
            // 
            this.labelSubject2.AutoSize = true;
            this.labelSubject2.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubject2.Location = new System.Drawing.Point(469, 150);
            this.labelSubject2.Name = "labelSubject2";
            this.labelSubject2.Size = new System.Drawing.Size(54, 19);
            this.labelSubject2.TabIndex = 17;
            this.labelSubject2.Text = "Subject";
            // 
            // buttonDelete2
            // 
            this.buttonDelete2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete2.Location = new System.Drawing.Point(718, 287);
            this.buttonDelete2.Name = "buttonDelete2";
            this.buttonDelete2.Size = new System.Drawing.Size(134, 46);
            this.buttonDelete2.TabIndex = 16;
            this.buttonDelete2.Text = "Delete data";
            this.buttonDelete2.UseVisualStyleBackColor = true;
            this.buttonDelete2.Click += new System.EventHandler(this.buttonDelete2_Click_1);
            // 
            // textBoxDeadline
            // 
            this.textBoxDeadline.Location = new System.Drawing.Point(682, 199);
            this.textBoxDeadline.Name = "textBoxDeadline";
            this.textBoxDeadline.Size = new System.Drawing.Size(74, 20);
            this.textBoxDeadline.TabIndex = 15;
            // 
            // textBoxDuty
            // 
            this.textBoxDuty.Location = new System.Drawing.Point(578, 199);
            this.textBoxDuty.Name = "textBoxDuty";
            this.textBoxDuty.Size = new System.Drawing.Size(75, 20);
            this.textBoxDuty.TabIndex = 14;
            // 
            // textBoxSubject2
            // 
            this.textBoxSubject2.Location = new System.Drawing.Point(473, 199);
            this.textBoxSubject2.Name = "textBoxSubject2";
            this.textBoxSubject2.Size = new System.Drawing.Size(78, 20);
            this.textBoxSubject2.TabIndex = 13;
            // 
            // buttonAdd2
            // 
            this.buttonAdd2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd2.Location = new System.Drawing.Point(546, 287);
            this.buttonAdd2.Name = "buttonAdd2";
            this.buttonAdd2.Size = new System.Drawing.Size(134, 46);
            this.buttonAdd2.TabIndex = 12;
            this.buttonAdd2.Text = "Add data";
            this.buttonAdd2.UseVisualStyleBackColor = true;
            this.buttonAdd2.Click += new System.EventHandler(this.buttonAdd2_Click);
            // 
            // buttonRefreshPlan
            // 
            this.buttonRefreshPlan.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRefreshPlan.Location = new System.Drawing.Point(531, 41);
            this.buttonRefreshPlan.Name = "buttonRefreshPlan";
            this.buttonRefreshPlan.Size = new System.Drawing.Size(111, 44);
            this.buttonRefreshPlan.TabIndex = 11;
            this.buttonRefreshPlan.Text = "Refresh";
            this.buttonRefreshPlan.UseVisualStyleBackColor = true;
            this.buttonRefreshPlan.Click += new System.EventHandler(this.buttonRefreshPlan_Click);
            // 
            // labelHowlong
            // 
            this.labelHowlong.AutoSize = true;
            this.labelHowlong.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHowlong.Location = new System.Drawing.Point(782, 150);
            this.labelHowlong.Name = "labelHowlong";
            this.labelHowlong.Size = new System.Drawing.Size(74, 19);
            this.labelHowlong.TabIndex = 21;
            this.labelHowlong.Text = "How long?";
            // 
            // textBoxHowlong
            // 
            this.textBoxHowlong.Location = new System.Drawing.Point(786, 199);
            this.textBoxHowlong.Name = "textBoxHowlong";
            this.textBoxHowlong.Size = new System.Drawing.Size(76, 20);
            this.textBoxHowlong.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(460, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 368);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxHowlong);
            this.Controls.Add(this.labelHowlong);
            this.Controls.Add(this.buttonDetails);
            this.Controls.Add(this.labelDeadline);
            this.Controls.Add(this.labelDuty);
            this.Controls.Add(this.labelSubject2);
            this.Controls.Add(this.buttonDelete2);
            this.Controls.Add(this.textBoxDeadline);
            this.Controls.Add(this.textBoxDuty);
            this.Controls.Add(this.textBoxSubject2);
            this.Controls.Add(this.buttonAdd2);
            this.Controls.Add(this.buttonRefreshPlan);
            this.Controls.Add(this.dataGridViewPlan);
            this.Name = "Plan";
            this.Text = "Plan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPlan;
        private System.Windows.Forms.Button buttonDetails;
        private System.Windows.Forms.Label labelDeadline;
        private System.Windows.Forms.Label labelDuty;
        private System.Windows.Forms.Label labelSubject2;
        private System.Windows.Forms.Button buttonDelete2;
        private System.Windows.Forms.TextBox textBoxDeadline;
        private System.Windows.Forms.TextBox textBoxDuty;
        private System.Windows.Forms.TextBox textBoxSubject2;
        private System.Windows.Forms.Button buttonAdd2;
        private System.Windows.Forms.Button buttonRefreshPlan;
        private System.Windows.Forms.Label labelHowlong;
        private System.Windows.Forms.TextBox textBoxHowlong;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}