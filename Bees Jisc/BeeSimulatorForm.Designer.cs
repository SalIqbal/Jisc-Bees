using System.Drawing;
using System.Windows.Forms;

namespace Bees_Jisc
{
    partial class BeeSimulatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox BeeList;
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
            this.BeeList = new System.Windows.Forms.ListBox();
            this.btnDamage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BeeList
            // 
            this.BeeList.BackColor = System.Drawing.SystemColors.InfoText;
            this.BeeList.Dock = System.Windows.Forms.DockStyle.Left;
            this.BeeList.Font = new System.Drawing.Font("Arial", 12F);
            this.BeeList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BeeList.FormattingEnabled = true;
            this.BeeList.ItemHeight = 23;
            this.BeeList.Location = new System.Drawing.Point(0, 0);
            this.BeeList.Name = "BeeList";
            this.BeeList.Size = new System.Drawing.Size(671, 686);
            this.BeeList.TabIndex = 0;
            this.BeeList.SelectedIndexChanged += new System.EventHandler(this.BeeList_SelectedIndexChanged);
            // 
            // btnDamage
            // 
            this.btnDamage.BackColor = System.Drawing.Color.Red;
            this.btnDamage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDamage.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnDamage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDamage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDamage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnDamage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDamage.Location = new System.Drawing.Point(677, 7);
            this.btnDamage.Name = "btnDamage";
            this.btnDamage.Size = new System.Drawing.Size(119, 60);
            this.btnDamage.TabIndex = 1;
            this.btnDamage.Text = "Attack";
            this.btnDamage.UseVisualStyleBackColor = false;
            this.btnDamage.Click += new System.EventHandler(this.btnDamage_Click);
            // 
            // BeeSimulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 686);
            this.Controls.Add(this.btnDamage);
            this.Controls.Add(this.BeeList);
            this.Name = "BeeSimulatorForm";
            this.Text = "Bees Health";
            this.Load += new System.EventHandler(this.BeeSimulatorForm_Load_1);
            this.Resize += new System.EventHandler(this.BeeSimulatorForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

    }
}

