namespace RTCV.UI
{
    partial class SavestateManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavestateManagerForm));
            this.btnSaveSavestateList = new System.Windows.Forms.Button();
            this.btnLoadSavestateList = new System.Windows.Forms.Button();
            this.cbSavestateLoadOnClick = new System.Windows.Forms.CheckBox();
            this.savestateList = new RTCV.UI.Components.Controls.SavestateList();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveSavestateList
            // 
            this.btnSaveSavestateList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSaveSavestateList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveSavestateList.FlatAppearance.BorderSize = 0;
            this.btnSaveSavestateList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSavestateList.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnSaveSavestateList.ForeColor = System.Drawing.Color.White;
            this.btnSaveSavestateList.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveSavestateList.Image")));
            this.btnSaveSavestateList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSavestateList.Location = new System.Drawing.Point(79, 0);
            this.btnSaveSavestateList.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnSaveSavestateList.Name = "btnSaveSavestateList";
            this.btnSaveSavestateList.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnSaveSavestateList.Size = new System.Drawing.Size(73, 32);
            this.btnSaveSavestateList.TabIndex = 168;
            this.btnSaveSavestateList.TabStop = false;
            this.btnSaveSavestateList.Tag = "color:dark2";
            this.btnSaveSavestateList.Text = "  Save";
            this.btnSaveSavestateList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSavestateList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveSavestateList.UseVisualStyleBackColor = false;
            this.btnSaveSavestateList.Click += new System.EventHandler(this.SaveSavestateList);
            // 
            // btnLoadSavestateList
            // 
            this.btnLoadSavestateList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnLoadSavestateList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadSavestateList.FlatAppearance.BorderSize = 0;
            this.btnLoadSavestateList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadSavestateList.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnLoadSavestateList.ForeColor = System.Drawing.Color.White;
            this.btnLoadSavestateList.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadSavestateList.Image")));
            this.btnLoadSavestateList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadSavestateList.Location = new System.Drawing.Point(0, 0);
            this.btnLoadSavestateList.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnLoadSavestateList.Name = "btnLoadSavestateList";
            this.btnLoadSavestateList.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnLoadSavestateList.Size = new System.Drawing.Size(73, 32);
            this.btnLoadSavestateList.TabIndex = 167;
            this.btnLoadSavestateList.TabStop = false;
            this.btnLoadSavestateList.Tag = "color:dark2";
            this.btnLoadSavestateList.Text = "  Load";
            this.btnLoadSavestateList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadSavestateList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadSavestateList.UseVisualStyleBackColor = false;
            this.btnLoadSavestateList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnLoadSavestateListButtonMouseDown);
            // 
            // cbSavestateLoadOnClick
            // 
            this.cbSavestateLoadOnClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSavestateLoadOnClick.AutoSize = true;
            this.cbSavestateLoadOnClick.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbSavestateLoadOnClick.ForeColor = System.Drawing.Color.White;
            this.cbSavestateLoadOnClick.Location = new System.Drawing.Point(12, 282);
            this.cbSavestateLoadOnClick.Name = "cbSavestateLoadOnClick";
            this.cbSavestateLoadOnClick.Size = new System.Drawing.Size(121, 17);
            this.cbSavestateLoadOnClick.TabIndex = 163;
            this.cbSavestateLoadOnClick.TabStop = false;
            this.cbSavestateLoadOnClick.Text = "Load state on click";
            this.cbSavestateLoadOnClick.UseVisualStyleBackColor = true;
            this.cbSavestateLoadOnClick.CheckedChanged += new System.EventHandler(this.UpdateLoadSavestateOnClick);
            // 
            // savestateList
            // 
            this.savestateList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savestateList.DataSource = null;
            this.savestateList.Location = new System.Drawing.Point(12, 12);
            this.savestateList.Margin = new System.Windows.Forms.Padding(1);
            this.savestateList.Name = "savestateList";
            this.savestateList.SelectedHolder = null;
            this.savestateList.Size = new System.Drawing.Size(152, 266);
            this.savestateList.TabIndex = 169;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnSaveSavestateList, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLoadSavestateList, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 300);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(152, 32);
            this.tableLayoutPanel1.TabIndex = 171;
            // 
            // SavestateManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(176, 344);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.savestateList);
            this.Controls.Add(this.cbSavestateLoadOnClick);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(176, 192);
            this.Name = "SavestateManagerForm";
            this.Tag = "color:dark1";
            this.Text = "Savestate Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HandleFormClosing);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.Shown += new System.EventHandler(this.OnFormShown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleMouseDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveSavestateList;
        private System.Windows.Forms.Button btnLoadSavestateList;
        public System.Windows.Forms.CheckBox cbSavestateLoadOnClick;
        public Components.Controls.SavestateList savestateList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
