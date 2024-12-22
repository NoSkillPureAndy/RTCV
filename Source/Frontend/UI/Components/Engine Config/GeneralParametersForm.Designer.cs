namespace RTCV.UI
{
	partial class GeneralParametersForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralParametersForm));
            this.cbBlastRadius = new System.Windows.Forms.ComboBox();
            this.labelBlastRadius = new System.Windows.Forms.Label();
            this.multiTB_ErrorDelay = new RTCV.UI.Components.Controls.MultiTrackBar();
            this.multiTB_Intensity = new RTCV.UI.Components.Controls.MultiTrackBar();
            this.btnClearAllFreezes = new System.Windows.Forms.Button();
            this.cbCreateInfiniteUnits = new System.Windows.Forms.CheckBox();
            this.cbClearFreezesOnRewind = new System.Windows.Forms.CheckBox();
            this.lbMaxFreeze = new System.Windows.Forms.Label();
            this.updownMaxFreeze = new RTCV.UI.Components.Controls.MultiUpDown();
            this.SuspendLayout();
            // 
            // cbBlastRadius
            // 
            this.cbBlastRadius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.cbBlastRadius.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBlastRadius.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBlastRadius.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbBlastRadius.ForeColor = System.Drawing.Color.White;
            this.cbBlastRadius.FormattingEnabled = true;
            this.cbBlastRadius.Items.AddRange(new object[] {
            "SPREAD",
            "CHUNK",
            "BURST",
            "EVEN",
            "PROPORTIONAL",
            "NORMALIZED"});
            this.cbBlastRadius.Location = new System.Drawing.Point(99, 127);
            this.cbBlastRadius.Name = "cbBlastRadius";
            this.cbBlastRadius.Size = new System.Drawing.Size(113, 21);
            this.cbBlastRadius.TabIndex = 21;
            this.cbBlastRadius.Tag = "color:normal";
            this.cbBlastRadius.SelectedIndexChanged += new System.EventHandler(this.OnBlastRadiusSelectedIndexChanged);
            this.cbBlastRadius.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleMouseDown);
            // 
            // labelBlastRadius
            // 
            this.labelBlastRadius.AutoSize = true;
            this.labelBlastRadius.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelBlastRadius.ForeColor = System.Drawing.Color.White;
            this.labelBlastRadius.Location = new System.Drawing.Point(9, 128);
            this.labelBlastRadius.Name = "labelBlastRadius";
            this.labelBlastRadius.Size = new System.Drawing.Size(81, 17);
            this.labelBlastRadius.TabIndex = 20;
            this.labelBlastRadius.Text = "Blast Radius:";
            this.labelBlastRadius.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleMouseDown);
            // 
            // multiTB_ErrorDelay
            // 
            this.multiTB_ErrorDelay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.multiTB_ErrorDelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.multiTB_ErrorDelay.Checked = false;
            this.multiTB_ErrorDelay.DisplayCheckbox = false;
            this.multiTB_ErrorDelay.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.multiTB_ErrorDelay.Hexadecimal = false;
            this.multiTB_ErrorDelay.Label = "Error Delay";
            this.multiTB_ErrorDelay.Location = new System.Drawing.Point(4, 64);
            this.multiTB_ErrorDelay.Maximum = ((long)(65535));
            this.multiTB_ErrorDelay.Minimum = ((long)(1));
            this.multiTB_ErrorDelay.Name = "multiTB_ErrorDelay";
            this.multiTB_ErrorDelay.Size = new System.Drawing.Size(216, 60);
            this.multiTB_ErrorDelay.TabIndex = 23;
            this.multiTB_ErrorDelay.Tag = "color:dark1";
            this.multiTB_ErrorDelay.UncapNumericBox = false;
            this.multiTB_ErrorDelay.Value = ((long)(1));
            // 
            // multiTB_Intensity
            // 
            this.multiTB_Intensity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.multiTB_Intensity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.multiTB_Intensity.Checked = false;
            this.multiTB_Intensity.DisplayCheckbox = false;
            this.multiTB_Intensity.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.multiTB_Intensity.Hexadecimal = false;
            this.multiTB_Intensity.Label = "Intensity";
            this.multiTB_Intensity.Location = new System.Drawing.Point(4, 5);
            this.multiTB_Intensity.Maximum = ((long)(65535));
            this.multiTB_Intensity.Minimum = ((long)(1));
            this.multiTB_Intensity.Name = "multiTB_Intensity";
            this.multiTB_Intensity.Size = new System.Drawing.Size(216, 60);
            this.multiTB_Intensity.TabIndex = 22;
            this.multiTB_Intensity.Tag = "color:dark1";
            this.multiTB_Intensity.UncapNumericBox = false;
            this.multiTB_Intensity.Value = ((long)(1));
            // 
            // btnClearAllFreezes
            // 
            this.btnClearAllFreezes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearAllFreezes.BackColor = System.Drawing.Color.Gray;
            this.btnClearAllFreezes.FlatAppearance.BorderSize = 0;
            this.btnClearAllFreezes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAllFreezes.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnClearAllFreezes.ForeColor = System.Drawing.Color.White;
            this.btnClearAllFreezes.Location = new System.Drawing.Point(99, 203);
            this.btnClearAllFreezes.Name = "btnClearAllFreezes";
            this.btnClearAllFreezes.Size = new System.Drawing.Size(113, 33);
            this.btnClearAllFreezes.TabIndex = 159;
            this.btnClearAllFreezes.TabStop = false;
            this.btnClearAllFreezes.Tag = "color:light1";
            this.btnClearAllFreezes.Text = "Clear ∞ units";
            this.btnClearAllFreezes.UseVisualStyleBackColor = false;
            // 
            // cbCreateInfiniteUnits
            // 
            this.cbCreateInfiniteUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCreateInfiniteUnits.AutoSize = true;
            this.cbCreateInfiniteUnits.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbCreateInfiniteUnits.ForeColor = System.Drawing.Color.White;
            this.cbCreateInfiniteUnits.Location = new System.Drawing.Point(12, 158);
            this.cbCreateInfiniteUnits.Name = "cbCreateInfiniteUnits";
            this.cbCreateInfiniteUnits.Size = new System.Drawing.Size(128, 17);
            this.cbCreateInfiniteUnits.TabIndex = 158;
            this.cbCreateInfiniteUnits.Text = "Create infinite units";
            this.cbCreateInfiniteUnits.UseVisualStyleBackColor = true;
            this.cbCreateInfiniteUnits.CheckedChanged += new System.EventHandler(this.UpdateCreateInfiniteUnits);
            // 
            // cbClearFreezesOnRewind
            // 
            this.cbClearFreezesOnRewind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbClearFreezesOnRewind.AutoSize = true;
            this.cbClearFreezesOnRewind.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbClearFreezesOnRewind.ForeColor = System.Drawing.Color.White;
            this.cbClearFreezesOnRewind.Location = new System.Drawing.Point(12, 178);
            this.cbClearFreezesOnRewind.Name = "cbClearFreezesOnRewind";
            this.cbClearFreezesOnRewind.Size = new System.Drawing.Size(177, 17);
            this.cbClearFreezesOnRewind.TabIndex = 157;
            this.cbClearFreezesOnRewind.Text = "Clear infinite units on rewind";
            this.cbClearFreezesOnRewind.UseVisualStyleBackColor = true;
            // 
            // lbMaxFreeze
            // 
            this.lbMaxFreeze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMaxFreeze.AutoSize = true;
            this.lbMaxFreeze.Font = new System.Drawing.Font("Segoe UI Symbol", 8F);
            this.lbMaxFreeze.ForeColor = System.Drawing.Color.White;
            this.lbMaxFreeze.Location = new System.Drawing.Point(9, 198);
            this.lbMaxFreeze.Name = "lbMaxFreeze";
            this.lbMaxFreeze.Size = new System.Drawing.Size(72, 13);
            this.lbMaxFreeze.TabIndex = 156;
            this.lbMaxFreeze.Text = "Max ∞ Units";
            // 
            // updownMaxFreeze
            // 
            this.updownMaxFreeze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updownMaxFreeze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.updownMaxFreeze.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.updownMaxFreeze.ForeColor = System.Drawing.Color.White;
            this.updownMaxFreeze.Hexadecimal = false;
            this.updownMaxFreeze.Location = new System.Drawing.Point(12, 214);
            this.updownMaxFreeze.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.updownMaxFreeze.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updownMaxFreeze.Name = "updownMaxFreeze";
            this.updownMaxFreeze.Size = new System.Drawing.Size(70, 22);
            this.updownMaxFreeze.TabIndex = 155;
            this.updownMaxFreeze.Tag = "color:normal";
            this.updownMaxFreeze.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // GeneralParametersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(224, 248);
            this.Controls.Add(this.btnClearAllFreezes);
            this.Controls.Add(this.cbCreateInfiniteUnits);
            this.Controls.Add(this.cbClearFreezesOnRewind);
            this.Controls.Add(this.lbMaxFreeze);
            this.Controls.Add(this.updownMaxFreeze);
            this.Controls.Add(this.multiTB_ErrorDelay);
            this.Controls.Add(this.multiTB_Intensity);
            this.Controls.Add(this.cbBlastRadius);
            this.Controls.Add(this.labelBlastRadius);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(224, 248);
            this.Name = "GeneralParametersForm";
            this.Tag = "color:dark1";
            this.Text = "General Parameters";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HandleFormClosing);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.Shown += new System.EventHandler(this.OnFormShown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleMouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		public System.Windows.Forms.ComboBox cbBlastRadius;
		public System.Windows.Forms.Label labelBlastRadius;
		public UI.Components.Controls.MultiTrackBar multiTB_Intensity;
		public UI.Components.Controls.MultiTrackBar multiTB_ErrorDelay;
        private System.Windows.Forms.Button btnClearAllFreezes;
        public System.Windows.Forms.CheckBox cbCreateInfiniteUnits;
        public System.Windows.Forms.CheckBox cbClearFreezesOnRewind;
        private System.Windows.Forms.Label lbMaxFreeze;
        public Components.Controls.MultiUpDown updownMaxFreeze;
    }
}
