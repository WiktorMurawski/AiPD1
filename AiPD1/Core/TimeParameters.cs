namespace AiPD1.Core
{
    internal class TimeParameters
    {
        // --- Cechy na poziomie ramki ---
        public float[] Volume { get; private set; } = Array.Empty<float>();
        public float[] ShortTimeEnergy { get; private set; } = Array.Empty<float>();
        public float[] ZeroCrossingRate { get; private set; } = Array.Empty<float>();
        public float[] SilentRatio { get; private set; } = Array.Empty<float>();
        public float[] FundamentalFrequencyAutocorrelation { get; private set; } = Array.Empty<float>();
        public float[] FundamentalFrequencyAMDF { get; private set; } = Array.Empty<float>();

        // --- Cechy na poziomie klipu ---
        // Bazujące na Volume
        public float VSTD { get; private set; } = 0;
        public float VMEAN { get; private set; } = 0;
        public float VDR { get; private set; } = 0;
        public float VU { get; private set; } = 0;

        // Bazujące na ShortTimeEnergy
        public float LSTER { get; private set; } = 0;
        public float EnergyEntropy { get; private set; } = 0;

        // Bazujące na ZeroCrossingRate
        public float ZSTD { get; private set; } = 0;
        public float HZCRR { get; private set; } = 0;

        //public float VolumeSilenceThreshold { get; set; } = 0.003f;
        public float VolumeSilenceThreshold { get; set; } = 0.005f;
        public float ZCRSilenceThreshold { get; set; } = 0.001f;

        // Do Autocorrelation i AMDF
        public int MinLag { get; set; } = 50;
        public int MaxLag { get; set; } = 200;

        public void CalculateParameters(IReadOnlyList<float[]> frames, int sampleRate, int frameSize)
        {
            Volume = CalculateVolume(frames);
            ShortTimeEnergy = CalculateShortTimeEnergy(frames);
            ZeroCrossingRate = CalculateZeroCrossingRate(frames);
            SilentRatio = CalculateSilentRatio(frames);
            FundamentalFrequencyAutocorrelation = CalculateFundamentalFrequencyAutocorrelation(frames, sampleRate);
            FundamentalFrequencyAMDF = CalculateFundamentalFrequencyAMDF(frames, sampleRate);

            VSTD = CalculateVSTD(Volume);
            VMEAN = CalculateVMEAN(Volume);
            VDR = CalculateVDR(Volume);
            VU = CalculateVU(Volume);

            LSTER = CalculateLSTER(ShortTimeEnergy);
            //EnergyEntropy = CalculateEnergyEntropy(ShortTimeEnergy);

            ZSTD = CalculateZSTD(ZeroCrossingRate);
            //HZCRR = CalculateHZCRR(ZeroCrossingRate);

        }

        // --- Cechy na poziomie ramek ---
        private float[] CalculateVolume(IReadOnlyList<float[]> frames)
        {
            int frameCount = frames.Count;
            float[] volumeArray = new float[frameCount];

            for (int i = 0; i < frameCount; i++)
            {
                float[] frame = frames[i];
                float sumOfSquares = 0f;
                foreach (float sample in frame)
                {
                    sumOfSquares += sample * sample;
                }
                volumeArray[i] = (float)Math.Sqrt(sumOfSquares / frame.Length);
            }

            return volumeArray;
        }

        private float[] CalculateShortTimeEnergy(IReadOnlyList<float[]> frames)
        {
            int frameCount = frames.Count;
            float[] steArray = new float[frameCount];

            for (int i = 0; i < frameCount; i++)
            {
                float[] frame = frames[i];
                float sumOfSquares = 0f;
                foreach (float sample in frame)
                {
                    sumOfSquares += sample * sample;
                }
                steArray[i] = sumOfSquares / frame.Length;
            }

            return steArray;
        }

        private float[] CalculateZeroCrossingRate(IReadOnlyList<float[]> frames)
        {
            int frameCount = frames.Count;
            float[] zceArray = new float[frameCount];

            for (int i = 0; i < frameCount; i++)
            {
                float[] frame = frames[i];
                float sum = 0;
                for (int j = 1; j < frame.Length; j++)
                {
                    sum += 0.5f * Math.Abs(Math.Sign(frame[j]) - Math.Sign(frame[j - 1]));
                    //if (Math.Sign(frame[j]) != Math.Sign(frame[j - 1]))
                    //{
                    //    sum++;
                    //}
                }
                zceArray[i] = sum / frameCount;
            }

            return zceArray;
        }

        private float[] CalculateSilentRatio(IReadOnlyList<float[]> frames)
        {
            int frameCount = frames.Count;
            float[] srArray = new float[frameCount];

            for (int i = 0; i < frameCount; i++)
            {
                float[] frame = frames[i];
                srArray[i] = ZeroCrossingRate[i] >= ZCRSilenceThreshold && Volume[i] <= VolumeSilenceThreshold ? 1 : 0;
            }

            return srArray;
        }

        private float[] CalculateFundamentalFrequencyAutocorrelation(IReadOnlyList<float[]> frames, int sampleRate)
        {
            int frameCount = frames.Count;
            float[] ffArray = new float[frameCount];

            for (int i = 0; i < frameCount; i++)
            {
                float[] frame = frames[i];
                float maxCorrelation = float.MinValue;
                int bestLag = 0;
                for (int lag = MinLag; lag <= MaxLag; lag++)
                {
                    float correlation = 0f;
                    for (int j = 0; j < frame.Length - lag; j++)
                    {
                        correlation += frame[j] * frame[j + lag];
                    }
                    if (correlation > maxCorrelation)
                    {
                        maxCorrelation = correlation;
                        bestLag = lag;
                    }
                }

                ffArray[i] = (bestLag >= MinLag && maxCorrelation > 0.35f)
                    ? (float)sampleRate / bestLag
                    : 0f;
            }

            return ffArray;
        }

        private float[] CalculateFundamentalFrequencyAMDF(IReadOnlyList<float[]> frames, int sampleRate)
        {
            int frameCount = frames.Count;
            float[] ffArray = new float[frameCount];

            for (int i = 0; i < frameCount; i++)
            {
                float[] frame = frames[i];
                float minAMDF = float.MaxValue;
                int bestLag = 0;
                for (int lag = MinLag; lag <= MaxLag; lag++)
                {
                    float amdf = 0f;
                    for (int j = 0; j < frame.Length - lag; j++)
                    {
                        amdf += Math.Abs(frame[j + lag] - frame[j]);
                    }
                    if (amdf < minAMDF)
                    {
                        minAMDF = amdf;
                        bestLag = lag;
                    }
                }

                ffArray[i] = (bestLag >= MinLag)
                    ? (float)sampleRate / bestLag
                    : 0f;
            }

            return ffArray;
        }

        // --- Cechy na poziomie klipu ---
        private float CalculateVSTD(float[] volume)
        {
            float mean = volume.Average();
            float std = MathF.Sqrt(volume.Average(v => MathF.Pow(v - mean, 2)));
            return std;
        }

        private float CalculateVMEAN(float[] volume)
        {
            float mean = volume.Average();
            return mean;
        }

        private float CalculateVDR(float[] volume)
        {
            float min = volume.Min();
            float max = volume.Max();
            float vdr = (max - min) / (max + 1e-10f);
            return vdr;
        }

        private float CalculateVU(float[] volume)
        {
            var extrema = new List<float>();

            for (int i = 1; i < volume.Length - 1; i++)
            {
                bool isPeak = volume[i] > volume[i - 1] && volume[i] > volume[i + 1];
                bool isValley = volume[i] < volume[i - 1] && volume[i] < volume[i + 1];

                if (isPeak || isValley)
                    extrema.Add(volume[i]);
            }

            float vu = 0f;
            for (int i = 1; i < extrema.Count; i++)
                vu += Math.Abs(extrema[i] - extrema[i - 1]);
            if (extrema.Count > 0)
                vu /= extrema.Count;

            return vu;
        }

        float CalculateLSTER(float[] ste)
        {
            float avSTE = ste.Average();
            int N = ste.Length;

            float sum = 0f;
            for (int n = 0; n < N; n++)
            {
                float val = 0.5f * avSTE - ste[n];
                int sgn = val > 0 ? 1 : (val < 0 ? -1 : 0);
                sum += sgn + 1;
            }

            return sum / (2f * N);
        }

        private float CalculateEnergyEntropy(float[] ste)
        {
            throw new NotImplementedException();
        }

        private float CalculateZSTD(float[] zcr)
        {
            float mean = zcr.Average();
            float std = MathF.Sqrt(zcr.Average(x => MathF.Pow(x - mean, 2)));
            return std;
        }

        private float CalculateHZCRR(float[] zcr)
        {
            throw new NotImplementedException();
        }
    }
}
