﻿namespace WindowsFormsSamosval
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
        this.groupBoxTakeCar = new System.Windows.Forms.GroupBox();
        this.pictureBoxTakeCar = new System.Windows.Forms.PictureBox();
        this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
        this.labelPlace = new System.Windows.Forms.Label();
        this.buttonTakeCar = new System.Windows.Forms.Button();
        this.listBoxLevels = new System.Windows.Forms.ListBox();
        this.buttonSetCar = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
        this.groupBoxTakeCar.SuspendLayout();
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
        // groupBoxTakeCar
        // 
        this.groupBoxTakeCar.Controls.Add(this.pictureBoxTakeCar);
        this.groupBoxTakeCar.Controls.Add(this.maskedTextBox);
        this.groupBoxTakeCar.Controls.Add(this.labelPlace);
        this.groupBoxTakeCar.Controls.Add(this.buttonTakeCar);
        this.groupBoxTakeCar.Location = new System.Drawing.Point(845, 320);
        this.groupBoxTakeCar.Name = "groupBoxTakeCar";
        this.groupBoxTakeCar.Size = new System.Drawing.Size(330, 424);
        this.groupBoxTakeCar.TabIndex = 3;
        this.groupBoxTakeCar.TabStop = false;
        this.groupBoxTakeCar.Text = "Забрать машину";
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
        this.maskedTextBox.Location = new System.Drawing.Point(160, 47);
        this.maskedTextBox.Name = "maskedTextBox";
        this.maskedTextBox.Size = new System.Drawing.Size(60, 26);
        this.maskedTextBox.TabIndex = 7;
        // 
        // labelPlace
        // 
        this.labelPlace.AutoSize = true;
        this.labelPlace.Location = new System.Drawing.Point(84, 47);
        this.labelPlace.Name = "labelPlace";
        this.labelPlace.Size = new System.Drawing.Size(61, 20);
        this.labelPlace.TabIndex = 6;
        this.labelPlace.Text = "Место:";
        // 
        // buttonTakeCar
        // 
        this.buttonTakeCar.Location = new System.Drawing.Point(120, 90);
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
        this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
        // 
        // buttonSetCar
        // 
        this.buttonSetCar.Location = new System.Drawing.Point(933, 253);
        this.buttonSetCar.Name = "buttonSetCar";
        this.buttonSetCar.Size = new System.Drawing.Size(173, 50);
        this.buttonSetCar.TabIndex = 5;
        this.buttonSetCar.Text = "Заказать авто";
        this.buttonSetCar.UseVisualStyleBackColor = true;
        this.buttonSetCar.Click += new System.EventHandler(this.buttonSetCar_Click);
        // 
        // FormParking
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1178, 744);
        this.Controls.Add(this.buttonSetCar);
        this.Controls.Add(this.listBoxLevels);
        this.Controls.Add(this.groupBoxTakeCar);
        this.Controls.Add(this.pictureBoxParking);
        this.Name = "FormParking";
        this.Text = "Парковка";
        ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
        this.groupBoxTakeCar.ResumeLayout(false);
        this.groupBoxTakeCar.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeCar)).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBoxParking;
    private System.Windows.Forms.GroupBox groupBoxTakeCar;
    private System.Windows.Forms.Button buttonTakeCar;
    private System.Windows.Forms.PictureBox pictureBoxTakeCar;
    private System.Windows.Forms.MaskedTextBox maskedTextBox;
    private System.Windows.Forms.Label labelPlace;
    private System.Windows.Forms.ListBox listBoxLevels;
    private System.Windows.Forms.Button buttonSetCar;
}
}