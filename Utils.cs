using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Wavelets
{
    public class Utils
    {
        public static void CalcCoefsForArrayOfFiles(IEnumerable<string> filePaths, WaveletsLogic.Wavelet selectedWavelet)
        {
            var signals = new List<List<double>>();
            List<List<double>> resultCoefs = new List<List<double>>();
            foreach (var filePath in filePaths)
            {
                using (var sr = new StreamReader(filePath))
                {
                    var tempSignal = new List<double>();
                    while (!sr.EndOfStream)
                    {
                        tempSignal.Add(double.Parse(sr.ReadLine()));
                    }
                    signals.Add(tempSignal);
                }
                resultCoefs = WaveletsLogic.DisreteTransform(signals.Last(), selectedWavelet);
                WriteCoefsToFile(resultCoefs, filePath);
                resultCoefs.Clear();
            }
        }

        public static List<List<double>> CalcCoefsForFile(string filePath, WaveletsLogic.Wavelet selectedWavelet)
        {
            var signal = new List<double>();
            /*using (var sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    signal.Add(double.Parse(sr.ReadLine()));
                }
            }*/
            var r = new Random();
            for (int i = 0; i < 100; i++)
            {
                signal.Add(r.Next());
            }
            //signal[49] = 1;
            List<List<double>> resultCoefs = WaveletsLogic.DisreteTransform(signal, selectedWavelet);
            WriteCoefsToFile(resultCoefs, filePath);
            return resultCoefs;
        }

        private static void WriteCoefsToFile(List<List<double>> coefs, string filePath)
        {
            using (var stream = new StreamWriter(filePath.Insert(filePath.Length - 4, "Result")))
            {
                for (int i = 0; i < coefs.Count; i++)
                {
                    for (int j = 0; j < coefs[i].Count; j++)
                    {
                        stream.Write(coefs[i][j] + "\t");
                    }
                    stream.Write("\n");
                }
            }
        }
    }
}
