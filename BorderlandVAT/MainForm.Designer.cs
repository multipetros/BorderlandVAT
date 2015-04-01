/*
 * BorderlandVAT - Copyright (C) 2011 Petros Kyladitis
 * A command line process killing & restaring tool
 * Developed in SharpDevelop, at C# language, targeted .NET/Mono
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
namespace BorderlandVAT
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelSitePrice = new System.Windows.Forms.Label();
			this.labelChiosPrice = new System.Windows.Forms.Label();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.labelPrice = new System.Windows.Forms.Label();
			this.pictureBoxClear = new System.Windows.Forms.PictureBox();
			this.pictureBoxAbout = new System.Windows.Forms.PictureBox();
			this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
			this.comboBoxRate = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
			this.SuspendLayout();
			// 
			// labelSitePrice
			// 
			this.labelSitePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.labelSitePrice.Location = new System.Drawing.Point(7, 8);
			this.labelSitePrice.Name = "labelSitePrice";
			this.labelSitePrice.Size = new System.Drawing.Size(120, 24);
			this.labelSitePrice.TabIndex = 0;
			this.labelSitePrice.Text = "Τιμή καταλόγου";
			// 
			// labelChiosPrice
			// 
			this.labelChiosPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.labelChiosPrice.Location = new System.Drawing.Point(7, 41);
			this.labelChiosPrice.Name = "labelChiosPrice";
			this.labelChiosPrice.Size = new System.Drawing.Size(120, 24);
			this.labelChiosPrice.TabIndex = 1;
			this.labelChiosPrice.Text = "Τοπική τιμή";
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.textBoxPrice.Location = new System.Drawing.Point(133, 8);
			this.textBoxPrice.MaxLength = 12;
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(167, 26);
			this.textBoxPrice.TabIndex = 2;
			this.textBoxPrice.TextChanged += new System.EventHandler(this.TextBoxPriceTextChanged);
			// 
			// labelPrice
			// 
			this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.labelPrice.Location = new System.Drawing.Point(133, 42);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(167, 24);
			this.labelPrice.TabIndex = 3;
			this.labelPrice.Text = "0,00 €";
			// 
			// pictureBoxClear
			// 
			this.pictureBoxClear.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxClear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxClear.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClear.Image")));
			this.pictureBoxClear.Location = new System.Drawing.Point(301, 5);
			this.pictureBoxClear.Name = "pictureBoxClear";
			this.pictureBoxClear.Size = new System.Drawing.Size(32, 32);
			this.pictureBoxClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxClear.TabIndex = 6;
			this.pictureBoxClear.TabStop = false;
			this.pictureBoxClear.Click += new System.EventHandler(this.PictureBoxClearClick);
			this.pictureBoxClear.MouseHover += new System.EventHandler(this.PictureBoxClearMouseHover);
			// 
			// pictureBoxAbout
			// 
			this.pictureBoxAbout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxAbout.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAbout.Image")));
			this.pictureBoxAbout.Location = new System.Drawing.Point(393, 4);
			this.pictureBoxAbout.Name = "pictureBoxAbout";
			this.pictureBoxAbout.Size = new System.Drawing.Size(16, 16);
			this.pictureBoxAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxAbout.TabIndex = 7;
			this.pictureBoxAbout.TabStop = false;
			this.pictureBoxAbout.Click += new System.EventHandler(this.PictureBoxAboutClick);
			this.pictureBoxAbout.MouseHover += new System.EventHandler(this.PictureBoxAboutMouseHover);
			// 
			// pictureBoxSettings
			// 
			this.pictureBoxSettings.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxSettings.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSettings.Image")));
			this.pictureBoxSettings.Location = new System.Drawing.Point(371, 4);
			this.pictureBoxSettings.Name = "pictureBoxSettings";
			this.pictureBoxSettings.Size = new System.Drawing.Size(16, 16);
			this.pictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxSettings.TabIndex = 8;
			this.pictureBoxSettings.TabStop = false;
			this.pictureBoxSettings.Click += new System.EventHandler(this.PictureBoxSettingsClick);
			this.pictureBoxSettings.MouseHover += new System.EventHandler(this.PictureBoxSettingsMouseHover);
			// 
			// comboBoxRate
			// 
			this.comboBoxRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxRate.FormattingEnabled = true;
			this.comboBoxRate.Items.AddRange(new object[] {
									"Υψηλός",
									"Μεσαίος",
									"Χαμηλός"});
			this.comboBoxRate.Location = new System.Drawing.Point(339, 40);
			this.comboBoxRate.Name = "comboBoxRate";
			this.comboBoxRate.Size = new System.Drawing.Size(73, 21);
			this.comboBoxRate.TabIndex = 10;
			this.comboBoxRate.MouseHover += new System.EventHandler(this.ComboBoxMouseHover);
			this.comboBoxRate.SelectedValueChanged += new System.EventHandler(this.ComboBoxRateSelectedValueChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(339, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 14);
			this.label1.TabIndex = 11;
			this.label1.Text = "Συντελεστής";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(420, 71);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBoxRate);
			this.Controls.Add(this.pictureBoxSettings);
			this.Controls.Add(this.pictureBoxAbout);
			this.Controls.Add(this.pictureBoxClear);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.labelChiosPrice);
			this.Controls.Add(this.labelSitePrice);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Υπολογιστής μειωμένου ΦΠΑ";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxRate;
		private System.Windows.Forms.PictureBox pictureBoxAbout;
		private System.Windows.Forms.PictureBox pictureBoxSettings;
		private System.Windows.Forms.PictureBox pictureBoxClear;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.Label labelChiosPrice;
		private System.Windows.Forms.Label labelSitePrice;
	}
}
