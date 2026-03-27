namespace AiPD1.Core
{
    internal class TimeParameters
    {
        public float[] Volume { get; private set; } = Array.Empty<float>();
        public float[] ShortTimeEnergy { get; private set; } = Array.Empty<float>();
        public float[] ZeroCrossingRate { get; private set; } = Array.Empty<float>();
        public float[] SilentRatio { get; private set; } = Array.Empty<float>();
        public float[] FundamentalFrequencyAutocorrelation { get; private set; } = Array.Empty<float>();
        public float[] FundamentalFrequencyAMDF { get; private set; } = Array.Empty<float>();

        public float VolumeSilenceThreshold { get; private set; } = 0.005f;
        //public float VolumeSilenceThreshold { get; private set; } = 0.003f;
        public float ZCRSilenceThreshold { get; private set; } = 0.001f;

        public int SampleRate { get; private set; } = 0;

        public TimeParameters(IReadOnlyList<float[]> frames, int sampleRate)
        {
            SampleRate = sampleRate;
            CalculateParameters(frames);
        }

        public void CalculateParameters(IReadOnlyList<float[]> frames)
        {
            Volume = CalculateVolume(frames);
            ShortTimeEnergy = CalculateShortTimeEnergy(frames);
            ZeroCrossingRate = CalculateZeroCrossingRate(frames);
            SilentRatio = CalculateSilentRatio(frames);
            FundamentalFrequencyAutocorrelation = CalculateFundamentalFrequencyAutocorrelation(frames);
            FundamentalFrequencyAMDF = CalculateFundamentalFrequencyAMDF(frames);
            return;
        }

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
                int sum = 0;
                for (int j = 1; j < frame.Length; j++)
                {
                    if (Math.Sign(frame[j]) != Math.Sign(frame[j - 1]))
                    {
                        sum++;
                    }
                }
                zceArray[i] = (float)sum / (frameCount);
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

        private float[] CalculateFundamentalFrequencyAutocorrelation(IReadOnlyList<float[]> frames)
        {
            int frameCount = frames.Count;

            int minLag = (int)(SampleRate / 500.0);
            int maxLag = (int)(SampleRate / 60.0);

            if (minLag < 1) minLag = 1;
            if (maxLag > frames[0].Length / 2) maxLag = frames[0].Length / 2;

            float[] ffArray = new float[frameCount];
            for (int i = 0; i < frameCount; i++)
            {
                float[] frame = frames[i];
                float maxCorrelation = float.MinValue;
                int bestLag = 0;
                for (int lag = minLag; lag <= maxLag; lag++)
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
                ffArray[i] = bestLag > 0 ? (float)SampleRate / bestLag : 0f;
            }

            return ffArray;
        }

        private float[] CalculateFundamentalFrequencyAMDF(IReadOnlyList<float[]> frames)
        {
            int frameCount = frames.Count;

            int minLag = (int)(SampleRate / 500.0);
            int maxLag = (int)(SampleRate / 60.0);

            if (minLag < 1) minLag = 1;
            if (maxLag > frames[0].Length / 2) maxLag = frames[0].Length / 2;

            float[] ffArray = new float[frameCount];
            for (int i = 0; i < frameCount; i++)
            {
                float[] frame = frames[i];
                float minAMDF = float.MaxValue;
                int bestLag = 0;
                for (int lag = minLag; lag <= maxLag; lag++)
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
                ffArray[i] = bestLag > 0 ? (float)SampleRate / bestLag : 0f;
            }

            return ffArray;
        }
    }
}
