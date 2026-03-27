using AiPD1.Helpers;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace AiPD1.Core
{
    internal class AudioModel
    {
        public string FileName { get; private set; } = string.Empty;
        public float[] Samples { get; private set; } = Array.Empty<float>();
        public int SampleRate { get; private set; } = 0;
        public TimeSpan Duration { get; private set; } = TimeSpan.Zero;
        public int FrameSize { get; private set; } = 256;
        public List<float[]> Frames { get; private set; } = new List<float[]>();
        public int FrameCount => Frames.Count;
        public TimeParameters TimeParams { get; private set; }

        public AudioModel(string filePath)
        {
            LoadWAVFile(filePath);
            DivideIntoFrames();
            TimeParams = new TimeParameters(Frames);
        }

        private void LoadWAVFile(string filePath)
        {
            using var reader = new AudioFileReader(filePath);

            ISampleProvider monoProvider = reader.WaveFormat.Channels switch
            {
                1 => reader,
                2 => new StereoToMonoSampleProvider(reader),
                _ => throw new NotSupportedException($"Nieobsługiwana liczba kanałów: {reader.WaveFormat.Channels}. Obsługiwane tylko mono lub stereo.")
            };

            SampleRate = monoProvider.WaveFormat.SampleRate;
            Duration = reader.TotalTime;
            FileName = Path.GetFileName(filePath);

            int totalSamples = (int)(reader.Length / reader.WaveFormat.Channels / sizeof(float));
            int padding = FrameSize - totalSamples % FrameSize;
            Samples = new float[totalSamples + padding];

            int samplesRead = monoProvider.Read(Samples, 0, totalSamples);

            if (samplesRead < totalSamples)
            {
                throw new Exception("Przeczytano " + samplesRead + " próbek, oczekiwano " + totalSamples);
            }

            Logger.WriteLine($"Załadowano {Samples.Length} próbek mono | {SampleRate} Hz | {Duration.TotalSeconds:F2} s");
        }

        private void DivideIntoFrames()
        {
            if (Samples == null || Samples.Length == 0)
                return;

            var frames = new List<float[]>();

            for (int i = 0; i < Samples.Length; i += FrameSize)
            {
                float[] frame = new float[FrameSize];
                int samplesToCopy = Math.Min(FrameSize, Samples.Length - i);
                Array.Copy(Samples, i, frame, 0, samplesToCopy);
                frames.Add(frame);
            }

            Frames = frames;
        }
    }
}
