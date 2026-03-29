using AiPD1.Core;
using AiPD1.Helpers;
using ScottPlot;
using ScottPlot.WinForms;

namespace AiPD1
{
    public partial class MainWindow : Form
    {
        private const string WINDOW_NAME = "AiPD Projekt 1";
        AudioModel? CurrentAudioModel { get; set; } = null;
        private int DefaultFrameSize { get; set; } = 256;
        List<(FormsPlot, string)> Plots = new List<(FormsPlot, string)>();

        public MainWindow()
        {
            InitializeComponent();

            SetupComboBoxes();

            SetupPlots();
        }

        private void SetupComboBoxes()
        {
            FrameSize_ComboBox.Items.Clear();
            FrameSize_ComboBox.Items.AddRange(new object[] { 128, 256, 512, 1024 });
            //FrameSize_ComboBox.Items.AddRange(new string[] { "128", "256", "512", "1024", "2048" });
            FrameSize_ComboBox.SelectedIndex = 1;
        }

        private void SetupPlots()
        {
            Plots.Add((WavePlot, "Fala dźwiękowa"));
            Plots.Add((VolumePlot, "Głośność"));
            Plots.Add((STEPlot, "STE"));
            Plots.Add((ZCRPlot, "ZCR"));
            Plots.Add((SRPlot, "SR"));
            Plots.Add((FFAutocorrelationPlot, "FF Autocorrelation"));
            Plots.Add((FFAMDFPlot, "FF AMDF"));

            LinkAllPlotsBidirectionally();

            foreach (var (plot, title) in Plots)
            {
                plot.Width = MainSplitContainer.Panel1.Width - 20;
                plot.Plot.Title(title);
                plot.Plot.Axes.SetLimitsX(0.00, 1.00);
                plot.Plot.Axes.SetLimitsY(-1.00, 1.00);
                plot.Plot.Layout.Fixed(new ScottPlot.PixelPadding(
                    left: 40,
                    right: 5,
                    bottom: 40,
                    top: 40
                ));
                plot.Refresh();
            }

            foreach (var (plot, _) in Plots)
            {
                plot.MouseWheel += (sender, e) =>
                {
                    ((HandledMouseEventArgs)e).Handled = true;
                };
            }
        }

        private void LinkAllPlotsBidirectionally()
        {
            for (int i = 0; i < Plots.Count; i++)
            {
                for (int j = 0; j < Plots.Count; j++)
                {
                    if (i == j) continue;
                    Plots[i].Item1.Plot.Axes.Link(Plots[j].Item1.Plot, x: true, y: false);
                }
            }
        }

        private void AutoScalePlots()
        {
            foreach ((var plot, _) in Plots)
            {
                plot.Plot.Axes.SetLimitsX(0.00, 1.00);
                plot.Plot.Axes.SetLimitsY(-1.00, 1.00);
                plot.Plot.Axes.AutoScale();
                plot.Refresh();
            }
        }

        private void Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zresetujWykresyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoScalePlots();
        }

        private void LoadAudioFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Pliki audio (*.wav)|*.wav|Wszystkie pliki (*.*)|*.*",
                Title = "Wybierz plik audio",
                InitialDirectory = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\..\..\..\")),
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                CurrentAudioModel = new AudioModel(filePath, DefaultFrameSize);
                Logger.WriteLine($"Wybrano plik: {filePath}");

                this.Text = WINDOW_NAME + " - " + CurrentAudioModel.FileName;

                DisplayCalculatedParams();
            }
        }

        private void DisplayCalculatedParams()
        {
            PlotSignals();
            DisplayClipLevelValues();
        }

        private void PlotSignals()
        {
            if (CurrentAudioModel == null)
                throw new InvalidDataException("Nie można wyświetlić sygnałów, ponieważ CurrentAudioModel jest null.");
            DisplayAudioWaveOnPlot();
            DisplayTimeParamsSignalOnPlot(VolumePlot, CurrentAudioModel.TimeParams.Volume, Colors.Red);
            DisplayTimeParamsSignalOnPlot(STEPlot, CurrentAudioModel.TimeParams.ShortTimeEnergy, Colors.DarkRed);
            DisplayTimeParamsSignalOnPlot(ZCRPlot, CurrentAudioModel.TimeParams.ZeroCrossingRate, Colors.Green);
            DisplayTimeParamsSignalOnPlot(SRPlot, CurrentAudioModel.TimeParams.SilentRatio, Colors.Green);
            DisplayTimeParamsSignalOnPlot(FFAutocorrelationPlot, CurrentAudioModel.TimeParams.FundamentalFrequencyAutocorrelation, Colors.Green);
            DisplayTimeParamsSignalOnPlot(FFAMDFPlot, CurrentAudioModel.TimeParams.FundamentalFrequencyAMDF, Colors.Green);
        }

        private void DisplayClipLevelValues()
        {
            if (CurrentAudioModel == null)
                throw new InvalidDataException("Nie można wyświetlić wartości, ponieważ CurrentAudioModel jest null.");

            VSTDValue_Label.Text = $"{CurrentAudioModel.TimeParams.VSTD:F4}";
            VMEANValue_Label.Text = $"{CurrentAudioModel.TimeParams.VMEAN:F4}";
            VDRValue_Label.Text = $"{CurrentAudioModel.TimeParams.VDR:F4}";
            VUValue_Label.Text = $"{CurrentAudioModel.TimeParams.VU:F4}";

            LSTERValue_Label.Text = $"{CurrentAudioModel.TimeParams.LSTER:F4}";
            EnergyEntropyValue_Label.Text = $"{CurrentAudioModel.TimeParams.EnergyEntropy:F4}";

            ZSTDValue_Label.Text = $"{CurrentAudioModel.TimeParams.ZSTD:F4}";
            HZCRRValue_Label.Text = $"{CurrentAudioModel.TimeParams.HZCRR:F4}";
        }

        private void DisplayAudioWaveOnPlot()
        {
            if (CurrentAudioModel?.Samples == null || CurrentAudioModel.Samples.Length == 0)
                return;

            WavePlot.Plot.Clear();

            double step = 1.0 / CurrentAudioModel.SampleRate;

            var signal = WavePlot.Plot.Add.Signal(
                CurrentAudioModel.Samples,
                step);

            signal.Color = Colors.Blue;
            signal.LineWidth = 1.0f;

            //WavePlot.Plot.Title($"{CurrentAudioModel.FileName}");
            //WavePlot.Plot.XLabel("Czas (sekundy)");
            //WavePlot.Plot.YLabel("Amplituda");

            WavePlot.Plot.Axes.SetLimitsY(-1.00, 1.00);
            WavePlot.Plot.Axes.SetLimitsX(0, CurrentAudioModel.Duration.TotalSeconds);

            WavePlot.Refresh();
        }

        private void DisplayTimeParamsSignalOnPlot(FormsPlot plot, float[] paramSignal, ScottPlot.Color color)
        {
            if (CurrentAudioModel?.TimeParams == null || paramSignal.Length == 0)
                return;

            plot.Plot.Clear();

            double step = (double)CurrentAudioModel.FrameSize / CurrentAudioModel.SampleRate;
            var timeParams = CurrentAudioModel.TimeParams;
            var signal = plot.Plot.Add.Signal(
                paramSignal,
                step);

            signal.Data.XOffset = step / 2;

            signal.Color = color;
            signal.LineWidth = 1.0f;

            plot.Plot.Axes.AutoScaleY();
            plot.Plot.Axes.SetLimitsX(0, CurrentAudioModel.Duration.TotalSeconds);
            plot.Refresh();
        }

        private void FrameSize_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedItem is null) return;
            int selectedValue = (int)cb.SelectedItem;
            DefaultFrameSize = selectedValue;

            if (CurrentAudioModel is null) return;
            CurrentAudioModel.FrameSize = selectedValue;
            CurrentAudioModel.FrameSizeChanged();

            DisplayCalculatedParams();
        }
    }
}
