namespace PaulinaKujawaHomework3
{
    partial class Myweek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Myweek));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonRefreshMyweek = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonPlan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 328);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonRefreshMyweek
            // 
            this.buttonRefreshMyweek.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRefreshMyweek.Location = new System.Drawing.Point(474, 23);
            this.buttonRefreshMyweek.Name = "buttonRefreshMyweek";
            this.buttonRefreshMyweek.Size = new System.Drawing.Size(111, 44);
            this.buttonRefreshMyweek.TabIndex = 1;
            this.buttonRefreshMyweek.Text = "Refresh";
            this.buttonRefreshMyweek.UseVisualStyleBackColor = true;
            this.buttonRefreshMyweek.Click += new System.EventHandler(this.buttonRefreshMyweek_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.Location = new System.Drawing.Point(423, 269);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(119, 46);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add data";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(423, 192);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(119, 20);
            this.textBoxSubject.TabIndex = 3;
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(583, 192);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(119, 20);
            this.textBoxDay.TabIndex = 4;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(738, 192);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(119, 20);
            this.textBoxTime.TabIndex = 5;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(583, 269);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(119, 46);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete data";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubject.Location = new System.Drawing.Point(419, 142);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(63, 22);
            this.labelSubject.TabIndex = 7;
            this.labelSubject.Text = "Subject";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.Location = new System.Drawing.Point(579, 142);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(123, 22);
            this.labelDay.TabIndex = 8;
            this.labelDay.Text = "Day of the week";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(734, 142);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(45, 22);
            this.labelTime.TabIndex = 9;
            this.labelTime.Text = "Time";
            // 
            // buttonPlan
            // 
            this.buttonPlan.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlan.Location = new System.Drawing.Point(705, 23);
            this.buttonPlan.Name = "buttonPlan";
            this.buttonPlan.Size = new System.Drawing.Size(152, 44);
            this.buttonPlan.TabIndex = 10;
            this.buttonPlan.Text = "Plan of action";
            this.buttonPlan.UseVisualStyleBackColor = true;
            this.buttonPlan.Click += new System.EventHandler(this.buttonPlan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(386, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Myweek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 363);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPlan);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRefreshMyweek);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Myweek";
            this.Text = "My_Week";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRefreshMyweek;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonPlan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

