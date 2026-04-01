namespace AiPD1.Core
{
    internal class TimeParameters
    {
        // --- Cechy na poziomie ramki ---
        public float[] Volume { get; private set; } = Array.Empty<float>();
        public float[] ShortTimeEnergy { get; private set; } = Array.Empty<float>();
        public float[] ZeroCrossingRate { get; private set; } = Array.Empty<float>();
        public float[] SilentRatio { get; private set; } = Array.Empty<float>();
        public float[] VoicedRatio { get; private set; } = Array.Empty<float>();
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
        public static float VolumeSilenceThreshold { get; set; } = 0.0050f;
        public static float ZCRVoicedThreshold { get; set; } = 0.0800f;

        // Do Autocorrelation i AMDF
        public static float MinF0 { get; set; } = 50.0f;
        public static float MaxF0 { get; set; } = 400.0f;

        public void UpdateAllParameters(IReadOnlyList<float[]> frames, int sampleRate, int frameSize)
        {
            Volume = CalculateVolume(frames);
            ShortTimeEnergy = CalculateShortTimeEnergy(frames);
            ZeroCrossingRate = CalculateZeroCrossingRate(frames);
            SilentRatio = CalculateSilentRatio(frames);
            VoicedRatio = CalculateVoicedRatio(frames);

            FundamentalFrequencyAutocorrelation = EstimateF0Autocorrelation(frames, sampleRate, MinF0, MaxF0);
            FundamentalFrequencyAMDF = EstimateF0AMDF(frames, sampleRate, MinF0, MaxF0);

            VSTD = CalculateVSTD(Volume);
            VMEAN = CalculateVMEAN(Volume);
            VDR = CalculateVDR(Volume);
            VU = CalculateVU(Volume);

            LSTER = CalculateLSTER(ShortTimeEnergy);
            EnergyEntropy = CalculateEnergyEntropy(frames);

            ZSTD = CalculateZSTD(ZeroCrossingRate);
            HZCRR = CalculateHZCRR(ZeroCrossingRate);

            VoicedRatio = CalculateVoicedRatio(frames);
        }

        private float[] CalculateVoicedRatio(IReadOnlyList<float[]> frames)
        {
            int frameCount = frames.Count;
            float[] vrArray = new float[frameCount];
            for (int i = 0; i < frameCount; i++)
            {
                float[] frame = frames[i];
                vrArray[i] = Volume[i] > VolumeSilenceThreshold && ZeroCrossingRate[i] <= ZCRVoicedThreshold ? 1 : 0;
            }
            return vrArray;
        }

        public void UpdateVoicedRatio(IReadOnlyList<float[]> frames)
        {
            VoicedRatio = CalculateVoicedRatio(frames);
        }

        public void UpdateSilentRatio(IReadOnlyList<float[]> frames)
        {
            SilentRatio = CalculateSilentRatio(frames);
        }

        public void UpdateFundamentalFrequencies(IReadOnlyList<float[]> frames, int sampleRate)
        {
            FundamentalFrequencyAutocorrelation = EstimateF0Autocorrelation(frames, sampleRate, MinF0, MaxF0);
            FundamentalFrequencyAMDF = EstimateF0AMDF(frames, sampleRate, MinF0, MaxF0);
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
            int frameSize = frames[0].Length;
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
                zceArray[i] = sum / frameSize;
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
                //srArray[i] = ZeroCrossingRate[i] >= ZCRVoicedThreshold && Volume[i] <= VolumeSilenceThreshold ? 1 : 0;
                srArray[i] = Volume[i] <= VolumeSilenceThreshold ? 1 : 0;
            }

            return srArray;
        }

        // --- Szacowanie Fundamental Frequency na podstawie Autocorrelation i AMDF ---
        private float[] Autocorrelation(float[] frame)
        {
            int N = frame.Length;
            float[] R = new float[N];
            for (int l = 0; l < N; l++)
            {
                for (int i = 0; i < N - l; i++)
                    R[l] += frame[i] * frame[i + l];

                R[l] /= (N - l);
            }
            return R;
        }

        private float[] AMDF(float[] frame)
        {
            int N = frame.Length;
            float[] A = new float[N];
            for (int l = 0; l < N; l++)
            {
                for (int i = 0; i < N - l; i++)
                    A[l] += MathF.Abs(frame[i + l] - frame[i]);

                A[l] /= (N - l);
            }

            return A;
        }

        private float EstimateF0AutocorrelationForFrame(float[] frame, int sampleRate, float minF0, float maxF0)
        {
            int N = frame.Length;
            int lagMin = (int)(sampleRate / maxF0);
            int lagMax = (int)(sampleRate / minF0);

            lagMax = Math.Min(lagMax, N - 1);

            float[] R = Autocorrelation(frame);
            int bestLagR = lagMin;
            for (int l = lagMin + 1; l <= lagMax; l++)
                if (R[l] > R[bestLagR])
                    bestLagR = l;
            float f0_autocorrelation = sampleRate / (float)bestLagR;

            return f0_autocorrelation;
        }

        private float EstimateF0AMDFForFrame(float[] frame, int sampleRate, float minF0, float maxF0)
        {
            int N = frame.Length;
            int lagMin = (int)(sampleRate / maxF0);
            int lagMax = (int)(sampleRate / minF0);

            lagMax = Math.Min(lagMax, N - 1);

            float[] A = AMDF(frame);
            int bestLagA = lagMin;
            for (int l = lagMin + 1; l <= lagMax; l++)
                if (A[l] < A[bestLagA])
                    bestLagA = l;
            float f0_amdf = sampleRate / (float)bestLagA;

            return f0_amdf;
        }

        private float[] EstimateF0Autocorrelation(IReadOnlyList<float[]> frames, int sampleRate, float minF0, float maxF0)
        {
            int frameCount = frames.Count;
            float[] f0_autocorrelation_array = new float[frameCount];
            for (int i = 0; i < frameCount; i++)
                f0_autocorrelation_array[i] = EstimateF0AutocorrelationForFrame(frames[i], sampleRate, minF0, maxF0);
            return f0_autocorrelation_array;
        }

        private float[] EstimateF0AMDF(IReadOnlyList<float[]> frames, int sampleRate, float minF0, float maxF0)
        {
            int frameCount = frames.Count;
            float[] f0_AMDF_array = new float[frameCount];
            for (int i = 0; i < frameCount; i++)
                f0_AMDF_array[i] = EstimateF0AMDFForFrame(frames[i], sampleRate, minF0, maxF0);
            return f0_AMDF_array;
        }

        // --- Cechy na poziomie klipu ---
        private float CalculateVSTD(float[] volume)
        {
            float mean = volume.Average();
            float std = MathF.Sqrt(volume.Average(v => MathF.Pow(v - mean, 2)));
            float std_norm = std / (volume.Max() + 1e-10f);
            return std_norm;
        }

        private float CalculateVMEAN(float[] volume)
        {
            float mean = volume.Average();
            float mean_norm = mean / (volume.Max() + 1e-10f);
            return mean_norm;
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
            if (extrema.Count > 1)
                vu /= (extrema.Count - 1);

            return vu;
        }

        private float CalculateLSTER(float[] ste)
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

        private float CalculateEnergyEntropy(IReadOnlyList<float[]> frames, int K = 16)
        {
            int frameCount = frames.Count;
            int frameSize = frames[0].Length;

            float I = 0.0f;
            for (int i = 0; i < frameCount; i++)
            {
                float[] frame = frames[i];
                float totalEnergy = frame.Sum(sample => sample * sample) + 1e-10f;

                float frameEntropy = 0.0f;
                for (int j = 0; j < frameSize / K; j++)
                {
                    float segmentEnergy = 0.0f;
                    for (int k = 0; k < K; k++)
                        segmentEnergy += frame[j * K + k] * frame[j * K + k];

                    float normalizedEnergy = segmentEnergy / totalEnergy;
                    frameEntropy -= normalizedEnergy * MathF.Log2(normalizedEnergy + 1e-10f);
                }
                frameEntropy /= (frameSize / K);

                I += frameEntropy;
            }
            I /= frameCount;

            return I;
        }

        private float CalculateZSTD(float[] zcr)
        {
            float mean = zcr.Average();
            float std = MathF.Sqrt(zcr.Average(x => MathF.Pow(x - mean, 2)));
            return std;
        }

        private float CalculateHZCRR(float[] zcr)
        {
            int frameCount = zcr.Length;
            float avZCR = zcr.Average();

            float hzcrr = 0.0f;
            for (int i = 0; i < frameCount; i++)
            {
                hzcrr += Math.Sign(zcr[i] - 1.5 * avZCR) + 1;
            }
            hzcrr /= 2 * frameCount;

            return hzcrr;
        }
    }
}
