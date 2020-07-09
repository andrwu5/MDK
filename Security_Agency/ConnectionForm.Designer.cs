﻿namespace Security_Agency
{
    partial class ConnectionForm
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
            this.btConnect = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btChecked = new System.Windows.Forms.Button();
            this.cbDatabases = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.cbServers = new System.Windows.Forms.ComboBox();
            this.lblServers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btConnect.Enabled = false;
            this.btConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btConnect.Location = new System.Drawing.Point(236, 161);
            this.btConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(377, 113);
            this.btConnect.TabIndex = 28;
            this.btConnect.Text = "Подключиться";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCancel.Location = new System.Drawing.Point(613, 161);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(187, 113);
            this.btCancel.TabIndex = 27;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btChecked
            // 
            this.btChecked.Dock = System.Windows.Forms.DockStyle.Left;
            this.btChecked.Enabled = false;
            this.btChecked.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btChecked.Location = new System.Drawing.Point(0, 161);
            this.btChecked.Margin = new System.Windows.Forms.Padding(4);
            this.btChecked.Name = "btChecked";
            this.btChecked.Size = new System.Drawing.Size(236, 113);
            this.btChecked.TabIndex = 26;
            this.btChecked.Text = "Проверка подключения";
            this.btChecked.UseVisualStyleBackColor = true;
            this.btChecked.Click += new System.EventHandler(this.btChecked_Click);
            // 
            // cbDatabases
            // 
            this.cbDatabases.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatabases.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.Location = new System.Drawing.Point(0, 122);
            this.cbDatabases.Margin = new System.Windows.Forms.Padding(4);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(800, 39);
            this.cbDatabases.TabIndex = 25;
            this.cbDatabases.SelectedIndexChanged += new System.EventHandler(this.cbDatabases_SelectedIndexChanged);
            // 
            // lblData
            // 
            this.lblData.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblData.Location = new System.Drawing.Point(0, 80);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(800, 42);
            this.lblData.TabIndex = 24;
            this.lblData.Text = "Название базы данных";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbServers
            // 
            this.cbServers.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cbServers.FormattingEnabled = true;
            this.cbServers.Location = new System.Drawing.Point(0, 41);
            this.cbServers.Margin = new System.Windows.Forms.Padding(4);
            this.cbServers.Name = "cbServers";
            this.cbServers.Size = new System.Drawing.Size(800, 39);
            this.cbServers.TabIndex = 23;
            this.cbServers.SelectedIndexChanged += new System.EventHandler(this.cbServers_SelectedIndexChanged);
            // 
            // lblServers
            // 
            this.lblServers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblServers.Location = new System.Drawing.Point(0, 0);
            this.lblServers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServers.Name = "lblServers";
            this.lblServers.Size = new System.Drawing.Size(800, 41);
            this.lblServers.TabIndex = 22;
            this.lblServers.Text = "Название сервера";
            this.lblServers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 274);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btChecked);
            this.Controls.Add(this.cbDatabases);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cbServers);
            this.Controls.Add(this.lblServers);
            this.Name = "ConnectionForm";
            this.Text = "Подключение к базе";
            this.Load += new System.EventHandler(this.ConnectionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btChecked;
        private System.Windows.Forms.ComboBox cbDatabases;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cbServers;
        private System.Windows.Forms.Label lblServers;
    }
}