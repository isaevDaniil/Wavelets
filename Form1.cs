using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Wavelets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcCoefButton_Click(object sender, EventArgs e)
        {
            isReadyLabel.Text = "Считаем...";
            Update();
            WaveletsLogic.aMin = int.Parse(aMinValue.Text);
            WaveletsLogic.aMax = int.Parse(aMaxValue.Text);
            WaveletsLogic.Wavelet selectedWavelet = null;
            switch (WaveletsType.SelectedIndex)
            {
                case 0:
                    selectedWavelet = WaveletsLogic.Wave;
                    break;
                case 1:
                    selectedWavelet = WaveletsLogic.MHAT;
                    break;
            }          
            if (!string.IsNullOrWhiteSpace(singleSignalFilePath.Text))
            {
                WaveletsLogic.transformCoefs = Utils.CalcCoefsForFile(singleSignalFilePath.Text, selectedWavelet);
            }
            else
            {
                IEnumerable<string> filePaths = Directory.EnumerateFiles(directoryPath.Text, filesMask.Text + ".txt");
                Utils.CalcCoefsForArrayOfFiles(filePaths, selectedWavelet);
            }
            isReadyLabel.Text = "Готово";
        }

        private void openSingleSignalFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            singleSignalFilePath.Text = openFileDialog1.FileName;
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            graph.Series[0].Points.Clear();
            int a = int.Parse(aValue.Text);
            for (int i = 0; i < WaveletsLogic.transformCoefs[a - WaveletsLogic.aMin].Count; i++) 
            {
                graph.Series[0].Points.AddY(WaveletsLogic.transformCoefs[a][i]);
            }
        }

        private void openDirectoryButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            directoryPath.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}
