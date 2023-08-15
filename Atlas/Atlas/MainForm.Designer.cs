/*
 * Created by SharpDevelop.
 * User: LAB-04
 * Date: 8/14/2023
 * Time: 8:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Atlas
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
			this.pic_neptuno = new System.Windows.Forms.PictureBox();
			this.pic_urano = new System.Windows.Forms.PictureBox();
			this.pic_mercurio = new System.Windows.Forms.PictureBox();
			this.pic_venus = new System.Windows.Forms.PictureBox();
			this.pic_saturno = new System.Windows.Forms.PictureBox();
			this.pic_jupiter = new System.Windows.Forms.PictureBox();
			this.pic_marte = new System.Windows.Forms.PictureBox();
			this.pic_tierra = new System.Windows.Forms.PictureBox();
			this.pic_central = new System.Windows.Forms.PictureBox();
			this.lbl_neptuno = new System.Windows.Forms.Label();
			this.lbl_urano = new System.Windows.Forms.Label();
			this.lbl_tierra = new System.Windows.Forms.Label();
			this.lbl_venus = new System.Windows.Forms.Label();
			this.lbl_mercurio = new System.Windows.Forms.Label();
			this.lbl_saturno = new System.Windows.Forms.Label();
			this.lbl_marte = new System.Windows.Forms.Label();
			this.lbl_jupiter = new System.Windows.Forms.Label();
			this.lbl_central = new System.Windows.Forms.Label();
			this.lbl_nombre = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pic_neptuno)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_urano)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_mercurio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_venus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_saturno)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_jupiter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_marte)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_tierra)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_central)).BeginInit();
			this.SuspendLayout();
			// 
			// pic_neptuno
			// 
			this.pic_neptuno.Location = new System.Drawing.Point(66, 201);
			this.pic_neptuno.Name = "pic_neptuno";
			this.pic_neptuno.Size = new System.Drawing.Size(134, 82);
			this.pic_neptuno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_neptuno.TabIndex = 0;
			this.pic_neptuno.TabStop = false;
			this.pic_neptuno.Click += new System.EventHandler(this.Funcion_Click);
			// 
			// pic_urano
			// 
			this.pic_urano.Location = new System.Drawing.Point(66, 380);
			this.pic_urano.Name = "pic_urano";
			this.pic_urano.Size = new System.Drawing.Size(125, 81);
			this.pic_urano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_urano.TabIndex = 1;
			this.pic_urano.TabStop = false;
			this.pic_urano.Click += new System.EventHandler(this.Funcion_Click);
			// 
			// pic_mercurio
			// 
			this.pic_mercurio.Location = new System.Drawing.Point(291, 51);
			this.pic_mercurio.Name = "pic_mercurio";
			this.pic_mercurio.Size = new System.Drawing.Size(133, 75);
			this.pic_mercurio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_mercurio.TabIndex = 2;
			this.pic_mercurio.TabStop = false;
			this.pic_mercurio.Click += new System.EventHandler(this.Pic_mercurioClick);
			// 
			// pic_venus
			// 
			this.pic_venus.Location = new System.Drawing.Point(766, 51);
			this.pic_venus.Name = "pic_venus";
			this.pic_venus.Size = new System.Drawing.Size(140, 70);
			this.pic_venus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_venus.TabIndex = 3;
			this.pic_venus.TabStop = false;
			this.pic_venus.Click += new System.EventHandler(this.Funcion_Click);
			// 
			// pic_saturno
			// 
			this.pic_saturno.Location = new System.Drawing.Point(291, 513);
			this.pic_saturno.Name = "pic_saturno";
			this.pic_saturno.Size = new System.Drawing.Size(120, 75);
			this.pic_saturno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_saturno.TabIndex = 4;
			this.pic_saturno.TabStop = false;
			this.pic_saturno.Click += new System.EventHandler(this.Funcion_Click);
			// 
			// pic_jupiter
			// 
			this.pic_jupiter.Location = new System.Drawing.Point(776, 513);
			this.pic_jupiter.Name = "pic_jupiter";
			this.pic_jupiter.Size = new System.Drawing.Size(130, 75);
			this.pic_jupiter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_jupiter.TabIndex = 5;
			this.pic_jupiter.TabStop = false;
			this.pic_jupiter.Click += new System.EventHandler(this.Funcion_Click);
			// 
			// pic_marte
			// 
			this.pic_marte.Location = new System.Drawing.Point(1011, 377);
			this.pic_marte.Name = "pic_marte";
			this.pic_marte.Size = new System.Drawing.Size(135, 84);
			this.pic_marte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_marte.TabIndex = 6;
			this.pic_marte.TabStop = false;
			this.pic_marte.Click += new System.EventHandler(this.Funcion_Click);
			// 
			// pic_tierra
			// 
			this.pic_tierra.Location = new System.Drawing.Point(1011, 201);
			this.pic_tierra.Name = "pic_tierra";
			this.pic_tierra.Size = new System.Drawing.Size(134, 82);
			this.pic_tierra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_tierra.TabIndex = 7;
			this.pic_tierra.TabStop = false;
			this.pic_tierra.Click += new System.EventHandler(this.Funcion_Click);
			// 
			// pic_central
			// 
			this.pic_central.Location = new System.Drawing.Point(291, 201);
			this.pic_central.Name = "pic_central";
			this.pic_central.Size = new System.Drawing.Size(399, 260);
			this.pic_central.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_central.TabIndex = 8;
			this.pic_central.TabStop = false;
			this.pic_central.Click += new System.EventHandler(this.Funcion_Click);
			// 
			// lbl_neptuno
			// 
			this.lbl_neptuno.Location = new System.Drawing.Point(66, 298);
			this.lbl_neptuno.Name = "lbl_neptuno";
			this.lbl_neptuno.Size = new System.Drawing.Size(100, 23);
			this.lbl_neptuno.TabIndex = 9;
			this.lbl_neptuno.Text = "NEPTUNO";
			// 
			// lbl_urano
			// 
			this.lbl_urano.Location = new System.Drawing.Point(66, 482);
			this.lbl_urano.Name = "lbl_urano";
			this.lbl_urano.Size = new System.Drawing.Size(100, 23);
			this.lbl_urano.TabIndex = 10;
			this.lbl_urano.Text = "URANO";
			// 
			// lbl_tierra
			// 
			this.lbl_tierra.Location = new System.Drawing.Point(1011, 298);
			this.lbl_tierra.Name = "lbl_tierra";
			this.lbl_tierra.Size = new System.Drawing.Size(100, 23);
			this.lbl_tierra.TabIndex = 11;
			this.lbl_tierra.Text = "TIERRA";
			// 
			// lbl_venus
			// 
			this.lbl_venus.Location = new System.Drawing.Point(766, 139);
			this.lbl_venus.Name = "lbl_venus";
			this.lbl_venus.Size = new System.Drawing.Size(100, 23);
			this.lbl_venus.TabIndex = 12;
			this.lbl_venus.Text = "VENUS";
			// 
			// lbl_mercurio
			// 
			this.lbl_mercurio.Location = new System.Drawing.Point(291, 139);
			this.lbl_mercurio.Name = "lbl_mercurio";
			this.lbl_mercurio.Size = new System.Drawing.Size(100, 23);
			this.lbl_mercurio.TabIndex = 13;
			this.lbl_mercurio.Text = "MERCURIO";
			// 
			// lbl_saturno
			// 
			this.lbl_saturno.Location = new System.Drawing.Point(291, 611);
			this.lbl_saturno.Name = "lbl_saturno";
			this.lbl_saturno.Size = new System.Drawing.Size(100, 23);
			this.lbl_saturno.TabIndex = 14;
			this.lbl_saturno.Text = "SATURNO";
			// 
			// lbl_marte
			// 
			this.lbl_marte.Location = new System.Drawing.Point(1011, 482);
			this.lbl_marte.Name = "lbl_marte";
			this.lbl_marte.Size = new System.Drawing.Size(100, 23);
			this.lbl_marte.TabIndex = 15;
			this.lbl_marte.Text = "MARTE";
			// 
			// lbl_jupiter
			// 
			this.lbl_jupiter.Location = new System.Drawing.Point(776, 602);
			this.lbl_jupiter.Name = "lbl_jupiter";
			this.lbl_jupiter.Size = new System.Drawing.Size(100, 23);
			this.lbl_jupiter.TabIndex = 16;
			this.lbl_jupiter.Text = "JUPITER";
			// 
			// lbl_central
			// 
			this.lbl_central.Location = new System.Drawing.Point(720, 201);
			this.lbl_central.Name = "lbl_central";
			this.lbl_central.Size = new System.Drawing.Size(222, 225);
			this.lbl_central.TabIndex = 17;
			this.lbl_central.Text = "Descripción";
			// 
			// lbl_nombre
			// 
			this.lbl_nombre.Location = new System.Drawing.Point(291, 468);
			this.lbl_nombre.Name = "lbl_nombre";
			this.lbl_nombre.Size = new System.Drawing.Size(100, 23);
			this.lbl_nombre.TabIndex = 18;
			this.lbl_nombre.Text = "nombre del planeta";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1277, 652);
			this.Controls.Add(this.lbl_nombre);
			this.Controls.Add(this.lbl_central);
			this.Controls.Add(this.lbl_jupiter);
			this.Controls.Add(this.lbl_marte);
			this.Controls.Add(this.lbl_saturno);
			this.Controls.Add(this.lbl_mercurio);
			this.Controls.Add(this.lbl_venus);
			this.Controls.Add(this.lbl_tierra);
			this.Controls.Add(this.lbl_urano);
			this.Controls.Add(this.lbl_neptuno);
			this.Controls.Add(this.pic_central);
			this.Controls.Add(this.pic_tierra);
			this.Controls.Add(this.pic_marte);
			this.Controls.Add(this.pic_jupiter);
			this.Controls.Add(this.pic_saturno);
			this.Controls.Add(this.pic_venus);
			this.Controls.Add(this.pic_mercurio);
			this.Controls.Add(this.pic_urano);
			this.Controls.Add(this.pic_neptuno);
			this.Name = "MainForm";
			this.Text = "Atlas";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.Click += new System.EventHandler(this.Funcion_Click);
			((System.ComponentModel.ISupportInitialize)(this.pic_neptuno)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_urano)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_mercurio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_venus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_saturno)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_jupiter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_marte)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_tierra)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_central)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lbl_nombre;
		private System.Windows.Forms.Label lbl_central;
		private System.Windows.Forms.Label lbl_jupiter;
		private System.Windows.Forms.Label lbl_marte;
		private System.Windows.Forms.Label lbl_saturno;
		private System.Windows.Forms.Label lbl_mercurio;
		private System.Windows.Forms.Label lbl_venus;
		private System.Windows.Forms.Label lbl_tierra;
		private System.Windows.Forms.Label lbl_urano;
		private System.Windows.Forms.Label lbl_neptuno;
		private System.Windows.Forms.PictureBox pic_central;
		private System.Windows.Forms.PictureBox pic_tierra;
		private System.Windows.Forms.PictureBox pic_marte;
		private System.Windows.Forms.PictureBox pic_jupiter;
		private System.Windows.Forms.PictureBox pic_saturno;
		private System.Windows.Forms.PictureBox pic_venus;
		private System.Windows.Forms.PictureBox pic_mercurio;
		private System.Windows.Forms.PictureBox pic_urano;
		private System.Windows.Forms.PictureBox pic_neptuno;
	}
}
