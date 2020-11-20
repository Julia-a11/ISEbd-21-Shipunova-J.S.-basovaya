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
            this.labelPlace = new System.Windows.Forms.Label();
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelTakeShip = new System.Windows.Forms.Label();
            this.groupBoxTakeShip = new System.Windows.Forms.GroupBox();
            this.labelDocks = new System.Windows.Forms.Label();
            this.textBoxDocks = new System.Windows.Forms.TextBox();
            this.buttonAddDocks = new System.Windows.Forms.Button();
            this.listBoxDocks = new System.Windows.Forms.ListBox();
            this.buttonDocksRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocks)).BeginInit();
            this.groupBoxTakeShip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDocks
            // 
            this.pictureBoxDocks.Location = new System.Drawing.Point(1, 1);
            this.pictureBoxDocks.Name = "pictureBoxDocks";
            this.pictureBoxDocks.Size = new System.Drawing.Size(755, 487);
            this.pictureBoxDocks.TabIndex = 0;
            this.pictureBoxDocks.TabStop = false;
            // 
            // buttonParkingWarShip
            // 
            this.buttonParkingWarShip.Location = new System.Drawing.Point(762, 238);
            this.buttonParkingWarShip.Name = "buttonParkingWarShip";
            this.buttonParkingWarShip.Size = new System.Drawing.Size(113, 51);
            this.buttonParkingWarShip.TabIndex = 1;
            this.buttonParkingWarShip.Text = "Припарковать военный корабль";
            this.buttonParkingWarShip.UseVisualStyleBackColor = true;
            this.buttonParkingWarShip.Click += new System.EventHandler(this.buttonParkingWarShip_Click);
            // 
            // buttonParkingAircraftCarrier
            // 
            this.buttonParkingAircraftCarrier.Location = new System.Drawing.Point(762, 295);
            this.buttonParkingAircraftCarrier.Name = "buttonParkingAircraftCarrier";
            this.buttonParkingAircraftCarrier.Size = new System.Drawing.Size(113, 51);
            this.buttonParkingAircraftCarrier.TabIndex = 2;
            this.buttonParkingAircraftCarrier.Text = "Припарковать авианосец";
            this.buttonParkingAircraftCarrier.UseVisualStyleBackColor = true;
            this.buttonParkingAircraftCarrier.Click += new System.EventHandler(this.buttonParkingAircraftCarrier_Click);
            // 
            // buttonTakeShip
            // 
            this.buttonTakeShip.Location = new System.Drawing.Point(5, 87);
            this.buttonTakeShip.Name = "buttonTakeShip";
            this.buttonTakeShip.Size = new System.Drawing.Size(103, 22);
            this.buttonTakeShip.TabIndex = 3;
            this.buttonTakeShip.Text = "Забрать";
            this.buttonTakeShip.Click += new System.EventHandler(this.buttonTakeShip_Click);
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(9, 59);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(39, 13);
            this.labelPlace.TabIndex = 5;
            this.labelPlace.Text = "Место";
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(60, 52);
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(49, 20);
            this.maskedTextBoxNumber.TabIndex = 6;
            // 
            // labelTakeShip
            // 
            this.labelTakeShip.AutoSize = true;
            this.labelTakeShip.Location = new System.Drawing.Point(9, 16);
            this.labelTakeShip.Name = "labelTakeShip";
            this.labelTakeShip.Size = new System.Drawing.Size(94, 13);
            this.labelTakeShip.TabIndex = 7;
            this.labelTakeShip.Text = "Забрать корабль";
            // 
            // groupBoxTakeShip
            // 
            this.groupBoxTakeShip.Controls.Add(this.labelTakeShip);
            this.groupBoxTakeShip.Controls.Add(this.maskedTextBoxNumber);
            this.groupBoxTakeShip.Controls.Add(this.labelPlace);
            this.groupBoxTakeShip.Controls.Add(this.buttonTakeShip);
            this.groupBoxTakeShip.Location = new System.Drawing.Point(762, 352);
            this.groupBoxTakeShip.Name = "groupBoxTakeShip";
            this.groupBoxTakeShip.Size = new System.Drawing.Size(115, 124);
            this.groupBoxTakeShip.TabIndex = 8;
            this.groupBoxTakeShip.TabStop = false;
            // 
            // labelDocks
            // 
            this.labelDocks.AutoSize = true;
            this.labelDocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDocks.Location = new System.Drawing.Point(793, 9);
            this.labelDocks.Name = "labelDocks";
            this.labelDocks.Size = new System.Drawing.Size(45, 18);
            this.labelDocks.TabIndex = 9;
            this.labelDocks.Text = "Доки";
            // 
            // textBoxDocks
            // 
            this.textBoxDocks.Location = new System.Drawing.Point(763, 30);
            this.textBoxDocks.Name = "textBoxDocks";
            this.textBoxDocks.Size = new System.Drawing.Size(108, 20);
            this.textBoxDocks.TabIndex = 10;
            // 
            // buttonAddDocks
            // 
            this.buttonAddDocks.Location = new System.Drawing.Point(762, 56);
            this.buttonAddDocks.Name = "buttonAddDocks";
            this.buttonAddDocks.Size = new System.Drawing.Size(113, 29);
            this.buttonAddDocks.TabIndex = 11;
            this.buttonAddDocks.Text = "Добавить доки";
            this.buttonAddDocks.UseVisualStyleBackColor = true;
            this.buttonAddDocks.Click += new System.EventHandler(this.buttonAddDocks_Click);
            // 
            // listBoxDocks
            // 
            this.listBoxDocks.FormattingEnabled = true;
            this.listBoxDocks.Location = new System.Drawing.Point(762, 109);
            this.listBoxDocks.Name = "listBoxDocks";
            this.listBoxDocks.Size = new System.Drawing.Size(112, 56);
            this.listBoxDocks.TabIndex = 12;
            this.listBoxDocks.SelectedIndexChanged += new System.EventHandler(this.listBoxDocks_SelectedIndexChanged);
            // 
            // buttonDocksRemove
            // 
            this.buttonDocksRemove.Location = new System.Drawing.Point(763, 171);
            this.buttonDocksRemove.Name = "buttonDocksRemove";
            this.buttonDocksRemove.Size = new System.Drawing.Size(113, 29);
            this.buttonDocksRemove.TabIndex = 13;
            this.buttonDocksRemove.Text = "Удалить доки";
            this.buttonDocksRemove.UseVisualStyleBackColor = true;
            this.buttonDocksRemove.Click += new System.EventHandler(this.buttonDocksRemove_Click);
            // 
            // FormDocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 488);
            this.Controls.Add(this.buttonDocksRemove);
            this.Controls.Add(this.listBoxDocks);
            this.Controls.Add(this.buttonAddDocks);
            this.Controls.Add(this.textBoxDocks);
            this.Controls.Add(this.labelDocks);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDocks;
        private System.Windows.Forms.Button buttonParkingWarShip;
        private System.Windows.Forms.Button buttonParkingAircraftCarrier;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
        private System.Windows.Forms.Label labelTakeShip;
        private System.Windows.Forms.Button buttonTakeShip;
        private System.Windows.Forms.GroupBox groupBoxTakeShip;
        private System.Windows.Forms.Label labelDocks;
        private System.Windows.Forms.TextBox textBoxDocks;
        private System.Windows.Forms.Button buttonAddDocks;
        private System.Windows.Forms.ListBox listBoxDocks;
        private System.Windows.Forms.Button buttonDocksRemove;
    }
}

