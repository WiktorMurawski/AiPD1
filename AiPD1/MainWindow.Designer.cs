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
            MainMenu_MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).BeginInit();
            MainSplitContainer.Panel1.SuspendLayout();
            MainSplitContainer.SuspendLayout();
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
            MainSplitContainer.Panel2.RightToLeft = RightToLeft.No;
            MainSplitContainer.RightToLeft = RightToLeft.No;
            MainSplitContainer.Size = new Size(884, 588);
            MainSplitContainer.SplitterDistance = 650;
            MainSplitContainer.TabIndex = 1;
            // 
            // FFAMDFPlot
            // 
            FFAMDFPlot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FFAMDFPlot.BackColor = Color.Transparent;
            FFAMDFPlot.DisplayScale = 1F;
            FFAMDFPlot.Location = new Point(0, 1200);
            FFAMDFPlot.Margin = new Padding(0);
            FFAMDFPlot.Name = "FFAMDFPlot";
            FFAMDFPlot.Size = new Size(633, 200);
            FFAMDFPlot.TabIndex = 6;
            // 
            // FFAutocorrelationPlot
            // 
            FFAutocorrelationPlot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FFAutocorrelationPlot.BackColor = Color.Transparent;
            FFAutocorrelationPlot.DisplayScale = 1F;
            FFAutocorrelationPlot.Location = new Point(0, 1000);
            FFAutocorrelationPlot.Margin = new Padding(0);
            FFAutocorrelationPlot.Name = "FFAutocorrelationPlot";
            FFAutocorrelationPlot.Size = new Size(633, 200);
            FFAutocorrelationPlot.TabIndex = 5;
            // 
            // SRPlot
            // 
            SRPlot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SRPlot.BackColor = Color.Transparent;
            SRPlot.DisplayScale = 1F;
            SRPlot.Location = new Point(0, 800);
            SRPlot.Margin = new Padding(0);
            SRPlot.Name = "SRPlot";
            SRPlot.Size = new Size(633, 200);
            SRPlot.TabIndex = 4;
            // 
            // ZCRPlot
            // 
            ZCRPlot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ZCRPlot.BackColor = Color.Transparent;
            ZCRPlot.DisplayScale = 1F;
            ZCRPlot.Location = new Point(0, 600);
            ZCRPlot.Margin = new Padding(0);
            ZCRPlot.Name = "ZCRPlot";
            ZCRPlot.Size = new Size(633, 200);
            ZCRPlot.TabIndex = 3;
            // 
            // STEPlot
            // 
            STEPlot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            STEPlot.BackColor = Color.Transparent;
            STEPlot.DisplayScale = 1F;
            STEPlot.Location = new Point(0, 400);
            STEPlot.Margin = new Padding(0);
            STEPlot.Name = "STEPlot";
            STEPlot.Size = new Size(633, 200);
            STEPlot.TabIndex = 2;
            // 
            // VolumePlot
            // 
            VolumePlot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            VolumePlot.BackColor = Color.Transparent;
            VolumePlot.DisplayScale = 1F;
            VolumePlot.Location = new Point(0, 200);
            VolumePlot.Margin = new Padding(0);
            VolumePlot.Name = "VolumePlot";
            VolumePlot.Size = new Size(633, 200);
            VolumePlot.TabIndex = 1;
            // 
            // WavePlot
            // 
            WavePlot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            WavePlot.BackColor = Color.Transparent;
            WavePlot.DisplayScale = 1F;
            WavePlot.Location = new Point(0, 0);
            WavePlot.Margin = new Padding(0);
            WavePlot.Name = "WavePlot";
            WavePlot.Size = new Size(633, 200);
            WavePlot.TabIndex = 0;
            WavePlot.Tag = "";
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
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).EndInit();
            MainSplitContainer.ResumeLayout(false);
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
    }
}
