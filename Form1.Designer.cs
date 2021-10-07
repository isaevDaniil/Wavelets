namespace Wavelets
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.calcCoefButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.singleSignalFilePath = new System.Windows.Forms.TextBox();
            this.openSingleSignalFileButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.WaveletsType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aValue = new System.Windows.Forms.TextBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.directoryPath = new System.Windows.Forms.TextBox();
            this.openDirectoryButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.filesMask = new System.Windows.Forms.TextBox();
            this.isReadyLabel = new System.Windows.Forms.Label();
            this.aMinValue = new System.Windows.Forms.TextBox();
            this.aMaxValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.SuspendLayout();
            // 
            // graph
            // 
            chartArea1.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graph.Legends.Add(legend1);
            this.graph.Location = new System.Drawing.Point(2, 12);
            this.graph.Name = "graph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graph.Series.Add(series1);
            this.graph.Size = new System.Drawing.Size(756, 466);
            this.graph.TabIndex = 0;
            this.graph.Text = "chart1";
            // 
            // calcCoefButton
            // 
            this.calcCoefButton.Location = new System.Drawing.Point(767, 264);
            this.calcCoefButton.Name = "calcCoefButton";
            this.calcCoefButton.Size = new System.Drawing.Size(75, 23);
            this.calcCoefButton.TabIndex = 1;
            this.calcCoefButton.Text = "ОК";
            this.calcCoefButton.UseVisualStyleBackColor = true;
            this.calcCoefButton.Click += new System.EventHandler(this.calcCoefButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "signalFile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(764, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите файл с сигналом:";
            // 
            // singleSignalFilePath
            // 
            this.singleSignalFilePath.Location = new System.Drawing.Point(767, 28);
            this.singleSignalFilePath.Name = "singleSignalFilePath";
            this.singleSignalFilePath.Size = new System.Drawing.Size(147, 20);
            this.singleSignalFilePath.TabIndex = 3;
            // 
            // openSingleSignalFileButton
            // 
            this.openSingleSignalFileButton.Location = new System.Drawing.Point(920, 28);
            this.openSingleSignalFileButton.Name = "openSingleSignalFileButton";
            this.openSingleSignalFileButton.Size = new System.Drawing.Size(75, 20);
            this.openSingleSignalFileButton.TabIndex = 4;
            this.openSingleSignalFileButton.Text = "Открыть";
            this.openSingleSignalFileButton.UseVisualStyleBackColor = true;
            this.openSingleSignalFileButton.Click += new System.EventHandler(this.openSingleSignalFileButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(764, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите тип вейвлета:";
            // 
            // WaveletsType
            // 
            this.WaveletsType.FormattingEnabled = true;
            this.WaveletsType.Items.AddRange(new object[] {
            "Wave",
            "MHAT"});
            this.WaveletsType.Location = new System.Drawing.Point(767, 235);
            this.WaveletsType.Name = "WaveletsType";
            this.WaveletsType.Size = new System.Drawing.Size(121, 21);
            this.WaveletsType.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(764, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите масштаб a:";
            // 
            // aValue
            // 
            this.aValue.Location = new System.Drawing.Point(767, 326);
            this.aValue.Name = "aValue";
            this.aValue.Size = new System.Drawing.Size(147, 20);
            this.aValue.TabIndex = 8;
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(767, 352);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(87, 23);
            this.drawButton.TabIndex = 9;
            this.drawButton.Text = "Нарисовать";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(764, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Выберите папку и введите маску файлов:";
            // 
            // directoryPath
            // 
            this.directoryPath.Location = new System.Drawing.Point(767, 88);
            this.directoryPath.Name = "directoryPath";
            this.directoryPath.Size = new System.Drawing.Size(147, 20);
            this.directoryPath.TabIndex = 11;
            // 
            // openDirectoryButton
            // 
            this.openDirectoryButton.Location = new System.Drawing.Point(920, 88);
            this.openDirectoryButton.Name = "openDirectoryButton";
            this.openDirectoryButton.Size = new System.Drawing.Size(75, 20);
            this.openDirectoryButton.TabIndex = 12;
            this.openDirectoryButton.Text = "Открыть";
            this.openDirectoryButton.UseVisualStyleBackColor = true;
            this.openDirectoryButton.Click += new System.EventHandler(this.openDirectoryButton_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(823, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "ИЛИ";
            // 
            // filesMask
            // 
            this.filesMask.Location = new System.Drawing.Point(767, 114);
            this.filesMask.Name = "filesMask";
            this.filesMask.Size = new System.Drawing.Size(147, 20);
            this.filesMask.TabIndex = 14;
            // 
            // isReadyLabel
            // 
            this.isReadyLabel.AutoSize = true;
            this.isReadyLabel.Location = new System.Drawing.Point(948, 421);
            this.isReadyLabel.Name = "isReadyLabel";
            this.isReadyLabel.Size = new System.Drawing.Size(0, 13);
            this.isReadyLabel.TabIndex = 15;
            // 
            // aMinValue
            // 
            this.aMinValue.Location = new System.Drawing.Point(806, 157);
            this.aMinValue.Name = "aMinValue";
            this.aMinValue.Size = new System.Drawing.Size(108, 20);
            this.aMinValue.TabIndex = 16;
            // 
            // aMaxValue
            // 
            this.aMaxValue.Location = new System.Drawing.Point(806, 183);
            this.aMaxValue.Name = "aMaxValue";
            this.aMaxValue.Size = new System.Drawing.Size(108, 20);
            this.aMaxValue.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(764, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "aMIN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(764, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "aMAX:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 490);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.aMaxValue);
            this.Controls.Add(this.aMinValue);
            this.Controls.Add(this.isReadyLabel);
            this.Controls.Add(this.filesMask);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.openDirectoryButton);
            this.Controls.Add(this.directoryPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.aValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WaveletsType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.openSingleSignalFileButton);
            this.Controls.Add(this.singleSignalFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcCoefButton);
            this.Controls.Add(this.graph);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.Button calcCoefButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox singleSignalFilePath;
        private System.Windows.Forms.Button openSingleSignalFileButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox WaveletsType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aValue;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox directoryPath;
        private System.Windows.Forms.Button openDirectoryButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox filesMask;
        private System.Windows.Forms.Label isReadyLabel;
        private System.Windows.Forms.TextBox aMinValue;
        private System.Windows.Forms.TextBox aMaxValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

