namespace AiPD1
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainMenu_MenuStrip = new MenuStrip();
            plikToolStripMenuItem = new ToolStripMenuItem();
            LoadAudioFile_ToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            exportCechFrameLevelToolStripMenuItem = new ToolStripMenuItem();
            exportCechClipLevelToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            Exit_ToolStripMenuItem = new ToolStripMenuItem();
            widokToolStripMenuItem = new ToolStripMenuItem();
            zresetujWykresyToolStripMenuItem = new ToolStripMenuItem();
            MainSplitContainer = new SplitContainer();
            FFAMDFPlot = new ScottPlot.WinForms.FormsPlot();
            FFAutocorrelationPlot = new ScottPlot.WinForms.FormsPlot();
            SRPlot = new ScottPlot.WinForms.FormsPlot();
            ZCRPlot = new ScottPlot.WinForms.FormsPlot();
            STEPlot = new ScottPlot.WinForms.FormsPlot();
            VolumePlot = new ScottPlot.WinForms.FormsPlot();
            WavePlot = new ScottPlot.WinForms.FormsPlot();
            groupBox3 = new GroupBox();
            VSTDValue_Label = new Label();
            HZCRRValue_Label = new Label();
            VSTD_Label = new Label();
            HZCRR_Label = new Label();
            VMEAN_Label = new Label();
            ZSTDValue_Label = new Label();
            VMEANValue_Label = new Label();
            ZSTD_Label = new Label();
            VDR_Label = new Label();
            EnergyEntropyValue_Label = new Label();
            VDRValue_Label = new Label();
            EnergyEntropy_Label = new Label();
            VU_Label = new Label();
            LSTERValue_Label = new Label();
            VUValue_Label = new Label();
            LSTER_Label = new Label();
            groupBox2 = new GroupBox();
            MinF0_Label = new Label();
            MaxF0_Label = new Label();
            MinF0_NumericUpDown = new NumericUpDown();
            MaxF0_NumericUpDown = new NumericUpDown();
            groupBox1 = new GroupBox();
            VolumeSilenceThreshold_Label = new Label();
            SilenceHighlighting_CheckBox = new CheckBox();
            VolumeThreshold_NumericUpDown = new NumericUpDown();
            ZCRSilenceThreshold_Label = new Label();
            ZCRThreshold_NumericUpDown = new NumericUpDown();
            FrameSize_Label = new Label();
            FrameSize_ComboBox = new ComboBox();
            MainMenu_MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).BeginInit();
            MainSplitContainer.Panel1.SuspendLayout();
            MainSplitContainer.Panel2.SuspendLayout();
            MainSplitContainer.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MinF0_NumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxF0_NumericUpDown).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VolumeThreshold_NumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ZCRThreshold_NumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // MainMenu_MenuStrip
            // 
            MainMenu_MenuStrip.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem, widokToolStripMenuItem });
            MainMenu_MenuStrip.Location = new Point(0, 0);
            MainMenu_MenuStrip.Name = "MainMenu_MenuStrip";
            MainMenu_MenuStrip.Size = new Size(884, 24);
            MainMenu_MenuStrip.TabIndex = 0;
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { LoadAudioFile_ToolStripMenuItem, exportToolStripMenuItem, toolStripMenuItem1, Exit_ToolStripMenuItem });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(38, 20);
            plikToolStripMenuItem.Text = "Plik";
            // 
            // LoadAudioFile_ToolStripMenuItem
            // 
            LoadAudioFile_ToolStripMenuItem.Name = "LoadAudioFile_ToolStripMenuItem";
            LoadAudioFile_ToolStripMenuItem.Size = new Size(170, 22);
            LoadAudioFile_ToolStripMenuItem.Text = "Wczytaj plik audio";
            LoadAudioFile_ToolStripMenuItem.Click += LoadAudioFile_ToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportCechFrameLevelToolStripMenuItem, exportCechClipLevelToolStripMenuItem });
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(170, 22);
            exportToolStripMenuItem.Text = "Export";
            // 
            // exportCechFrameLevelToolStripMenuItem
            // 
            exportCechFrameLevelToolStripMenuItem.Name = "exportCechFrameLevelToolStripMenuItem";
            exportCechFrameLevelToolStripMenuItem.Size = new Size(204, 22);
            exportCechFrameLevelToolStripMenuItem.Text = "Export cech Frame-Level";
            exportCechFrameLevelToolStripMenuItem.Click += ExportCechFrameLevelToolStripMenuItem_Click;
            // 
            // exportCechClipLevelToolStripMenuItem
            // 
            exportCechClipLevelToolStripMenuItem.Name = "exportCechClipLevelToolStripMenuItem";
            exportCechClipLevelToolStripMenuItem.Size = new Size(204, 22);
            exportCechClipLevelToolStripMenuItem.Text = "Export cech Clip-Level";
            exportCechClipLevelToolStripMenuItem.Click += exportCechClipLevelToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(167, 6);
            // 
            // Exit_ToolStripMenuItem
            // 
            Exit_ToolStripMenuItem.Name = "Exit_ToolStripMenuItem";
            Exit_ToolStripMenuItem.Size = new Size(170, 22);
            Exit_ToolStripMenuItem.Text = "Exit";
            Exit_ToolStripMenuItem.Click += Exit_ToolStripMenuItem_Click;
            // 
            // widokToolStripMenuItem
            // 
            widokToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zresetujWykresyToolStripMenuItem });
            widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            widokToolStripMenuItem.Size = new Size(53, 20);
            widokToolStripMenuItem.Text = "Widok";
            // 
            // zresetujWykresyToolStripMenuItem
            // 
            zresetujWykresyToolStripMenuItem.Name = "zresetujWykresyToolStripMenuItem";
            zresetujWykresyToolStripMenuItem.Size = new Size(161, 22);
            zresetujWykresyToolStripMenuItem.Text = "Zresetuj wykresy";
            zresetujWykresyToolStripMenuItem.Click += zresetujWykresyToolStripMenuItem_Click;
            // 
            // MainSplitContainer
            // 
            MainSplitContainer.Dock = DockStyle.Fill;
            MainSplitContainer.Location = new Point(0, 24);
            MainSplitContainer.Margin = new Padding(0);
            MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            MainSplitContainer.Panel1.AutoScroll = true;
            MainSplitContainer.Panel1.AutoScrollMinSize = new Size(20, 0);
            MainSplitContainer.Panel1.BackColor = Color.White;
            MainSplitContainer.Panel1.Controls.Add(FFAMDFPlot);
            MainSplitContainer.Panel1.Controls.Add(FFAutocorrelationPlot);
            MainSplitContainer.Panel1.Controls.Add(SRPlot);
            MainSplitContainer.Panel1.Controls.Add(ZCRPlot);
            MainSplitContainer.Panel1.Controls.Add(STEPlot);
            MainSplitContainer.Panel1.Controls.Add(VolumePlot);
            MainSplitContainer.Panel1.Controls.Add(WavePlot);
            // 
            // MainSplitContainer.Panel2
            // 
            MainSplitContainer.Panel2.BackColor = SystemColors.Control;
            MainSplitContainer.Panel2.Controls.Add(groupBox3);
            MainSplitContainer.Panel2.Controls.Add(groupBox2);
            MainSplitContainer.Panel2.Controls.Add(groupBox1);
            MainSplitContainer.Panel2.Controls.Add(ZCRSilenceThreshold_Label);
            MainSplitContainer.Panel2.Controls.Add(FrameSize_Label);
            MainSplitContainer.Panel2.Controls.Add(ZCRThreshold_NumericUpDown);
            MainSplitContainer.Panel2.Controls.Add(FrameSize_ComboBox);
            MainSplitContainer.Panel2.RightToLeft = RightToLeft.No;
            MainSplitContainer.RightToLeft = RightToLeft.No;
            MainSplitContainer.Size = new Size(884, 588);
            MainSplitContainer.SplitterDistance = 650;
            MainSplitContainer.TabIndex = 1;
            // 
            // FFAMDFPlot
            // 
            FFAMDFPlot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FFAMDFPlot.BackColor = Color.White;
            FFAMDFPlot.DisplayScale = 1F;
            FFAMDFPlot.Location = new Point(0, 1203);
            FFAMDFPlot.Margin = new Padding(3, 0, 3, 0);
            FFAMDFPlot.Name = "FFAMDFPlot";
            FFAMDFPlot.Size = new Size(607, 200);
            FFAMDFPlot.TabIndex = 6;
            // 
            // FFAutocorrelationPlot
            // 
            FFAutocorrelationPlot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FFAutocorrelationPlot.BackColor = Color.White;
            FFAutocorrelationPlot.DisplayScale = 1F;
            FFAutocorrelationPlot.Location = new Point(0, 1003);
            FFAutocorrelationPlot.Margin = new Padding(3, 0, 3, 0);
            FFAutocorrelationPlot.Name = "FFAutocorrelationPlot";
            FFAutocorrelationPlot.Size = new Size(607, 200);
            FFAutocorrelationPlot.TabIndex = 5;
            // 
            // SRPlot
            // 
            SRPlot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SRPlot.BackColor = Color.White;
            SRPlot.DisplayScale = 1F;
            SRPlot.Location = new Point(3, 803);
            SRPlot.Margin = new Padding(3, 0, 3, 0);
            SRPlot.Name = "SRPlot";
            SRPlot.Size = new Size(604, 200);
            SRPlot.TabIndex = 4;
            // 
            // ZCRPlot
            // 
            ZCRPlot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ZCRPlot.BackColor = Color.White;
            ZCRPlot.DisplayScale = 1F;
            ZCRPlot.Location = new Point(3, 603);
            ZCRPlot.Margin = new Padding(3, 0, 3, 0);
            ZCRPlot.Name = "ZCRPlot";
            ZCRPlot.Size = new Size(604, 200);
            ZCRPlot.TabIndex = 3;
            // 
            // STEPlot
            // 
            STEPlot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            STEPlot.BackColor = Color.White;
            STEPlot.DisplayScale = 1F;
            STEPlot.Location = new Point(3, 403);
            STEPlot.Margin = new Padding(3, 0, 3, 0);
            STEPlot.Name = "STEPlot";
            STEPlot.Size = new Size(604, 200);
            STEPlot.TabIndex = 2;
            // 
            // VolumePlot
            // 
            VolumePlot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            VolumePlot.BackColor = Color.White;
            VolumePlot.DisplayScale = 1F;
            VolumePlot.Location = new Point(3, 203);
            VolumePlot.Margin = new Padding(3, 0, 3, 0);
            VolumePlot.Name = "VolumePlot";
            VolumePlot.Size = new Size(604, 200);
            VolumePlot.TabIndex = 1;
            // 
            // WavePlot
            // 
            WavePlot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            WavePlot.BackColor = Color.White;
            WavePlot.DisplayScale = 1F;
            WavePlot.Location = new Point(3, 3);
            WavePlot.Margin = new Padding(3, 3, 3, 0);
            WavePlot.Name = "WavePlot";
            WavePlot.Size = new Size(604, 200);
            WavePlot.TabIndex = 0;
            WavePlot.Tag = "";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(VSTDValue_Label);
            groupBox3.Controls.Add(HZCRRValue_Label);
            groupBox3.Controls.Add(VSTD_Label);
            groupBox3.Controls.Add(HZCRR_Label);
            groupBox3.Controls.Add(VMEAN_Label);
            groupBox3.Controls.Add(ZSTDValue_Label);
            groupBox3.Controls.Add(VMEANValue_Label);
            groupBox3.Controls.Add(ZSTD_Label);
            groupBox3.Controls.Add(VDR_Label);
            groupBox3.Controls.Add(EnergyEntropyValue_Label);
            groupBox3.Controls.Add(VDRValue_Label);
            groupBox3.Controls.Add(EnergyEntropy_Label);
            groupBox3.Controls.Add(VU_Label);
            groupBox3.Controls.Add(LSTERValue_Label);
            groupBox3.Controls.Add(VUValue_Label);
            groupBox3.Controls.Add(LSTER_Label);
            groupBox3.Location = new Point(3, 383);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(224, 202);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cechy na poziomie klipu";
            // 
            // VSTDValue_Label
            // 
            VSTDValue_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            VSTDValue_Label.Location = new Point(158, 19);
            VSTDValue_Label.Name = "VSTDValue_Label";
            VSTDValue_Label.Size = new Size(60, 15);
            VSTDValue_Label.TabIndex = 2;
            VSTDValue_Label.Text = "0.0000";
            VSTDValue_Label.TextAlign = ContentAlignment.TopRight;
            // 
            // HZCRRValue_Label
            // 
            HZCRRValue_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            HZCRRValue_Label.Location = new Point(158, 142);
            HZCRRValue_Label.Name = "HZCRRValue_Label";
            HZCRRValue_Label.Size = new Size(60, 15);
            HZCRRValue_Label.TabIndex = 15;
            HZCRRValue_Label.Text = "0.0000";
            HZCRRValue_Label.TextAlign = ContentAlignment.TopRight;
            // 
            // VSTD_Label
            // 
            VSTD_Label.AutoSize = true;
            VSTD_Label.Location = new Point(6, 19);
            VSTD_Label.Name = "VSTD_Label";
            VSTD_Label.Size = new Size(34, 15);
            VSTD_Label.TabIndex = 0;
            VSTD_Label.Text = "VSTD";
            // 
            // HZCRR_Label
            // 
            HZCRR_Label.AutoSize = true;
            HZCRR_Label.Location = new Point(6, 142);
            HZCRR_Label.Name = "HZCRR_Label";
            HZCRR_Label.Size = new Size(45, 15);
            HZCRR_Label.TabIndex = 14;
            HZCRR_Label.Text = "HZCRR";
            // 
            // VMEAN_Label
            // 
            VMEAN_Label.AutoSize = true;
            VMEAN_Label.Location = new Point(6, 34);
            VMEAN_Label.Name = "VMEAN_Label";
            VMEAN_Label.Size = new Size(48, 15);
            VMEAN_Label.TabIndex = 1;
            VMEAN_Label.Text = "VMEAN";
            // 
            // ZSTDValue_Label
            // 
            ZSTDValue_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ZSTDValue_Label.Location = new Point(158, 127);
            ZSTDValue_Label.Name = "ZSTDValue_Label";
            ZSTDValue_Label.Size = new Size(60, 15);
            ZSTDValue_Label.TabIndex = 13;
            ZSTDValue_Label.Text = "0.0000";
            ZSTDValue_Label.TextAlign = ContentAlignment.TopRight;
            // 
            // VMEANValue_Label
            // 
            VMEANValue_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            VMEANValue_Label.Location = new Point(158, 34);
            VMEANValue_Label.Name = "VMEANValue_Label";
            VMEANValue_Label.Size = new Size(60, 15);
            VMEANValue_Label.TabIndex = 3;
            VMEANValue_Label.Text = "0.0000";
            VMEANValue_Label.TextAlign = ContentAlignment.TopRight;
            // 
            // ZSTD_Label
            // 
            ZSTD_Label.AutoSize = true;
            ZSTD_Label.Location = new Point(6, 127);
            ZSTD_Label.Name = "ZSTD_Label";
            ZSTD_Label.Size = new Size(34, 15);
            ZSTD_Label.TabIndex = 12;
            ZSTD_Label.Text = "ZSTD";
            // 
            // VDR_Label
            // 
            VDR_Label.AutoSize = true;
            VDR_Label.Location = new Point(6, 49);
            VDR_Label.Name = "VDR_Label";
            VDR_Label.Size = new Size(29, 15);
            VDR_Label.TabIndex = 4;
            VDR_Label.Text = "VDR";
            // 
            // EnergyEntropyValue_Label
            // 
            EnergyEntropyValue_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EnergyEntropyValue_Label.Location = new Point(158, 103);
            EnergyEntropyValue_Label.Name = "EnergyEntropyValue_Label";
            EnergyEntropyValue_Label.Size = new Size(60, 15);
            EnergyEntropyValue_Label.TabIndex = 11;
            EnergyEntropyValue_Label.Text = "0.0000";
            EnergyEntropyValue_Label.TextAlign = ContentAlignment.TopRight;
            // 
            // VDRValue_Label
            // 
            VDRValue_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            VDRValue_Label.Location = new Point(158, 49);
            VDRValue_Label.Name = "VDRValue_Label";
            VDRValue_Label.Size = new Size(60, 15);
            VDRValue_Label.TabIndex = 5;
            VDRValue_Label.Text = "0.0000";
            VDRValue_Label.TextAlign = ContentAlignment.TopRight;
            // 
            // EnergyEntropy_Label
            // 
            EnergyEntropy_Label.AutoSize = true;
            EnergyEntropy_Label.Location = new Point(6, 103);
            EnergyEntropy_Label.Name = "EnergyEntropy_Label";
            EnergyEntropy_Label.Size = new Size(87, 15);
            EnergyEntropy_Label.TabIndex = 10;
            EnergyEntropy_Label.Text = "Energy Entropy";
            // 
            // VU_Label
            // 
            VU_Label.AutoSize = true;
            VU_Label.Location = new Point(6, 64);
            VU_Label.Name = "VU_Label";
            VU_Label.Size = new Size(22, 15);
            VU_Label.TabIndex = 6;
            VU_Label.Text = "VU";
            // 
            // LSTERValue_Label
            // 
            LSTERValue_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LSTERValue_Label.Location = new Point(158, 88);
            LSTERValue_Label.Name = "LSTERValue_Label";
            LSTERValue_Label.Size = new Size(60, 15);
            LSTERValue_Label.TabIndex = 9;
            LSTERValue_Label.Text = "0.0000";
            LSTERValue_Label.TextAlign = ContentAlignment.TopRight;
            // 
            // VUValue_Label
            // 
            VUValue_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            VUValue_Label.Location = new Point(158, 64);
            VUValue_Label.Name = "VUValue_Label";
            VUValue_Label.Size = new Size(60, 15);
            VUValue_Label.TabIndex = 7;
            VUValue_Label.Text = "0.0000";
            VUValue_Label.TextAlign = ContentAlignment.TopRight;
            // 
            // LSTER_Label
            // 
            LSTER_Label.AutoSize = true;
            LSTER_Label.Location = new Point(6, 88);
            LSTER_Label.Name = "LSTER_Label";
            LSTER_Label.Size = new Size(38, 15);
            LSTER_Label.TabIndex = 8;
            LSTER_Label.Text = "LSTER";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(MinF0_Label);
            groupBox2.Controls.Add(MaxF0_Label);
            groupBox2.Controls.Add(MinF0_NumericUpDown);
            groupBox2.Controls.Add(MaxF0_NumericUpDown);
            groupBox2.Location = new Point(3, 157);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(0);
            groupBox2.Size = new Size(224, 90);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Częstotliwość podstawowa";
            // 
            // MinF0_Label
            // 
            MinF0_Label.Location = new Point(3, 19);
            MinF0_Label.Margin = new Padding(3);
            MinF0_Label.Name = "MinF0_Label";
            MinF0_Label.Size = new Size(84, 23);
            MinF0_Label.TabIndex = 8;
            MinF0_Label.Text = "Min F0";
            MinF0_Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MaxF0_Label
            // 
            MaxF0_Label.Location = new Point(3, 46);
            MaxF0_Label.Margin = new Padding(3);
            MaxF0_Label.Name = "MaxF0_Label";
            MaxF0_Label.Size = new Size(84, 23);
            MaxF0_Label.TabIndex = 10;
            MaxF0_Label.Text = "Max F0";
            MaxF0_Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MinF0_NumericUpDown
            // 
            MinF0_NumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinF0_NumericUpDown.Location = new Point(139, 19);
            MinF0_NumericUpDown.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            MinF0_NumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MinF0_NumericUpDown.Name = "MinF0_NumericUpDown";
            MinF0_NumericUpDown.Size = new Size(82, 23);
            MinF0_NumericUpDown.TabIndex = 7;
            MinF0_NumericUpDown.Value = new decimal(new int[] { 50, 0, 0, 0 });
            MinF0_NumericUpDown.ValueChanged += MinF0_NumericUpDown_ValueChanged;
            // 
            // MaxF0_NumericUpDown
            // 
            MaxF0_NumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MaxF0_NumericUpDown.Location = new Point(139, 46);
            MaxF0_NumericUpDown.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            MaxF0_NumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MaxF0_NumericUpDown.Name = "MaxF0_NumericUpDown";
            MaxF0_NumericUpDown.Size = new Size(82, 23);
            MaxF0_NumericUpDown.TabIndex = 9;
            MaxF0_NumericUpDown.Value = new decimal(new int[] { 400, 0, 0, 0 });
            MaxF0_NumericUpDown.ValueChanged += MaxF0_NumericUpDown_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(VolumeSilenceThreshold_Label);
            groupBox1.Controls.Add(SilenceHighlighting_CheckBox);
            groupBox1.Controls.Add(VolumeThreshold_NumericUpDown);
            groupBox1.Location = new Point(3, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0);
            groupBox1.Size = new Size(224, 87);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cisza";
            // 
            // VolumeSilenceThreshold_Label
            // 
            VolumeSilenceThreshold_Label.Location = new Point(3, 19);
            VolumeSilenceThreshold_Label.Margin = new Padding(3);
            VolumeSilenceThreshold_Label.Name = "VolumeSilenceThreshold_Label";
            VolumeSilenceThreshold_Label.Size = new Size(109, 23);
            VolumeSilenceThreshold_Label.TabIndex = 3;
            VolumeSilenceThreshold_Label.Text = "Volume Threshold";
            VolumeSilenceThreshold_Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SilenceHighlighting_CheckBox
            // 
            SilenceHighlighting_CheckBox.AutoSize = true;
            SilenceHighlighting_CheckBox.Checked = true;
            SilenceHighlighting_CheckBox.CheckState = CheckState.Checked;
            SilenceHighlighting_CheckBox.Location = new Point(3, 48);
            SilenceHighlighting_CheckBox.Name = "SilenceHighlighting_CheckBox";
            SilenceHighlighting_CheckBox.Size = new Size(118, 19);
            SilenceHighlighting_CheckBox.TabIndex = 11;
            SilenceHighlighting_CheckBox.Text = "Zaznaczanie ciszy";
            SilenceHighlighting_CheckBox.UseVisualStyleBackColor = true;
            SilenceHighlighting_CheckBox.CheckedChanged += SilenceHighlighting_CheckBox_CheckedChanged;
            // 
            // VolumeThreshold_NumericUpDown
            // 
            VolumeThreshold_NumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            VolumeThreshold_NumericUpDown.DecimalPlaces = 4;
            VolumeThreshold_NumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            VolumeThreshold_NumericUpDown.Location = new Point(139, 19);
            VolumeThreshold_NumericUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            VolumeThreshold_NumericUpDown.Name = "VolumeThreshold_NumericUpDown";
            VolumeThreshold_NumericUpDown.Size = new Size(82, 23);
            VolumeThreshold_NumericUpDown.TabIndex = 6;
            VolumeThreshold_NumericUpDown.Value = new decimal(new int[] { 50, 0, 0, 262144 });
            VolumeThreshold_NumericUpDown.ValueChanged += VolumeThreshold_NumericUpDown_ValueChanged;
            // 
            // ZCRSilenceThreshold_Label
            // 
            ZCRSilenceThreshold_Label.Location = new Point(6, 303);
            ZCRSilenceThreshold_Label.Margin = new Padding(3);
            ZCRSilenceThreshold_Label.Name = "ZCRSilenceThreshold_Label";
            ZCRSilenceThreshold_Label.Size = new Size(109, 23);
            ZCRSilenceThreshold_Label.TabIndex = 4;
            ZCRSilenceThreshold_Label.Text = "ZCR Threshold";
            ZCRSilenceThreshold_Label.TextAlign = ContentAlignment.MiddleLeft;
            ZCRSilenceThreshold_Label.Visible = false;
            // 
            // ZCRThreshold_NumericUpDown
            // 
            ZCRThreshold_NumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ZCRThreshold_NumericUpDown.DecimalPlaces = 4;
            ZCRThreshold_NumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            ZCRThreshold_NumericUpDown.Location = new Point(142, 303);
            ZCRThreshold_NumericUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            ZCRThreshold_NumericUpDown.Name = "ZCRThreshold_NumericUpDown";
            ZCRThreshold_NumericUpDown.Size = new Size(82, 23);
            ZCRThreshold_NumericUpDown.TabIndex = 4;
            ZCRThreshold_NumericUpDown.Value = new decimal(new int[] { 10, 0, 0, 262144 });
            ZCRThreshold_NumericUpDown.Visible = false;
            ZCRThreshold_NumericUpDown.ValueChanged += ZCRThreshold_NumericUpDown_ValueChanged;
            // 
            // FrameSize_Label
            // 
            FrameSize_Label.Location = new Point(3, 3);
            FrameSize_Label.Name = "FrameSize_Label";
            FrameSize_Label.Size = new Size(87, 23);
            FrameSize_Label.TabIndex = 2;
            FrameSize_Label.Text = "Rozmiar ramki";
            FrameSize_Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrameSize_ComboBox
            // 
            FrameSize_ComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FrameSize_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FrameSize_ComboBox.FormattingEnabled = true;
            FrameSize_ComboBox.Location = new Point(145, 4);
            FrameSize_ComboBox.Name = "FrameSize_ComboBox";
            FrameSize_ComboBox.Size = new Size(82, 23);
            FrameSize_ComboBox.TabIndex = 1;
            FrameSize_ComboBox.SelectedIndexChanged += FrameSize_ComboBox_SelectedIndexChanged;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(884, 612);
            Controls.Add(MainSplitContainer);
            Controls.Add(MainMenu_MenuStrip);
            DoubleBuffered = true;
            MainMenuStrip = MainMenu_MenuStrip;
            MinimumSize = new Size(400, 200);
            Name = "MainWindow";
            Text = "AiPD Projekt 1";
            MainMenu_MenuStrip.ResumeLayout(false);
            MainMenu_MenuStrip.PerformLayout();
            MainSplitContainer.Panel1.ResumeLayout(false);
            MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).EndInit();
            MainSplitContainer.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MinF0_NumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxF0_NumericUpDown).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)VolumeThreshold_NumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ZCRThreshold_NumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainMenu_MenuStrip;
        private ToolStripMenuItem plikToolStripMenuItem;
        private ToolStripMenuItem Exit_ToolStripMenuItem;
        private ToolStripMenuItem LoadAudioFile_ToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private SplitContainer MainSplitContainer;
        private ScottPlot.WinForms.FormsPlot WavePlot;
        private ScottPlot.WinForms.FormsPlot VolumePlot;
        private ToolStripMenuItem widokToolStripMenuItem;
        private ToolStripMenuItem zresetujWykresyToolStripMenuItem;
        private ScottPlot.WinForms.FormsPlot STEPlot;
        private ScottPlot.WinForms.FormsPlot ZCRPlot;
        private ScottPlot.WinForms.FormsPlot FFAMDFPlot;
        private ScottPlot.WinForms.FormsPlot FFAutocorrelationPlot;
        private ScottPlot.WinForms.FormsPlot SRPlot;
        private Label VSTDValue_Label;
        private Label VMEAN_Label;
        private Label VSTD_Label;
        private Label VMEANValue_Label;
        private Label VDRValue_Label;
        private Label VDR_Label;
        private Label EnergyEntropyValue_Label;
        private Label EnergyEntropy_Label;
        private Label LSTERValue_Label;
        private Label LSTER_Label;
        private Label VUValue_Label;
        private Label VU_Label;
        private Label ZSTDValue_Label;
        private Label ZSTD_Label;
        private Label HZCRRValue_Label;
        private Label HZCRR_Label;
        private Label FrameSize_Label;
        private ComboBox FrameSize_ComboBox;
        private Label VolumeSilenceThreshold_Label;
        private Label ZCRSilenceThreshold_Label;
        private NumericUpDown ZCRThreshold_NumericUpDown;
        private NumericUpDown VolumeThreshold_NumericUpDown;
        private NumericUpDown MaxF0_NumericUpDown;
        private Label MaxF0_Label;
        private NumericUpDown MinF0_NumericUpDown;
        private Label MinF0_Label;
        private CheckBox SilenceHighlighting_CheckBox;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem exportCechFrameLevelToolStripMenuItem;
        private ToolStripMenuItem exportCechClipLevelToolStripMenuItem;
        private GroupBox groupBox3;
    }
}
