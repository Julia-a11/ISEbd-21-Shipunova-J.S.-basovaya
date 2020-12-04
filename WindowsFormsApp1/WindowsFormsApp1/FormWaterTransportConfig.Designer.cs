namespace Laboratornaya
{
    partial class FormWaterTransportConfig
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
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.checkBoxRadar = new System.Windows.Forms.CheckBox();
            this.checkBoxRunway = new System.Windows.Forms.CheckBox();
            this.checkBoxPlane = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.groupBoxTypeWarShip = new System.Windows.Forms.GroupBox();
            this.labelAircraftCarrier = new System.Windows.Forms.Label();
            this.labelWarShip = new System.Windows.Forms.Label();
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.panelPurpleColor = new System.Windows.Forms.Panel();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.panelRedColor = new System.Windows.Forms.Panel();
            this.panelCoralColor = new System.Windows.Forms.Panel();
            this.panelBlackColor = new System.Windows.Forms.Panel();
            this.panelBlueColor = new System.Windows.Forms.Panel();
            this.panelOrangeColor = new System.Windows.Forms.Panel();
            this.panelGreenColor = new System.Windows.Forms.Panel();
            this.panelYellowColor = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            this.groupBoxTypeWarShip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.panelDisplay.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.checkBoxRadar);
            this.groupBoxParameters.Controls.Add(this.checkBoxRunway);
            this.groupBoxParameters.Controls.Add(this.checkBoxPlane);
            this.groupBoxParameters.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParameters.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParameters.Controls.Add(this.labelWeight);
            this.groupBoxParameters.Controls.Add(this.labelMaxSpeed);
            this.groupBoxParameters.Location = new System.Drawing.Point(12, 289);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(549, 138);
            this.groupBoxParameters.TabIndex = 0;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Параметры";
            // 
            // checkBoxRadar
            // 
            this.checkBoxRadar.AutoSize = true;
            this.checkBoxRadar.Location = new System.Drawing.Point(278, 115);
            this.checkBoxRadar.Name = "checkBoxRadar";
            this.checkBoxRadar.Size = new System.Drawing.Size(57, 17);
            this.checkBoxRadar.TabIndex = 6;
            this.checkBoxRadar.Text = "Радар";
            this.checkBoxRadar.UseVisualStyleBackColor = true;
            // 
            // checkBoxRunway
            // 
            this.checkBoxRunway.AutoSize = true;
            this.checkBoxRunway.Location = new System.Drawing.Point(278, 19);
            this.checkBoxRunway.Name = "checkBoxRunway";
            this.checkBoxRunway.Size = new System.Drawing.Size(113, 17);
            this.checkBoxRunway.TabIndex = 5;
            this.checkBoxRunway.Text = "Взлётная полоса";
            this.checkBoxRunway.UseVisualStyleBackColor = true;
            // 
            // checkBoxPlane
            // 
            this.checkBoxPlane.AutoSize = true;
            this.checkBoxPlane.Location = new System.Drawing.Point(278, 66);
            this.checkBoxPlane.Name = "checkBoxPlane";
            this.checkBoxPlane.Size = new System.Drawing.Size(70, 17);
            this.checkBoxPlane.TabIndex = 4;
            this.checkBoxPlane.Text = "Самолёт";
            this.checkBoxPlane.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(83, 104);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(83, 41);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(24, 88);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(61, 13);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес судна:";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(24, 25);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(87, 13);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Макс.скорость:";
            // 
            // groupBoxTypeWarShip
            // 
            this.groupBoxTypeWarShip.Controls.Add(this.labelAircraftCarrier);
            this.groupBoxTypeWarShip.Controls.Add(this.labelWarShip);
            this.groupBoxTypeWarShip.Location = new System.Drawing.Point(12, 41);
            this.groupBoxTypeWarShip.Name = "groupBoxTypeWarShip";
            this.groupBoxTypeWarShip.Size = new System.Drawing.Size(200, 182);
            this.groupBoxTypeWarShip.TabIndex = 1;
            this.groupBoxTypeWarShip.TabStop = false;
            this.groupBoxTypeWarShip.Text = "Тип военного судна";
            // 
            // labelAircraftCarrier
            // 
            this.labelAircraftCarrier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAircraftCarrier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAircraftCarrier.Location = new System.Drawing.Point(27, 107);
            this.labelAircraftCarrier.Name = "labelAircraftCarrier";
            this.labelAircraftCarrier.Size = new System.Drawing.Size(137, 51);
            this.labelAircraftCarrier.TabIndex = 2;
            this.labelAircraftCarrier.Text = "Авианосец";
            this.labelAircraftCarrier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAircraftCarrier.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAircraftCarrier_MouseDown);
            // 
            // labelWarShip
            // 
            this.labelWarShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWarShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWarShip.Location = new System.Drawing.Point(27, 32);
            this.labelWarShip.Name = "labelWarShip";
            this.labelWarShip.Size = new System.Drawing.Size(137, 50);
            this.labelWarShip.TabIndex = 1;
            this.labelWarShip.Text = "Военный корабль";
            this.labelWarShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWarShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelWarShip_MouseDown);
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.Location = new System.Drawing.Point(32, 40);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(221, 126);
            this.pictureBoxDisplay.TabIndex = 2;
            this.pictureBoxDisplay.TabStop = false;
            // 
            // panelDisplay
            // 
            this.panelDisplay.AllowDrop = true;
            this.panelDisplay.Controls.Add(this.pictureBoxDisplay);
            this.panelDisplay.Location = new System.Drawing.Point(274, 41);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(287, 202);
            this.panelDisplay.TabIndex = 3;
            this.panelDisplay.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelDisplay_DragDrop);
            this.panelDisplay.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelDisplay_DragEnter);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.labelDopColor);
            this.groupBoxColors.Controls.Add(this.panelPurpleColor);
            this.groupBoxColors.Controls.Add(this.labelMainColor);
            this.groupBoxColors.Controls.Add(this.panelRedColor);
            this.groupBoxColors.Controls.Add(this.panelCoralColor);
            this.groupBoxColors.Controls.Add(this.panelBlackColor);
            this.groupBoxColors.Controls.Add(this.panelBlueColor);
            this.groupBoxColors.Controls.Add(this.panelOrangeColor);
            this.groupBoxColors.Controls.Add(this.panelGreenColor);
            this.groupBoxColors.Controls.Add(this.panelYellowColor);
            this.groupBoxColors.Location = new System.Drawing.Point(584, 41);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(255, 209);
            this.groupBoxColors.TabIndex = 4;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDopColor.Location = new System.Drawing.Point(142, 32);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(103, 42);
            this.labelDopColor.TabIndex = 3;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // panelPurpleColor
            // 
            this.panelPurpleColor.BackColor = System.Drawing.Color.MediumOrchid;
            this.panelPurpleColor.Location = new System.Drawing.Point(197, 146);
            this.panelPurpleColor.Name = "panelPurpleColor";
            this.panelPurpleColor.Size = new System.Drawing.Size(48, 36);
            this.panelPurpleColor.TabIndex = 5;
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainColor.Location = new System.Drawing.Point(20, 32);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(103, 42);
            this.labelMainColor.TabIndex = 2;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // panelRedColor
            // 
            this.panelRedColor.BackColor = System.Drawing.Color.OrangeRed;
            this.panelRedColor.Location = new System.Drawing.Point(197, 90);
            this.panelRedColor.Name = "panelRedColor";
            this.panelRedColor.Size = new System.Drawing.Size(48, 36);
            this.panelRedColor.TabIndex = 5;
            // 
            // panelCoralColor
            // 
            this.panelCoralColor.BackColor = System.Drawing.Color.Coral;
            this.panelCoralColor.Location = new System.Drawing.Point(143, 146);
            this.panelCoralColor.Name = "panelCoralColor";
            this.panelCoralColor.Size = new System.Drawing.Size(48, 36);
            this.panelCoralColor.TabIndex = 9;
            // 
            // panelBlackColor
            // 
            this.panelBlackColor.BackColor = System.Drawing.Color.Black;
            this.panelBlackColor.Location = new System.Drawing.Point(142, 90);
            this.panelBlackColor.Name = "panelBlackColor";
            this.panelBlackColor.Size = new System.Drawing.Size(48, 36);
            this.panelBlackColor.TabIndex = 8;
            // 
            // panelBlueColor
            // 
            this.panelBlueColor.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelBlueColor.Location = new System.Drawing.Point(75, 146);
            this.panelBlueColor.Name = "panelBlueColor";
            this.panelBlueColor.Size = new System.Drawing.Size(48, 36);
            this.panelBlueColor.TabIndex = 7;
            // 
            // panelOrangeColor
            // 
            this.panelOrangeColor.BackColor = System.Drawing.Color.Orange;
            this.panelOrangeColor.Location = new System.Drawing.Point(75, 90);
            this.panelOrangeColor.Name = "panelOrangeColor";
            this.panelOrangeColor.Size = new System.Drawing.Size(48, 36);
            this.panelOrangeColor.TabIndex = 6;
            // 
            // panelGreenColor
            // 
            this.panelGreenColor.BackColor = System.Drawing.Color.PaleGreen;
            this.panelGreenColor.Location = new System.Drawing.Point(20, 146);
            this.panelGreenColor.Name = "panelGreenColor";
            this.panelGreenColor.Size = new System.Drawing.Size(48, 36);
            this.panelGreenColor.TabIndex = 5;
            // 
            // panelYellowColor
            // 
            this.panelYellowColor.BackColor = System.Drawing.Color.Yellow;
            this.panelYellowColor.Location = new System.Drawing.Point(20, 90);
            this.panelYellowColor.Name = "panelYellowColor";
            this.panelYellowColor.Size = new System.Drawing.Size(48, 36);
            this.panelYellowColor.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(737, 303);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(85, 36);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(737, 355);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(85, 34);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormWaterTransportConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.groupBoxTypeWarShip);
            this.Controls.Add(this.groupBoxParameters);
            this.Name = "FormWaterTransportConfig";
            this.Text = "Выбор военного судна";
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            this.groupBoxTypeWarShip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.panelDisplay.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.GroupBox groupBoxTypeWarShip;
        private System.Windows.Forms.CheckBox checkBoxRadar;
        private System.Windows.Forms.CheckBox checkBoxRunway;
        private System.Windows.Forms.CheckBox checkBoxPlane;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.Label labelAircraftCarrier;
        private System.Windows.Forms.Label labelWarShip;
        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Panel panelPurpleColor;
        private System.Windows.Forms.Panel panelRedColor;
        private System.Windows.Forms.Panel panelCoralColor;
        private System.Windows.Forms.Panel panelBlackColor;
        private System.Windows.Forms.Panel panelBlueColor;
        private System.Windows.Forms.Panel panelOrangeColor;
        private System.Windows.Forms.Panel panelGreenColor;
        private System.Windows.Forms.Panel panelYellowColor;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}