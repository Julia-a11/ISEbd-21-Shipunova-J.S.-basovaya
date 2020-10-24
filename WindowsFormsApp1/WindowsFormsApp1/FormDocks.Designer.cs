namespace Laboratornaya
{
    partial class FormDocks
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxDocks = new System.Windows.Forms.PictureBox();
            this.buttonParkingWarShip = new System.Windows.Forms.Button();
            this.buttonParkingAircraftCarrier = new System.Windows.Forms.Button();
            this.buttonTakeShip = new System.Windows.Forms.Button();
            this.labelPlaceNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxTakeShip = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocks)).BeginInit();
            this.groupBoxTakeShip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDocks
            // 
            this.pictureBoxDocks.Location = new System.Drawing.Point(1, 1);
            this.pictureBoxDocks.Name = "pictureBoxDocks";
            this.pictureBoxDocks.Size = new System.Drawing.Size(750, 461);
            this.pictureBoxDocks.TabIndex = 0;
            this.pictureBoxDocks.TabStop = false;
            // 
            // buttonParkingWarShip
            // 
            this.buttonParkingWarShip.Location = new System.Drawing.Point(761, 15);
            this.buttonParkingWarShip.Name = "buttonParkingWarShip";
            this.buttonParkingWarShip.Size = new System.Drawing.Size(113, 51);
            this.buttonParkingWarShip.TabIndex = 1;
            this.buttonParkingWarShip.Text = "Припарковать военный корабль";
            this.buttonParkingWarShip.UseVisualStyleBackColor = true;
            this.buttonParkingWarShip.Click += new System.EventHandler(this.buttonParkingWarShip_Click);
            // 
            // buttonParkingAircraftCarrier
            // 
            this.buttonParkingAircraftCarrier.Location = new System.Drawing.Point(761, 72);
            this.buttonParkingAircraftCarrier.Name = "buttonParkingAircraftCarrier";
            this.buttonParkingAircraftCarrier.Size = new System.Drawing.Size(113, 51);
            this.buttonParkingAircraftCarrier.TabIndex = 2;
            this.buttonParkingAircraftCarrier.Text = "Припарковать авианосец";
            this.buttonParkingAircraftCarrier.UseVisualStyleBackColor = true;
            this.buttonParkingAircraftCarrier.Click += new System.EventHandler(this.buttonParkingAircraftCarrier_Click);
            // 
            // buttonTakeShip
            // 
            this.buttonTakeShip.Location = new System.Drawing.Point(6, 77);
            this.buttonTakeShip.Name = "buttonTakeShip";
            this.buttonTakeShip.Size = new System.Drawing.Size(103, 22);
            this.buttonTakeShip.TabIndex = 3;
            this.buttonTakeShip.Text = "Забрать";
            this.buttonTakeShip.Click += new System.EventHandler(this.buttonTakeShip_Click);
            // 
            // labelPlaceNumber
            // 
            this.labelPlaceNumber.AutoSize = true;
            this.labelPlaceNumber.Location = new System.Drawing.Point(6, 37);
            this.labelPlaceNumber.Name = "labelPlaceNumber";
            this.labelPlaceNumber.Size = new System.Drawing.Size(39, 13);
            this.labelPlaceNumber.TabIndex = 5;
            this.labelPlaceNumber.Text = "Место";
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(56, 34);
            this.maskedTextBoxNumber.Mask = "00";
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(49, 20);
            this.maskedTextBoxNumber.TabIndex = 6;
            this.maskedTextBoxNumber.ValidatingType = typeof(int);
            // 
            // groupBoxTakeShip
            // 
            this.groupBoxTakeShip.Controls.Add(this.maskedTextBoxNumber);
            this.groupBoxTakeShip.Controls.Add(this.labelPlaceNumber);
            this.groupBoxTakeShip.Controls.Add(this.buttonTakeShip);
            this.groupBoxTakeShip.Location = new System.Drawing.Point(759, 129);
            this.groupBoxTakeShip.Name = "groupBoxTakeShip";
            this.groupBoxTakeShip.Size = new System.Drawing.Size(115, 124);
            this.groupBoxTakeShip.TabIndex = 8;
            this.groupBoxTakeShip.TabStop = false;
            this.groupBoxTakeShip.Text = "Забрать корабль";
            // 
            // FormDocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.groupBoxTakeShip);
            this.Controls.Add(this.buttonParkingAircraftCarrier);
            this.Controls.Add(this.buttonParkingWarShip);
            this.Controls.Add(this.pictureBoxDocks);
            this.Name = "FormDocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Доки";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocks)).EndInit();
            this.groupBoxTakeShip.ResumeLayout(false);
            this.groupBoxTakeShip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDocks;
        private System.Windows.Forms.Button buttonParkingWarShip;
        private System.Windows.Forms.Button buttonParkingAircraftCarrier;
        private System.Windows.Forms.Label labelPlaceNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
        private System.Windows.Forms.Button buttonTakeShip;
        private System.Windows.Forms.GroupBox groupBoxTakeShip;
    }
}

