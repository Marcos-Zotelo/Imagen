using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Imagenes
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public string [] imagen;
		
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
		
		public void cargar_vectores(){
			imagen=new string [5];
			imagen[0]=@"C:\Users\LAB_08\Pictures\mega.jpg";
			imagen[1]=@"C:\Users\LAB_08\Pictures\nashe.jpg";
			imagen[2]=@"C:\Users\LAB_08\Pictures\Sin título.png";
			imagen[3]=@"C:\Users\LAB_08\Pictures\202351815342084_1.jpg";
			imagen[4]=@"C:\Users\LAB_08\Pictures\programacion.jpg";
			
		}
		void cargar_PictureBoxs(){
			pic1.Image=Image.FromFile(imagen[0]);
			pic2.Image=Image.FromFile(imagen[1]);
			pic3.Image=Image.FromFile(imagen[2]);
			pic4.Image=Image.FromFile(imagen[3]);
			pic5.Image=Image.FromFile(imagen[4]);
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			cargar_vectores();
			cargar_PictureBoxs();
			
		}
		
//		void Pic1Click(object sender, EventArgs e)
//		{
//			
//			pic_central.Image=pic1.Image;
//			
//		}
		void Funcion_Click(object sender, EventArgs e)
		{
			PictureBox pic_aux;
			pic_aux=(PictureBox)sender;
			pic_central.Image=pic_aux.Image;
		}
	}
}