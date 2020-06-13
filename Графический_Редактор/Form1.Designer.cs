namespace Графический_Редактор
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.drawBtn = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.btnInvertChannel = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btn_OrigImage = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.spinBoxBrushWidth = new System.Windows.Forms.NumericUpDown();
            this.btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxBrushWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(960, 481);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panelColor
            // 
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor.Location = new System.Drawing.Point(76, 499);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(20, 20);
            this.panelColor.TabIndex = 21;
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnChangeColor.BackColor = System.Drawing.Color.Silver;
            this.btnChangeColor.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeColor.ForeColor = System.Drawing.Color.Black;
            this.btnChangeColor.Location = new System.Drawing.Point(102, 497);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(102, 36);
            this.btnChangeColor.TabIndex = 20;
            this.btnChangeColor.Text = "Цвет";
            this.btnChangeColor.UseVisualStyleBackColor = false;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // drawBtn
            // 
            this.drawBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.drawBtn.BackColor = System.Drawing.Color.Silver;
            this.drawBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawBtn.ForeColor = System.Drawing.Color.Black;
            this.drawBtn.Location = new System.Drawing.Point(210, 497);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(102, 36);
            this.drawBtn.TabIndex = 19;
            this.drawBtn.Text = "Рисовать";
            this.drawBtn.UseVisualStyleBackColor = false;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.White;
            this.comboBox.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox.ForeColor = System.Drawing.Color.Black;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(903, 499);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(38, 34);
            this.comboBox.TabIndex = 12;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // btnInvertChannel
            // 
            this.btnInvertChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnInvertChannel.BackColor = System.Drawing.Color.Silver;
            this.btnInvertChannel.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInvertChannel.ForeColor = System.Drawing.Color.Black;
            this.btnInvertChannel.Location = new System.Drawing.Point(754, 497);
            this.btnInvertChannel.Name = "btnInvertChannel";
            this.btnInvertChannel.Size = new System.Drawing.Size(143, 36);
            this.btnInvertChannel.TabIndex = 18;
            this.btnInvertChannel.Text = "Отразить канал";
            this.btnInvertChannel.UseVisualStyleBackColor = false;
            this.btnInvertChannel.Click += new System.EventHandler(this.btnInvertChannel_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnNegative.BackColor = System.Drawing.Color.Silver;
            this.btnNegative.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNegative.ForeColor = System.Drawing.Color.Black;
            this.btnNegative.Location = new System.Drawing.Point(644, 497);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(104, 36);
            this.btnNegative.TabIndex = 17;
            this.btnNegative.Text = "Негатив";
            this.btnNegative.UseVisualStyleBackColor = false;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btn_OrigImage
            // 
            this.btn_OrigImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_OrigImage.BackColor = System.Drawing.Color.Silver;
            this.btn_OrigImage.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_OrigImage.ForeColor = System.Drawing.Color.Black;
            this.btn_OrigImage.Location = new System.Drawing.Point(318, 497);
            this.btn_OrigImage.Name = "btn_OrigImage";
            this.btn_OrigImage.Size = new System.Drawing.Size(102, 36);
            this.btn_OrigImage.TabIndex = 16;
            this.btn_OrigImage.Text = "Заново";
            this.btn_OrigImage.UseVisualStyleBackColor = false;
            this.btn_OrigImage.Click += new System.EventHandler(this.btn_OrigImage_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(536, 497);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 36);
            this.button3.TabIndex = 15;
            this.button3.Text = "Сепия";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(426, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "ЧБ Фильтр";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(426, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 53);
            this.button1.TabIndex = 13;
            this.button1.Text = "Выбрать Картинку";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // spinBoxBrushWidth
            // 
            this.spinBoxBrushWidth.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinBoxBrushWidth.Location = new System.Drawing.Point(30, 497);
            this.spinBoxBrushWidth.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.spinBoxBrushWidth.Name = "spinBoxBrushWidth";
            this.spinBoxBrushWidth.Size = new System.Drawing.Size(40, 27);
            this.spinBoxBrushWidth.TabIndex = 22;
            this.spinBoxBrushWidth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Save.BackColor = System.Drawing.Color.Silver;
            this.btn_Save.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Location = new System.Drawing.Point(534, 539);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(104, 53);
            this.btn_Save.TabIndex = 23;
            this.btn_Save.Text = "Сохранить Картинку";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 621);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.spinBoxBrushWidth);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.btnInvertChannel);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btn_OrigImage);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxBrushWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button btnInvertChannel;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btn_OrigImage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown spinBoxBrushWidth;
        private System.Windows.Forms.Button btn_Save;
    }
}

