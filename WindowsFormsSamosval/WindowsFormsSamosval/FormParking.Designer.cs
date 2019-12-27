namespace WindowsFormsSamosval
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonSetSamosval = new System.Windows.Forms.Button();
            this.buttonSetSuperSamosval = new System.Windows.Forms.Button();
            this.TakeCarGroup = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakeCar = new System.Windows.Forms.PictureBox();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTakeCar = new System.Windows.Forms.Button();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.TakeCarGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(839, 744);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonSetSamosval
            // 
            this.buttonSetSamosval.Location = new System.Drawing.Point(1030, 208);
            this.buttonSetSamosval.Name = "buttonSetSamosval";
            this.buttonSetSamosval.Size = new System.Drawing.Size(127, 84);
            this.buttonSetSamosval.TabIndex = 1;
            this.buttonSetSamosval.Text = "Припарковать самосвал";
            this.buttonSetSamosval.UseVisualStyleBackColor = true;
            this.buttonSetSamosval.Click += new System.EventHandler(this.buttonSetSamosval_Click);
            // 
            // buttonSetSuperSamosval
            // 
            this.buttonSetSuperSamosval.Location = new System.Drawing.Point(872, 208);
            this.buttonSetSuperSamosval.Name = "buttonSetSuperSamosval";
            this.buttonSetSuperSamosval.Size = new System.Drawing.Size(127, 84);
            this.buttonSetSuperSamosval.TabIndex = 2;
            this.buttonSetSuperSamosval.Text = "Припарковать супер самосвал";
            this.buttonSetSuperSamosval.UseVisualStyleBackColor = true;
            this.buttonSetSuperSamosval.Click += new System.EventHandler(this.buttonSetSuperSamosval_Click);
            // 
            // TakeCarGroup
            // 
            this.TakeCarGroup.Controls.Add(this.pictureBoxTakeCar);
            this.TakeCarGroup.Controls.Add(this.maskedTextBox);
            this.TakeCarGroup.Controls.Add(this.label2);
            this.TakeCarGroup.Controls.Add(this.label1);
            this.TakeCarGroup.Controls.Add(this.buttonTakeCar);
            this.TakeCarGroup.Location = new System.Drawing.Point(845, 320);
            this.TakeCarGroup.Name = "TakeCarGroup";
            this.TakeCarGroup.Size = new System.Drawing.Size(330, 424);
            this.TakeCarGroup.TabIndex = 3;
            this.TakeCarGroup.TabStop = false;
            this.TakeCarGroup.Text = "TakeCarGroup";
            // 
            // pictureBoxTakeCar
            // 
            this.pictureBoxTakeCar.Location = new System.Drawing.Point(0, 153);
            this.pictureBoxTakeCar.Name = "pictureBoxTakeCar";
            this.pictureBoxTakeCar.Size = new System.Drawing.Size(330, 271);
            this.pictureBoxTakeCar.TabIndex = 8;
            this.pictureBoxTakeCar.TabStop = false;
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(160, 67);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(60, 26);
            this.maskedTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Местро:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Забрать машину";
            // 
            // buttonTakeCar
            // 
            this.buttonTakeCar.Location = new System.Drawing.Point(113, 116);
            this.buttonTakeCar.Name = "buttonTakeCar";
            this.buttonTakeCar.Size = new System.Drawing.Size(85, 31);
            this.buttonTakeCar.TabIndex = 4;
            this.buttonTakeCar.Text = "Забрать";
            this.buttonTakeCar.UseVisualStyleBackColor = true;
            this.buttonTakeCar.Click += new System.EventHandler(this.buttonTakeCar_Click);
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.ItemHeight = 20;
            this.listBoxLevels.Location = new System.Drawing.Point(872, 13);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(285, 164);
            this.listBoxLevels.TabIndex = 4;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.TakeCarGroup);
            this.Controls.Add(this.buttonSetSuperSamosval);
            this.Controls.Add(this.buttonSetSamosval);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.TakeCarGroup.ResumeLayout(false);
            this.TakeCarGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonSetSamosval;
        private System.Windows.Forms.Button buttonSetSuperSamosval;
        private System.Windows.Forms.GroupBox TakeCarGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTakeCar;
        private System.Windows.Forms.PictureBox pictureBoxTakeCar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxLevels;
    }
}