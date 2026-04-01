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
        List<(FormsPlot, string)> Plots = new List<(FormsPlot, string)>();
        private bool _showSilenceHighlighting { get; set; } = true;
        private bool _showVoicedHighlighting { get; set; } = false;

        public MainWindow()
        {
            InitializeComponent();

            SetupComboBoxes();
            SetupPlots();
            SetupNumericUpDowns();
        }

        private void SetupNumericUpDowns()
        {
            VolumeThreshold_NumericUpDown.Minimum = 0;
            VolumeThreshold_NumericUpDown.Maximum = 1;
            VolumeThreshold_NumericUpDown.DecimalPlaces = 4;
            VolumeThreshold_NumericUpDown.Increment = 0.0001M;
            VolumeThreshold_NumericUpDown.Value = (decimal)TimeParameters.VolumeSilenceThreshold;
            ZCRThreshold_NumericUpDown.Minimum = 0;
            ZCRThreshold_NumericUpDown.Maximum = 1;
            ZCRThreshold_NumericUpDown.DecimalPlaces = 4;
            ZCRThreshold_NumericUpDown.Increment = 0.0001M;
            ZCRThreshold_NumericUpDown.Value = (decimal)TimeParameters.ZCRVoicedThreshold;
            MinF0_NumericUpDown.Minimum = 1;
            MinF0_NumericUpDown.Maximum = 2000;
            MinF0_NumericUpDown.DecimalPlaces = 0;
            MinF0_NumericUpDown.Increment = 1;
            MinF0_NumericUpDown.Value = (decimal)TimeParameters.MinF0;
            MaxF0_NumericUpDown.Minimum = 1;
            MaxF0_NumericUpDown.Maximum = 4000;
            MaxF0_NumericUpDown.DecimalPlaces = 0;
            MaxF0_NumericUpDown.Increment = 1;
            MaxF0_NumericUpDown.Value = (decimal)TimeParameters.MaxF0;
        }

        private void SetupComboBoxes()
        {
            FrameSize_ComboBox.Items.Clear();
            FrameSize_ComboBox.Items.AddRange(new object[] { 128, 256, 512, 1024 });
            //FrameSize_ComboBox.Items.AddRange(new string[] { "128", "256", "512", "1024", "2048" });
            FrameSize_ComboBox.SelectedIndex = 1;
            AudioModel.FrameSize = (int)FrameSize_ComboBox.SelectedItem!;
        }

        private void SetupPlots()
        {
            Plots.Add((WavePlot, "Fala dźwiękowa"));
            Plots.Add((VolumePlot, "Głośność"));
            Plots.Add((STEPlot, "Short Time Energy"));
            Plots.Add((ZCRPlot, "Zero Crossing Rate"));
            Plots.Add((SRPlot, "Cisza"));
            Plots.Add((VoicedRatioPlot, "Dźwięczność"));
            Plots.Add((FFAutocorrelationPlot, "FF Autokorelacja"));
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

                Cursor = Cursors.WaitCursor;
                CurrentAudioModel = new AudioModel(filePath);
                Cursor = Cursors.Default;

                this.Text = WINDOW_NAME + " - " + CurrentAudioModel.FileName;

                DisplayCalculatedParams();
            }
        }

        private void DisplayCalculatedParams()
        {
            if (CurrentAudioModel == null) return;

            PlotSignals();
            DisplayClipLevelValues();
        }

        private void PlotSignals()
        {
            if (CurrentAudioModel == null) return;

            DisplayAudioWaveOnPlot();
            DisplayTimeParamsSignalOnPlot(VolumePlot, CurrentAudioModel.TimeParams.Volume, Colors.Red);
            DisplayTimeParamsSignalOnPlot(STEPlot, CurrentAudioModel.TimeParams.ShortTimeEnergy, Colors.DarkRed);
            DisplayTimeParamsSignalOnPlot(ZCRPlot, CurrentAudioModel.TimeParams.ZeroCrossingRate, Colors.Blue);
            DisplayTimeParamsSignalOnPlot(SRPlot, CurrentAudioModel.TimeParams.SilentRatio, Colors.DarkCyan);
            DisplayTimeParamsSignalOnPlot(VoicedRatioPlot, CurrentAudioModel.TimeParams.VoicedRatio, Colors.Purple);
            DisplayTimeParamsSignalOnPlot(FFAutocorrelationPlot, CurrentAudioModel.TimeParams.FundamentalFrequencyAutocorrelation, Colors.Green);
            DisplayTimeParamsSignalOnPlot(FFAMDFPlot, CurrentAudioModel.TimeParams.FundamentalFrequencyAMDF, Colors.Green);
            if (_showSilenceHighlighting)
                MarkSilentFramesOnWavePlot(WavePlot);
            if (_showVoicedHighlighting)
                MarkVoicedFramesOnWavePlot(WavePlot);
        }

        private void DisplayClipLevelValues()
        {
            if (CurrentAudioModel == null) return;

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

            double step = (double)AudioModel.FrameSize / CurrentAudioModel.SampleRate;
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

        private void MarkSilentFramesOnWavePlot(FormsPlot plot)
        {
            if (CurrentAudioModel == null) return;

            var silentFrames = CurrentAudioModel.TimeParams.SilentRatio.Select(x => x > 0.5).ToArray();

            for (int i = 0; i < silentFrames?.Length; i++)
            {
                if (silentFrames[i])
                {
                    double frameStart = (double)(i * AudioModel.FrameSize) / CurrentAudioModel.SampleRate;
                    double frameEnd = (double)((i + 1) * AudioModel.FrameSize) / CurrentAudioModel.SampleRate;
                    var span = plot.Plot.Add.HorizontalSpan(frameStart, frameEnd);
                    span.FillColor = ScottPlot.Colors.Yellow.WithAlpha(0.3);
                }
            }

            plot.Refresh();
        }

        private void MarkVoicedFramesOnWavePlot(FormsPlot plot)
        {
            if (CurrentAudioModel == null) return;
            var voicedFrames = CurrentAudioModel.TimeParams.VoicedRatio.Select(x => x > 0.5).ToArray();
            for (int i = 0; i < voicedFrames?.Length; i++)
            {
                if (voicedFrames[i])
                {
                    double frameStart = (double)(i * AudioModel.FrameSize) / CurrentAudioModel.SampleRate;
                    double frameEnd = (double)((i + 1) * AudioModel.FrameSize) / CurrentAudioModel.SampleRate;
                    var span = plot.Plot.Add.HorizontalSpan(frameStart, frameEnd);
                    span.FillColor = ScottPlot.Colors.Green.WithAlpha(0.3);
                }
            }
            plot.Refresh();
        }

        private void FrameSize_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedItem is null) return;
            int selectedValue = (int)cb.SelectedItem;

            if (CurrentAudioModel is null) return;
            AudioModel.FrameSize = selectedValue;
            Cursor = Cursors.WaitCursor;
            CurrentAudioModel.FrameSizeChanged();
            Cursor = Cursors.Default;

            DisplayCalculatedParams();
        }

        private void VolumeThreshold_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            TimeParameters.VolumeSilenceThreshold = (float)VolumeThreshold_NumericUpDown.Value;
            CurrentAudioModel?.TimeParams.UpdateSilentRatio(CurrentAudioModel.Frames);
            CurrentAudioModel?.TimeParams.UpdateVoicedRatio(CurrentAudioModel.Frames);
            DisplayCalculatedParams();
        }

        private void ZCRThreshold_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            TimeParameters.ZCRVoicedThreshold = (float)ZCRThreshold_NumericUpDown.Value;
            CurrentAudioModel?.TimeParams.UpdateVoicedRatio(CurrentAudioModel.Frames);
            DisplayCalculatedParams();
        }

        private void MinF0_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            TimeParameters.MinF0 = (float)MinF0_NumericUpDown.Value;
            CurrentAudioModel?.TimeParams.UpdateFundamentalFrequencies(CurrentAudioModel.Frames, CurrentAudioModel.SampleRate);
            DisplayCalculatedParams();
        }

        private void MaxF0_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            TimeParameters.MaxF0 = (float)MaxF0_NumericUpDown.Value;
            CurrentAudioModel?.TimeParams.UpdateFundamentalFrequencies(CurrentAudioModel.Frames, CurrentAudioModel.SampleRate);
            DisplayCalculatedParams();
        }

        private void SilenceHighlighting_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _showSilenceHighlighting = SilenceHighlighting_CheckBox.Checked;
            PlotSignals();
        }

        private void VoicedHighlighting_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _showVoicedHighlighting = VoicedHighlighting_CheckBox.Checked;
            PlotSignals();
        }

        private void ExportCechFrameLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentAudioModel == null)
            {
                MessageBox.Show("Nie załadowano żadnego pliku audio.",
                                "Brak danych",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            using var dialog = new SaveFileDialog
            {
                Title = "Eksport parametrów audio do CSV",
                Filter = "Plik CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*",
                DefaultExt = "csv",
                FileName = Path.GetFileNameWithoutExtension(CurrentAudioModel.FileName ?? "audio") + "_parameters",
                AddExtension = true,
                OverwritePrompt = true
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                string filePath = dialog.FileName;

                Exporter.ExportFrameLevelTimeParametersToCsv(filePath, CurrentAudioModel.TimeParams, CurrentAudioModel.SampleRate);

                MessageBox.Show("Dane zostały pomyślnie wyeksportowane do pliku CSV.",
                                "Eksport zakończony sukcesem",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas eksportu:\n{ex.Message}",
                                "Błąd eksportu",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void exportCechClipLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentAudioModel == null)
            {
                MessageBox.Show("Nie załadowano żadnego pliku audio.",
                                "Brak danych",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            using var dialog = new SaveFileDialog
            {
                Title = "Eksport parametrów audio do CSV",
                Filter = "Plik CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*",
                DefaultExt = "csv",
                FileName = Path.GetFileNameWithoutExtension(CurrentAudioModel.FileName ?? "audio") + "_parameters",
                AddExtension = true,
                OverwritePrompt = true
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                string filePath = dialog.FileName;

                Exporter.ExportClipLevelTimeParameters(filePath, CurrentAudioModel.TimeParams);

                MessageBox.Show("Dane zostały pomyślnie wyeksportowane do pliku CSV.",
                                "Eksport zakończony sukcesem",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas eksportu:\n{ex.Message}",
                                "Błąd eksportu",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
