namespace Main
{
    partial class applicationForm
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
            this.drawBox = new System.Windows.Forms.PictureBox();
            this.fractalChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.recursionDepthTextBox = new System.Windows.Forms.TextBox();
            this.recursionDepthLabel = new System.Windows.Forms.Label();
            this.drawFractalButton = new System.Windows.Forms.Button();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.diminishingCoefficientLabel = new System.Windows.Forms.Label();
            this.diminishingCoefficientTextBox = new System.Windows.Forms.TextBox();
            this.startColorLabel = new System.Windows.Forms.Label();
            this.endColorLabel = new System.Windows.Forms.Label();
            this.AngleLeftLabel = new System.Windows.Forms.Label();
            this.AngleLeftTextBox = new System.Windows.Forms.TextBox();
            this.savePictureButton = new System.Windows.Forms.Button();
            this.pickStartColorDialog = new System.Windows.Forms.ColorDialog();
            this.pickEndColorDialog = new System.Windows.Forms.ColorDialog();
            this.startColorChoiceButton = new System.Windows.Forms.Button();
            this.endColorChoiceButton = new System.Windows.Forms.Button();
            this.multyplyingCoefficient = new System.Windows.Forms.TrackBar();
            this.multiplyingLabel = new System.Windows.Forms.Label();
            this.AngleRightLabel = new System.Windows.Forms.Label();
            this.AngleRightTextBox = new System.Windows.Forms.TextBox();
            this.drawBoxFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multyplyingCoefficient)).BeginInit();
            this.drawBoxFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawBox
            // 
            this.drawBox.BackColor = System.Drawing.Color.White;
            this.drawBox.Location = new System.Drawing.Point(3, 2);
            this.drawBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drawBox.Name = "drawBox";
            this.drawBox.Size = new System.Drawing.Size(764, 649);
            this.drawBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.drawBox.TabIndex = 3;
            this.drawBox.TabStop = false;
            // 
            // fractalChoiceComboBox
            // 
            this.fractalChoiceComboBox.FormattingEnabled = true;
            this.fractalChoiceComboBox.Items.AddRange(new object[] {
            "С-Кривая Леви",
            "Круговой фрактал",
            "Обдуваемое ветром фрактальное дерево"});
            this.fractalChoiceComboBox.Location = new System.Drawing.Point(12, 12);
            this.fractalChoiceComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fractalChoiceComboBox.Name = "fractalChoiceComboBox";
            this.fractalChoiceComboBox.Size = new System.Drawing.Size(440, 24);
            this.fractalChoiceComboBox.TabIndex = 4;
            this.fractalChoiceComboBox.Text = "Выберите Фрактал";
            this.fractalChoiceComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // recursionDepthTextBox
            // 
            this.recursionDepthTextBox.Location = new System.Drawing.Point(12, 90);
            this.recursionDepthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recursionDepthTextBox.Name = "recursionDepthTextBox";
            this.recursionDepthTextBox.Size = new System.Drawing.Size(33, 22);
            this.recursionDepthTextBox.TabIndex = 5;
            this.recursionDepthTextBox.Text = "1";
            this.recursionDepthTextBox.Visible = false;
            this.recursionDepthTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // recursionDepthLabel
            // 
            this.recursionDepthLabel.AutoSize = true;
            this.recursionDepthLabel.Location = new System.Drawing.Point(12, 70);
            this.recursionDepthLabel.Name = "recursionDepthLabel";
            this.recursionDepthLabel.Size = new System.Drawing.Size(128, 17);
            this.recursionDepthLabel.TabIndex = 6;
            this.recursionDepthLabel.Text = "Глубина рекурсии";
            this.recursionDepthLabel.Visible = false;
            this.recursionDepthLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // drawFractalButton
            // 
            this.drawFractalButton.Location = new System.Drawing.Point(243, 583);
            this.drawFractalButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drawFractalButton.Name = "drawFractalButton";
            this.drawFractalButton.Size = new System.Drawing.Size(211, 78);
            this.drawFractalButton.TabIndex = 7;
            this.drawFractalButton.Text = "Нарисовать фрактал!";
            this.drawFractalButton.UseVisualStyleBackColor = true;
            this.drawFractalButton.Visible = false;
            this.drawFractalButton.Click += new System.EventHandler(this.drawFractal_Click);
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(9, 130);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(95, 17);
            this.lengthLabel.TabIndex = 8;
            this.lengthLabel.Text = "Длина ребра";
            this.lengthLabel.Visible = false;
            this.lengthLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(12, 161);
            this.lengthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(33, 22);
            this.lengthTextBox.TabIndex = 9;
            this.lengthTextBox.Text = "1";
            this.lengthTextBox.Visible = false;
            this.lengthTextBox.TextChanged += new System.EventHandler(this.lengthTextBox_TextChanged);
            // 
            // diminishingCoefficientLabel
            // 
            this.diminishingCoefficientLabel.AutoSize = true;
            this.diminishingCoefficientLabel.Location = new System.Drawing.Point(197, 199);
            this.diminishingCoefficientLabel.Name = "diminishingCoefficientLabel";
            this.diminishingCoefficientLabel.Size = new System.Drawing.Size(187, 17);
            this.diminishingCoefficientLabel.TabIndex = 10;
            this.diminishingCoefficientLabel.Text = "Коэффициент уменьшения";
            this.diminishingCoefficientLabel.Visible = false;
            // 
            // diminishingCoefficientTextBox
            // 
            this.diminishingCoefficientTextBox.Location = new System.Drawing.Point(213, 220);
            this.diminishingCoefficientTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diminishingCoefficientTextBox.Name = "diminishingCoefficientTextBox";
            this.diminishingCoefficientTextBox.Size = new System.Drawing.Size(33, 22);
            this.diminishingCoefficientTextBox.TabIndex = 11;
            this.diminishingCoefficientTextBox.Text = "0,85";
            this.diminishingCoefficientTextBox.Visible = false;
            this.diminishingCoefficientTextBox.TextChanged += new System.EventHandler(this.diminishingCoefficientTextBox_TextChanged);
            // 
            // startColorLabel
            // 
            this.startColorLabel.AutoSize = true;
            this.startColorLabel.Location = new System.Drawing.Point(9, 299);
            this.startColorLabel.Name = "startColorLabel";
            this.startColorLabel.Size = new System.Drawing.Size(174, 17);
            this.startColorLabel.TabIndex = 12;
            this.startColorLabel.Text = "Введите начальный цвет";
            this.startColorLabel.Visible = false;
            // 
            // endColorLabel
            // 
            this.endColorLabel.AutoSize = true;
            this.endColorLabel.Location = new System.Drawing.Point(240, 299);
            this.endColorLabel.Name = "endColorLabel";
            this.endColorLabel.Size = new System.Drawing.Size(166, 17);
            this.endColorLabel.TabIndex = 19;
            this.endColorLabel.Text = "Введите конечный цвет";
            this.endColorLabel.Visible = false;
            this.endColorLabel.Click += new System.EventHandler(this.endColorLabel_Click);
            // 
            // AngleLeftLabel
            // 
            this.AngleLeftLabel.AutoSize = true;
            this.AngleLeftLabel.Location = new System.Drawing.Point(197, 70);
            this.AngleLeftLabel.Name = "AngleLeftLabel";
            this.AngleLeftLabel.Size = new System.Drawing.Size(80, 17);
            this.AngleLeftLabel.TabIndex = 23;
            this.AngleLeftLabel.Text = "Угол слева";
            this.AngleLeftLabel.Visible = false;
            this.AngleLeftLabel.Click += new System.EventHandler(this.AngleLabel_Click);
            // 
            // AngleLeftTextBox
            // 
            this.AngleLeftTextBox.Location = new System.Drawing.Point(213, 90);
            this.AngleLeftTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AngleLeftTextBox.Name = "AngleLeftTextBox";
            this.AngleLeftTextBox.Size = new System.Drawing.Size(33, 22);
            this.AngleLeftTextBox.TabIndex = 24;
            this.AngleLeftTextBox.Text = "30";
            this.AngleLeftTextBox.Visible = false;
            this.AngleLeftTextBox.TextChanged += new System.EventHandler(this.AngleTextBox_TextChanged);
            // 
            // savePictureButton
            // 
            this.savePictureButton.Location = new System.Drawing.Point(12, 583);
            this.savePictureButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.savePictureButton.Name = "savePictureButton";
            this.savePictureButton.Size = new System.Drawing.Size(211, 78);
            this.savePictureButton.TabIndex = 28;
            this.savePictureButton.Text = "Сохранить картинку";
            this.savePictureButton.UseVisualStyleBackColor = true;
            this.savePictureButton.Visible = false;
            this.savePictureButton.Click += new System.EventHandler(this.savePictureButton_Click);
            // 
            // startColorChoiceButton
            // 
            this.startColorChoiceButton.Location = new System.Drawing.Point(12, 334);
            this.startColorChoiceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startColorChoiceButton.Name = "startColorChoiceButton";
            this.startColorChoiceButton.Size = new System.Drawing.Size(171, 53);
            this.startColorChoiceButton.TabIndex = 29;
            this.startColorChoiceButton.Text = "Тык!";
            this.startColorChoiceButton.UseVisualStyleBackColor = true;
            this.startColorChoiceButton.Visible = false;
            this.startColorChoiceButton.Click += new System.EventHandler(this.startColorChoiceButton_Click);
            // 
            // endColorChoiceButton
            // 
            this.endColorChoiceButton.Location = new System.Drawing.Point(243, 334);
            this.endColorChoiceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endColorChoiceButton.Name = "endColorChoiceButton";
            this.endColorChoiceButton.Size = new System.Drawing.Size(171, 53);
            this.endColorChoiceButton.TabIndex = 30;
            this.endColorChoiceButton.Text = "Тык!";
            this.endColorChoiceButton.UseVisualStyleBackColor = true;
            this.endColorChoiceButton.Visible = false;
            this.endColorChoiceButton.Click += new System.EventHandler(this.endColorChoiceButton_Click);
            // 
            // multyplyingCoefficient
            // 
            this.multyplyingCoefficient.Location = new System.Drawing.Point(1, 220);
            this.multyplyingCoefficient.Margin = new System.Windows.Forms.Padding(4);
            this.multyplyingCoefficient.Maximum = 5;
            this.multyplyingCoefficient.Minimum = 1;
            this.multyplyingCoefficient.Name = "multyplyingCoefficient";
            this.multyplyingCoefficient.Size = new System.Drawing.Size(139, 56);
            this.multyplyingCoefficient.TabIndex = 31;
            this.multyplyingCoefficient.Value = 1;
            this.multyplyingCoefficient.Visible = false;
            this.multyplyingCoefficient.Scroll += new System.EventHandler(this.multyplyingCoefficient_Scroll);
            // 
            // multiplyingLabel
            // 
            this.multiplyingLabel.AutoSize = true;
            this.multiplyingLabel.Location = new System.Drawing.Point(9, 199);
            this.multiplyingLabel.Name = "multiplyingLabel";
            this.multiplyingLabel.Size = new System.Drawing.Size(88, 17);
            this.multiplyingLabel.TabIndex = 4;
            this.multiplyingLabel.Text = "Увеличение";
            this.multiplyingLabel.Visible = false;
            // 
            // AngleRightLabel
            // 
            this.AngleRightLabel.AutoSize = true;
            this.AngleRightLabel.Location = new System.Drawing.Point(197, 130);
            this.AngleRightLabel.Name = "AngleRightLabel";
            this.AngleRightLabel.Size = new System.Drawing.Size(88, 17);
            this.AngleRightLabel.TabIndex = 33;
            this.AngleRightLabel.Text = "Угол справа";
            this.AngleRightLabel.Visible = false;
            this.AngleRightLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // AngleRightTextBox
            // 
            this.AngleRightTextBox.Location = new System.Drawing.Point(213, 161);
            this.AngleRightTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AngleRightTextBox.Name = "AngleRightTextBox";
            this.AngleRightTextBox.Size = new System.Drawing.Size(33, 22);
            this.AngleRightTextBox.TabIndex = 34;
            this.AngleRightTextBox.Text = "45";
            this.AngleRightTextBox.Visible = false;
            this.AngleRightTextBox.TextChanged += new System.EventHandler(this.AngleRightTextBox_TextChanged);
            // 
            // drawBoxFlowLayoutPanel
            // 
            this.drawBoxFlowLayoutPanel.AutoScroll = true;
            this.drawBoxFlowLayoutPanel.Controls.Add(this.drawBox);
            this.drawBoxFlowLayoutPanel.Location = new System.Drawing.Point(498, 12);
            this.drawBoxFlowLayoutPanel.Name = "drawBoxFlowLayoutPanel";
            this.drawBoxFlowLayoutPanel.Size = new System.Drawing.Size(773, 660);
            this.drawBoxFlowLayoutPanel.TabIndex = 32;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // applicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1351, 745);
            this.Controls.Add(this.AngleRightTextBox);
            this.Controls.Add(this.AngleRightLabel);
            this.Controls.Add(this.drawBoxFlowLayoutPanel);
            this.Controls.Add(this.multiplyingLabel);
            this.Controls.Add(this.multyplyingCoefficient);
            this.Controls.Add(this.endColorChoiceButton);
            this.Controls.Add(this.startColorChoiceButton);
            this.Controls.Add(this.savePictureButton);
            this.Controls.Add(this.AngleLeftTextBox);
            this.Controls.Add(this.AngleLeftLabel);
            this.Controls.Add(this.endColorLabel);
            this.Controls.Add(this.startColorLabel);
            this.Controls.Add(this.diminishingCoefficientTextBox);
            this.Controls.Add(this.diminishingCoefficientLabel);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.drawFractalButton);
            this.Controls.Add(this.recursionDepthLabel);
            this.Controls.Add(this.recursionDepthTextBox);
            this.Controls.Add(this.fractalChoiceComboBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(2557, 1389);
            this.MinimumSize = new System.Drawing.Size(1279, 718);
            this.Name = "applicationForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фракталы";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.applicationForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multyplyingCoefficient)).EndInit();
            this.drawBoxFlowLayoutPanel.ResumeLayout(false);
            this.drawBoxFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drawBox;
        private System.Windows.Forms.ComboBox fractalChoiceComboBox;
        private System.Windows.Forms.TextBox recursionDepthTextBox;
        private System.Windows.Forms.Label recursionDepthLabel;
        private System.Windows.Forms.Button drawFractalButton;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Label diminishingCoefficientLabel;
        private System.Windows.Forms.TextBox diminishingCoefficientTextBox;
        private System.Windows.Forms.Label startColorLabel;
        private System.Windows.Forms.Label endColorLabel;
        private System.Windows.Forms.Label AngleLeftLabel;
        private System.Windows.Forms.TextBox AngleLeftTextBox;
        private System.Windows.Forms.Button savePictureButton;
        private System.Windows.Forms.ColorDialog pickStartColorDialog;
        private System.Windows.Forms.ColorDialog pickEndColorDialog;
        private System.Windows.Forms.Button startColorChoiceButton;
        private System.Windows.Forms.Button endColorChoiceButton;
        private System.Windows.Forms.TrackBar multyplyingCoefficient;
        private System.Windows.Forms.Label multiplyingLabel;
        private System.Windows.Forms.Label AngleRightLabel;
        private System.Windows.Forms.TextBox AngleRightTextBox;
        private System.Windows.Forms.FlowLayoutPanel drawBoxFlowLayoutPanel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

