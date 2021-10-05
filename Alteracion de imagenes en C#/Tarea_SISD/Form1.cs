//***** Created by: BlackHope (CT) *****//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Tarea_SISD
{
    public partial class Form1 : Form
    {
        bool conv = false, resol = false; //Variables: conv =Blanco y negro Resol= Aumento de resolucion
        string dir_inicial = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Wallpapers"; //Obtener imagen
        public Form1()
        {
            InitializeComponent(); //Llamado de metodos y uso de los eventos en los bonotes
            btnconvbl.Click += (s, e) => pbblanconegro.Image = blancoynegro();
            btnconvresol.Click += (s, e) => pb_resol.Image = resolucion();
          
            btnabrir.Click += (s, e) => //Abrir archivos usando el direccionador de windows
            {
                OpenFileDialog of = new OpenFileDialog() { Filter = "Imágenes|*.jpg;*.png;*.bmp", InitialDirectory = dir_inicial }; //Abrir archivos
                if (of.ShowDialog() == DialogResult.OK)
                {
                    pb.Image = Image.FromFile(of.FileName);
                    pbblanconegro.Image = pb_resol.Image = null;
                    conv = resol = false;
                    btnabrir.Text = $"Abrir ({pb.Image.Width}x{pb.Image.Height})"; //Obtener la resolucion y mostrarla por windows
                }
            };
            btnguardarbl.Click += (s, e) => //Llamar metodo para guardar imagenes en BN
            {
                pbblanconegro.Image = blancoynegro();
                SaveFileDialog sf = new SaveFileDialog() { Filter = "JPG|*.jpg|PNG|*.png|BMP|*.bmp", InitialDirectory = dir_inicial };
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    pbblanconegro.Image.Save(sf.FileName);
                    Process.Start(sf.FileName);
                }
            };
            btnguardares.Click += (s, e) => //Llamar metodo para guardar imagenes con resolucion aumentada
            {
                pb_resol.Image = resolucion();
                SaveFileDialog sf = new SaveFileDialog() { Filter = "JPG|*.jpg|PNG|*.png|BMP|*.bmp", InitialDirectory = dir_inicial };
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    pb_resol.Image.Save(sf.FileName);
                 //Process.Start(sf.FileName);
                }
            };
        }
        Image blancoynegro() //Metodo para convertir imagenes a blanco y negro
        {
            if (!conv)
            {
                Bitmap bm = new Bitmap(pb.Image); // BitMap para alterar y filtrar los bits de las imagenes para cambiarlas
                progres.Maximum = bm.Width * bm.Height;
                for (int x = 0; x < bm.Width; x++)
                    for (int y = 0; y < bm.Height; y++)
                    {
                        Color c = bm.GetPixel(x, y);
                        int intensidad = (c.R + c.G + c.B) / 3;
                        Color nuevo = Color.FromArgb(intensidad, intensidad, intensidad);
                        bm.SetPixel(x, y, nuevo);
                        progres.Value++;
                    }
                conv = true;
                progres.Value = 0;
                return bm;
            }
            return pbblanconegro.Image;
        }
        Image resolucion() //Metodo para obtener la maxima resolucion posible de una imagen
        {
            if (!resol)
            {
                var destImage = new Bitmap(pb.Image);
                var destRect = new Rectangle(0, 0, destImage.Width, destImage.Height);
                destImage.SetResolution(destImage.HorizontalResolution, destImage.VerticalResolution);

                using (var graphics = Graphics.FromImage(destImage)) //Graphics para aumentar la resolucion de las imagenes 
                {
                    graphics.CompositingMode = CompositingMode.SourceCopy;
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    using (var wrapMode = new ImageAttributes()) //Atributo para retorna una imagen
                    {
                        wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                        graphics.DrawImage(pb.Image, destRect, 0, 0, destRect.Width, destRect.Height, GraphicsUnit.Pixel, wrapMode);
                    }
                }
                resol = true;
                progres.Value = 0;
                return destImage;
            }
            return pb_resol.Image;
        }
    }
}