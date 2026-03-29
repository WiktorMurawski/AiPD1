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
            FrameSize_Label = new Label();
            FrameSize_ComboBox = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            HZCRRValue_Label = new Label();
            HZCRR_Label = new Label();
            ZSTDValue_Label = new Label();
            ZSTD_Label = new Label();
            EnergyEntropyValue_Label = new Label();
            EnergyEntropy_Label = new Label();
            LSTERValue_Label = new Label();
            LSTER_Label = new Label();
            VUValue_Label = new Label();
            VU_Label = new Label();
            VDRValue_Label = new Label();
            VDR_Label = new Label();
            VMEANValue_Label = new Label();
            VSTDValue_Label = new Label();
            VMEAN_Label = new Label();
            VSTD_Label = new Label();
            MainMenu_MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).BeginInit();
            MainSplitContainer.Panel1.SuspendLayout();
            MainSplitContainer.Panel2.SuspendLayout();
            MainSplitContainer.SuspendLayout();
            panel1.SuspendLayout();
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
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { LoadAudioFile_ToolStripMenuItem, toolStripMenuItem1, Exit_ToolStripMenuItem });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(38, 20);
            plikToolStripMenuItem.Text = "Plik";
            // 
            // LoadAudioFile_ToolStripMenuItem
            // 
            LoadAudioFile_ToolStripMenuItem.Name = "LoadAudioFile_ToolStripMenuItem";
            LoadAudioFile_ToolStripMenuItem.Size = new Size(168, 22);
            LoadAudioFile_ToolStripMenuItem.Text = "Załaduj plik audio";
            LoadAudioFile_ToolStripMenuItem.Click += LoadAudioFile_ToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(165, 6);
            // 
            // Exit_ToolStripMenuItem
            // 
            Exit_ToolStripMenuItem.Name = "Exit_ToolStripMenuItem";
            Exit_ToolStripMenuItem.Size = new Size(168, 22);
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
            MainSplitContainer.Panel1.BackColor = Color.White;
            MainSplitContainer.Panel1.Controls.Add(FFAMDFPlot);
            MainSplitContainer.Panel1.Controls.Add(FFAutocorrelationPlot);
            MainSplitContainer.Panel1.Controls.Add(SRPlot);
            MainSplitContainer.Panel1.Controls.Add(ZCRPlot);
            MainSplitContainer.Panel1.Controls.Add(STEPlot);
            MainSplitContainer.Panel1.Controls.Add(VolumePlot);
            MainSplitContainer.Panel1.Controls.Add(WavePlot);
            MainSplitContainer.Panel1.RightToLeft = RightToLeft.No;
            // 
            // MainSplitContainer.Panel2
            // 
            MainSplitContainer.Panel2.BackColor = SystemColors.Control;
            MainSplitContainer.Panel2.Controls.Add(FrameSize_Label);
            MainSplitContainer.Panel2.Controls.Add(FrameSize_ComboBox);
            MainSplitContainer.Panel2.Controls.Add(panel1);
            MainSplitContainer.Panel2.RightToLeft = RightToLeft.No;
            MainSplitContainer.RightToLeft = RightToLeft.No;
            MainSplitContainer.Size = new Size(884, 588);
            MainSplitContainer.SplitterDistance = 680;
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
            FFAMDFPlot.Size = new Size(660, 200);
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
            FFAutocorrelationPlot.Size = new Size(660, 200);
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
            SRPlot.Size = new Size(657, 200);
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
            ZCRPlot.Size = new Size(657, 200);
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
            STEPlot.Size = new Size(657, 200);
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
            VolumePlot.Size = new Size(657, 200);
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
            WavePlot.Size = new Size(657, 200);
            WavePlot.TabIndex = 0;
            WavePlot.Tag = "";
            // 
            // FrameSize_Label
            // 
            FrameSize_Label.Location = new Point(3, 3);
            FrameSize_Label.Name = "FrameSize_Label";
            FrameSize_Label.Size = new Size(100, 23);
            FrameSize_Label.TabIndex = 2;
            FrameSize_Label.Text = "Rozmiar ramki";
            FrameSize_Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrameSize_ComboBox
            // 
            FrameSize_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FrameSize_ComboBox.FormattingEnabled = true;
            FrameSize_ComboBox.Location = new Point(118, 3);
            FrameSize_ComboBox.Name = "FrameSize_ComboBox";
            FrameSize_ComboBox.Size = new Size(82, 23);
            FrameSize_ComboBox.TabIndex = 1;
            FrameSize_ComboBox.SelectedIndexChanged += FrameSize_ComboBox_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(HZCRRValue_Label);
            panel1.Controls.Add(HZCRR_Label);
            panel1.Controls.Add(ZSTDValue_Label);
            panel1.Controls.Add(ZSTD_Label);
            panel1.Controls.Add(EnergyEntropyValue_Label);
            panel1.Controls.Add(EnergyEntropy_Label);
            panel1.Controls.Add(LSTERValue_Label);
            panel1.Controls.Add(LSTER_Label);
            panel1.Controls.Add(VUValue_Label);
            panel1.Controls.Add(VU_Label);
            panel1.Controls.Add(VDRValue_Label);
            panel1.Controls.Add(VDR_Label);
            panel1.Controls.Add(VMEANValue_Label);
            panel1.Controls.Add(VSTDValue_Label);
            panel1.Controls.Add(VMEAN_Label);
            panel1.Controls.Add(VSTD_Label);
            panel1.Location = new Point(0, 391);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 197);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(3, 3);
            label1.Margin = new Padding(0, 3, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 18);
            label1.TabIndex = 16;
            label1.Text = "Cechy Clip-Level";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // HZCRRValue_Label
            // 
            HZCRRValue_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            HZCRRValue_Label.Location = new Point(97, 147);
            HZCRRValue_Label.Name = "HZCRRValue_Label";
            HZCRRValue_Label.Size = new Size(100, 15);
            HZCRRValue_Label.TabIndex = 15;
            HZCRRValue_Label.Text = "0.0000";
            HZCRRValue_Label.TextAlign = ContentAlignment.TopRight;
            // 
            // HZCRR_Label
            // 
            HZCRR_Label.AutoSize = true;
            HZCRR_Label.Location = new Point(3, 147);
            HZCRR_Label.Name = "HZCRR_Label";
            HZCRR_Label.Size = new Size(45, 15);
            HZCRR_Label.TabIndex = 14;
            HZCRR_Label.Text = "HZCRR";
            // 
            // ZSTDValue_Label
            // 
            ZSTDValue_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ZSTDValue_Label.Location = new Point(97, 132);
            ZSTDValue_Label.Name = "ZSTDValue_Label";
            ZSTDValue_Label.Size = new Size(100, 15);
            ZSTDValue_Label.TabIndex = 13;
            ZSTDValue_Label.Text = "0.0000";
            ZSTDValue_Label.TextAlign = ContentAlignment.TopRight;
            // 
            // ZSTD_Label
            // 
            ZSTD_Label.AutoSize = true;
            ZSTD_Label.Location = new Point(3, 132);
            ZSTD_Label.Name = "ZSTD_Label";
            ZSTD_Label.Size = new Size(34, 15);
            ZSTD_Label.TabIndex = 12;
            ZSTD_Label.Text = "ZSTD";
            // 
            // EnergyEntropyValue_Label
            // 
            EnergyEntropyValue_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EnergyEntropyValue_Label.Location = new Point(97, 108);
            EnergyEntropyValue_Label.Name = "EnergyEntropyValue_Label";
            EnergyEntropyValue_Label.Size = new Size(100, 15);
            EnergyEntropyValue_Label.TabIndex = 11;
            EnergyEntropyValue_Label.Text = "0.0000";
            EnergyEntropyValue_Label.TextAlign = ContentAlignment.TopRight;
            // 
            // EnergyEntropy_Label
            // 
            EnergyEntropy_Label.AutoSize = true;
            EnergyEntropy_Label.Location = new Point(3, 108);
            EnergyEntropy_Label.Name = "EnergyEntropy_Label";
            EnergyEntropy_Label.Size = new Size(87, 15);
            EnergyEntropy_Label.TabIndex = 10;
            EnergyEntropy_Label.Text = "Energy Entropy";
            // 
            // LSTERValue_Label
            // 
            LSTERValue_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LSTERValue_Label.Location = new Point(97, 93);
            LSTERValue_Label.Name = "LSTERValue_Label";
            LSTERValue_Label.Size = new Size(100, 15);
            LSTERValue_Label.TabIndex = 9;
            LSTERValue_Label.Text = "0.0000";
            LSTERValue_Label.TextAlign = ContentAlignment.TopRight;
            // 
            // LSTER_Label
            // 
            LSTER_Label.AutoSize = true;
            LSTER_Label.Location = new Point(3, 93);
            LSTER_Label.Name = "LSTER_Label";
            LSTER_Label.Size = new Size(38, 15);
            LSTER_Label.TabIndex = 8;
            LSTER_Label.Text = "LSTER";
            // 
            // VUValue_Label
            // 
            VUValue_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            VUValue_Label.Location = new Point(97, 69);
            VUValue_Label.Name = "VUValue_Label";
            VUValue_Label.Size = new Size(100, 15);
            VUValue_Label.TabIndex = 7;
            VUValue_Label.Text = "0.0000";
            VUValue_Label.TextAlign = ContentAlignment.TopRight;
            // 
            // VU_Label
            // 
            VU_Label.AutoSize = true;
            VU_Label.Location = new Point(3, 69);
            VU_Label.Name = "VU_Label";
            VU_Label.Size = new Size(22, 15);
            VU_Label.TabIndex = 6;
            VU_Label.Text = "VU";
            // 
            // VDRValue_Label
            // 
            VDRValue_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            VDRValue_Label.Location = new Point(97, 54);
            VDRValue_Label.Name = "VDRValue_Label";
            VDRValue_Label.Size = new Size(100, 15);
            VDRValue_Label.TabIndex = 5;
            VDRValue_Label.Text = "0.0000";
            VDRValue_Label.TextAlign = ContentAlignment.TopRight;
            // 
            // VDR_Label
            // 
            VDR_Label.AutoSize = true;
            VDR_Label.Location = new Point(3, 54);
            VDR_Label.Name = "VDR_Label";
            VDR_Label.Size = new Size(29, 15);
            VDR_Label.TabIndex = 4;
            VDR_Label.Text = "VDR";
            // 
            // VMEANValue_Label
            // 
            VMEANValue_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            VMEANValue_Label.Location = new Point(97, 39);
            VMEANValue_Label.Name = "VMEANValue_Label";
            VMEANValue_Label.Size = new Size(100, 15);
            VMEANValue_Label.TabIndex = 3;
            VMEANValue_Label.Text = "0.0000";
            VMEANValue_Label.TextAlign = ContentAlignment.TopRight;
            // 
            // VSTDValue_Label
            // 
            VSTDValue_Label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            VSTDValue_Label.Location = new Point(97, 24);
            VSTDValue_Label.Name = "VSTDValue_Label";
            VSTDValue_Label.Size = new Size(100, 15);
            VSTDValue_Label.TabIndex = 2;
            VSTDValue_Label.Text = "0.0000";
            VSTDValue_Label.TextAlign = ContentAlignment.TopRight;
            // 
            // VMEAN_Label
            // 
            VMEAN_Label.AutoSize = true;
            VMEAN_Label.Location = new Point(3, 39);
            VMEAN_Label.Name = "VMEAN_Label";
            VMEAN_Label.Size = new Size(48, 15);
            VMEAN_Label.TabIndex = 1;
            VMEAN_Label.Text = "VMEAN";
            // 
            // VSTD_Label
            // 
            VSTD_Label.AutoSize = true;
            VSTD_Label.Location = new Point(3, 24);
            VSTD_Label.Name = "VSTD_Label";
            VSTD_Label.Size = new Size(34, 15);
            VSTD_Label.TabIndex = 0;
            VSTD_Label.Text = "VSTD";
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
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
        private Label label1;
        private Label FrameSize_Label;
        private ComboBox FrameSize_ComboBox;
    }
}
