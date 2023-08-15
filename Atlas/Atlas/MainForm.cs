using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atlas
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public string [] imagen_planetas;
		public string [] titulo_planetas;
		public string [] descripcion_planetas;
 		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void cargar_vector_imagenes(){
			imagen_planetas = new string [8];
			imagen_planetas[0]=@"C:\Users\LAB_08\Pictures\mercurio.jpg";
			imagen_planetas[1]=@"C:\Users\LAB_08\Pictures\venus.jpg";
			imagen_planetas[2]=@"C:\Users\LAB_08\Pictures\tierra.jpg";
			imagen_planetas[3]=@"C:\Users\LAB_08\Pictures\marte.jpg";
			imagen_planetas[4]=@"C:\Users\LAB_08\Pictures\jupiter.jpg";
			imagen_planetas[5]=@"C:\Users\LAB_08\Pictures\saturno.jpg";
			imagen_planetas[6]=@"C:\Users\LAB_08\Pictures\urano.jpg";
			imagen_planetas[7]=@"C:\Users\LAB_08\Pictures\neptuno.jpg";
			pic_mercurio.Image=Image.FromFile(imagen_planetas[0]);
			pic_venus.Image=Image.FromFile(imagen_planetas[1]);
			pic_tierra.Image=Image.FromFile(imagen_planetas[2]);
			pic_marte.Image=Image.FromFile(imagen_planetas[3]);
			pic_jupiter.Image=Image.FromFile(imagen_planetas[4]);
			pic_saturno.Image=Image.FromFile(imagen_planetas[5]);
			pic_urano.Image=Image.FromFile(imagen_planetas[6]);
			pic_neptuno.Image=Image.FromFile(imagen_planetas[7]);
		}
		
		public void cargar_vector_nombre(){
			titulo_planetas = new string [8];
			titulo_planetas[0]=lbl_mercurio.Text;
			titulo_planetas[1]=lbl_venus.Text;
			titulo_planetas[2]=lbl_tierra.Text;
			titulo_planetas[3]=lbl_marte.Text;
			titulo_planetas[4]=lbl_jupiter.Text;
			titulo_planetas[5]=lbl_saturno.Text;
			titulo_planetas[6]=lbl_urano.Text;
			titulo_planetas[7]=lbl_neptuno.Text;
			lbl_mercurio.Text=(titulo_planetas[0]);
			lbl_venus.Text=(titulo_planetas[1]);
			lbl_tierra.Text=(titulo_planetas[2]);
			lbl_marte.Text=(titulo_planetas[3]);
			lbl_jupiter.Text=(titulo_planetas[4]);
			lbl_saturno.Text=(titulo_planetas[5]);
			lbl_urano.Text=(titulo_planetas[6]);
			lbl_neptuno.Text=(titulo_planetas[7]);
		
		}
		
		//public void cargar_vector_descripcion(){
		//	descripcion_planetas = new string[8];
		//	descripcion_planetas[0]=lbl_mercurio_desc;
		//	descripcion_planetas[1]=lbl_venus_desc;
		//	descripcion_planetas[2]=lbl_tierra_desc;
		//	descripcion_planetas[3]=lbl_marte_desc;
		//	descripcion_planetas[4]=lbl_jupiter_desc;
		//	descripcion_planetas[5]=lbl_saturno_desc;
		//	descripcion_planetas[6]=lbl_urano_desc;
		//	descripcion_planetas[7]=lbl_neptuno_desc;
		//	lbl_mercurio_desc.Text=(descripcion_planetas[0]);
		//	lbl_venus_desc.Text=(descripcion_planetas[1]);
		//	lbl_tierra_desc.Text=(descripcion_planetas[2]);
		//	lbl_marte_desc.Text=(descripcion_planetas[3]);
		//	lbl_jupiter_desc.Text=(descripcion_planetas[4]);
		//	lbl_saturno_desc.Text=(descripcion_planetas[5]);
		//	lbl_urano_desc.Text=(descripcion_planetas[6]);
		//	lbl_neptuno_desc.Text=(descripcion_planetas[7]);
		//}
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			cargar_vector_imagenes();
		}
		
		void Pic_mercurioClick(object sender, EventArgs e)
		{
			pic_central.Image =	pic_mercurio.Image;		
		}
		
		void Funcion_Click(object sender, EventArgs e)
		{
			PictureBox pic_aux;
			pic_aux=(PictureBox)sender;
			pic_central.Image=pic_aux.Image;		
		}
	}
}
