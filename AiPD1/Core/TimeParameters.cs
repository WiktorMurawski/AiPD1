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

        public TimeParameters(IReadOnlyList<float[]> frames)
        {
            CalculateParameters(frames);
        }

        private void CalculateParameters(IReadOnlyList<float[]> frames)
        {
            Volume = CalculateVolume(frames);
            ShortTimeEnergy = CalculateShortTimeEnergy(frames);
            ZeroCrossingRate = CalculateZeroCrossingRate(frames);
            return;
            SilentRatio = CalculateSilentRatio(frames);
            FundamentalFrequencyAutocorrelation = CalculateFundamentalFrequencyAutocorrelation(frames);
            FundamentalFrequencyAMDF = CalculateFundamentalFrequencyAMDF(frames);
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
                zceArray[i] = (float)sum / (2 * frameCount);
            }

            return zceArray;
        }

        private float[] CalculateSilentRatio(IReadOnlyList<float[]> frames)
        {
            int frameCount = frames.Count;

            throw new NotImplementedException();
        }

        private float[] CalculateFundamentalFrequencyAMDF(IReadOnlyList<float[]> frames)
        {
            int frameCount = frames.Count;

            throw new NotImplementedException();
        }

        private float[] CalculateFundamentalFrequencyAutocorrelation(IReadOnlyList<float[]> frames)
        {
            int frameCount = frames.Count;

            throw new NotImplementedException();
        }
    }
}
