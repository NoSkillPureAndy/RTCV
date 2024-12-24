namespace RTCV.UI.Components.Controls
{
    partial class SavestateList
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pnBackForwardPage = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.pnChangeLoadSave = new System.Windows.Forms.Panel();
            this.btnToggleSaveLoad = new System.Windows.Forms.Button();
            this.btnSaveLoad = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnBackForwardPage.SuspendLayout();
            this.pnChangeLoadSave.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanel
            // 
            this.flowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanel.Location = new System.Drawing.Point(0, 31);
            this.flowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(152, 235);
            this.flowPanel.TabIndex = 0;
            // 
            // pnBackForwardPage
            // 
            this.pnBackForwardPage.Controls.Add(this.tableLayoutPanel1);
            this.pnBackForwardPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBackForwardPage.Location = new System.Drawing.Point(0, 239);
            this.pnBackForwardPage.Name = "pnBackForwardPage";
            this.pnBackForwardPage.Size = new System.Drawing.Size(152, 27);
            this.pnBackForwardPage.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 22);
            this.btnBack.TabIndex = 159;
            this.btnBack.TabStop = false;
            this.btnBack.Tag = "color:dark2";
            this.btnBack.Text = "◀";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnForward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnForward.ForeColor = System.Drawing.Color.White;
            this.btnForward.Location = new System.Drawing.Point(79, 0);
            this.btnForward.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(73, 22);
            this.btnForward.TabIndex = 160;
            this.btnForward.TabStop = false;
            this.btnForward.Tag = "color:dark2";
            this.btnForward.Text = "▶";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.BtnForward_Click);
            // 
            // pnChangeLoadSave
            // 
            this.pnChangeLoadSave.Controls.Add(this.tableLayoutPanel2);
            this.pnChangeLoadSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChangeLoadSave.Location = new System.Drawing.Point(0, 0);
            this.pnChangeLoadSave.Name = "pnChangeLoadSave";
            this.pnChangeLoadSave.Size = new System.Drawing.Size(152, 31);
            this.pnChangeLoadSave.TabIndex = 1;
            // 
            // btnToggleSaveLoad
            // 
            this.btnToggleSaveLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnToggleSaveLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnToggleSaveLoad.FlatAppearance.BorderSize = 0;
            this.btnToggleSaveLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleSaveLoad.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnToggleSaveLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnToggleSaveLoad.Location = new System.Drawing.Point(0, 0);
            this.btnToggleSaveLoad.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnToggleSaveLoad.Name = "btnToggleSaveLoad";
            this.btnToggleSaveLoad.Size = new System.Drawing.Size(73, 24);
            this.btnToggleSaveLoad.TabIndex = 129;
            this.btnToggleSaveLoad.TabStop = false;
            this.btnToggleSaveLoad.Tag = "color:dark2";
            this.btnToggleSaveLoad.Text = "Change ->";
            this.btnToggleSaveLoad.UseVisualStyleBackColor = false;
            this.btnToggleSaveLoad.Click += new System.EventHandler(this.BtnToggleSaveLoad_Click);
            // 
            // btnSaveLoad
            // 
            this.btnSaveLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSaveLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveLoad.FlatAppearance.BorderSize = 0;
            this.btnSaveLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveLoad.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnSaveLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveLoad.Location = new System.Drawing.Point(79, 0);
            this.btnSaveLoad.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnSaveLoad.Name = "btnSaveLoad";
            this.btnSaveLoad.Size = new System.Drawing.Size(73, 24);
            this.btnSaveLoad.TabIndex = 130;
            this.btnSaveLoad.TabStop = false;
            this.btnSaveLoad.Tag = "color:dark2";
            this.btnSaveLoad.Text = "LOAD";
            this.btnSaveLoad.UseVisualStyleBackColor = false;
            this.btnSaveLoad.Click += new System.EventHandler(this.HandleSaveLoadClick);
            this.btnSaveLoad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSaveLoad_MouseDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnForward, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(152, 22);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnSaveLoad, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnToggleSaveLoad, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(152, 24);
            this.tableLayoutPanel2.TabIndex = 132;
            // 
            // SavestateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnBackForwardPage);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.pnChangeLoadSave);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "SavestateList";
            this.Size = new System.Drawing.Size(152, 266);
            this.pnBackForwardPage.ResumeLayout(false);
            this.pnChangeLoadSave.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnBackForwardPage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Panel pnChangeLoadSave;
        private System.Windows.Forms.Button btnToggleSaveLoad;
        public System.Windows.Forms.Button btnSaveLoad;
        public System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
