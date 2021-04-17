namespace Pharmacists
{
    partial class AddNewRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewRecord));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NewFIO = new System.Windows.Forms.TextBox();
            this.NewPhone = new System.Windows.Forms.TextBox();
            this.NewPost = new System.Windows.Forms.TextBox();
            this.NewGroup = new System.Windows.Forms.TextBox();
            this.AddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(248, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(209, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(176, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Должность";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(225, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Группа";
            // 
            // NewFIO
            // 
            this.NewFIO.Location = new System.Drawing.Point(351, 32);
            this.NewFIO.Multiline = true;
            this.NewFIO.Name = "NewFIO";
            this.NewFIO.Size = new System.Drawing.Size(238, 32);
            this.NewFIO.TabIndex = 5;
            // 
            // NewPhone
            // 
            this.NewPhone.Location = new System.Drawing.Point(351, 82);
            this.NewPhone.Multiline = true;
            this.NewPhone.Name = "NewPhone";
            this.NewPhone.Size = new System.Drawing.Size(238, 32);
            this.NewPhone.TabIndex = 6;
            // 
            // NewPost
            // 
            this.NewPost.Location = new System.Drawing.Point(351, 127);
            this.NewPost.Multiline = true;
            this.NewPost.Name = "NewPost";
            this.NewPost.Size = new System.Drawing.Size(238, 32);
            this.NewPost.TabIndex = 7;
            // 
            // NewGroup
            // 
            this.NewGroup.Location = new System.Drawing.Point(351, 171);
            this.NewGroup.Multiline = true;
            this.NewGroup.Name = "NewGroup";
            this.NewGroup.Size = new System.Drawing.Size(238, 32);
            this.NewGroup.TabIndex = 8;
            // 
            // AddNew
            // 
            this.AddNew.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNew.Location = new System.Drawing.Point(428, 375);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(161, 63);
            this.AddNew.TabIndex = 9;
            this.AddNew.Text = "Добавить";
            this.AddNew.UseVisualStyleBackColor = true;
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // AddNewRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.AddNew);
            this.Controls.Add(this.NewGroup);
            this.Controls.Add(this.NewPost);
            this.Controls.Add(this.NewPhone);
            this.Controls.Add(this.NewFIO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddNewRecord";
            this.Text = "AddNewRecord";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NewFIO;
        private System.Windows.Forms.TextBox NewPhone;
        private System.Windows.Forms.TextBox NewPost;
        private System.Windows.Forms.TextBox NewGroup;
        private System.Windows.Forms.Button AddNew;
    }
}