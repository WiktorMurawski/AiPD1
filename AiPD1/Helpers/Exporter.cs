using AiPD1.Core;
using System.Text;

namespace AiPD1.Helpers
{
    internal static class Exporter
    {
        public static void ExportFrameLevelTimeParametersToCsv(string filePath, TimeParameters tp, int sampleRate)
        {
            using var writer = new StreamWriter(filePath, false, Encoding.UTF8);

            string header = "FrameIndex,Time_sec,Volume,ShortTimeEnergy,ZeroCrossingRate,SilentRatio,"
                            + "VoicedRatio,FundamentalFrequencyAutocorrelation,FundamentalFrequencyAMDF";
            writer.WriteLine(header);

            int frameCount = tp.Volume.Length;

            for (int i = 0; i < frameCount; i++)
            {
                double timeSec = (double)(i) / sampleRate;

                string row = $"{i},{timeSec:F6},{tp.Volume[i]},{tp.ShortTimeEnergy[i]},{tp.ZeroCrossingRate[i]},{tp.SilentRatio[i]},"
                             + $"{tp.VoicedRatio[i]},{tp.FundamentalFrequencyAutocorrelation[i]},{tp.FundamentalFrequencyAMDF[i]}";
                writer.WriteLine(row);
            }
        }

        public static void ExportClipLevelTimeParameters(string filePath, TimeParameters tp)
        {
            using var writer = new StreamWriter(filePath, false, Encoding.UTF8);
            string header = "Parameter,Value";
            writer.WriteLine(header);
            writer.WriteLine($"VSTD,{tp.VSTD}");
            writer.WriteLine($"VMEAN,{tp.VMEAN}");
            writer.WriteLine($"VDR,{tp.VDR}");
            writer.WriteLine($"VU,{tp.VU}");
            writer.WriteLine($"LSTER,{tp.LSTER}");
            writer.WriteLine($"EnergyEntropy,{tp.EnergyEntropy}");
            writer.WriteLine($"ZSTD,{tp.ZSTD}");
            writer.WriteLine($"HZCRR,{tp.HZCRR}");
        }
    }
}
