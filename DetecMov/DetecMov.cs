// Bibliotecas por defecto.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Bibliotecas de vídeo.
using AForge.Video;
using AForge.Video.DirectShow;
// Biblioteca de controles de AForge.
using AForge.Controls;
// Biblitecas de detencción.
using AForge.Vision.Motion;
// Biblioteca de imagen y figuras geometricas.
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math.Geometry;

namespace DetecMov
{
    public partial class DeteMov : Form
    {
        public DeteMov()
        {
            InitializeComponent();
            btnCapturar.Enabled = false;
            btnDetener.Enabled = false;
            btnCapturarColor.Enabled = false;
            btnDetenerColor.Enabled = false;
            btnColor.Enabled = false;
            gbTiposDetec.Enabled = false;
            gbColor.Enabled = false;
            gbTipoVision.Enabled = false;
            txtDetcMov.Enabled = false;
        }

        // Este método es para bloquear el botón de salir del Form.
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                parms.ClassStyle |= 0x200;
                return parms;
            }
        }

        // Variable para lista los dispositivos (Cámaras).
        private FilterInfoCollection Dispositivos, DispositivosColor;
        // Variable para dispositivo que usaremos como fuente.
        private VideoCaptureDevice FuenteDeVideo, FuenteDeVideoColor = null;
        // Variable de color para el color de los objetos.
        private Color color;   
        
        // Variable para detencción.
        MotionDetector Detector01, Detector02, Detector03, Detector04, Detector05, Detector06, Detector07, Detector08,
            Detector09, Detector10, Detector11, Detector12;

        private float NivelDetenccion, matiz;

        private void DeteMov_Load(object sender, EventArgs e)
        {
            // Inicializa variables de detenctor.
            Detector01 = new MotionDetector(new CustomFrameDifferenceDetector(), new BlobCountingObjectsProcessing());
            Detector02 = new MotionDetector(new CustomFrameDifferenceDetector(), new GridMotionAreaProcessing());
            Detector03 = new MotionDetector(new CustomFrameDifferenceDetector(), new MotionAreaHighlighting());
            Detector04 = new MotionDetector(new CustomFrameDifferenceDetector(), new MotionBorderHighlighting());

            Detector05 = new MotionDetector(new SimpleBackgroundModelingDetector(), new BlobCountingObjectsProcessing());
            Detector06 = new MotionDetector(new SimpleBackgroundModelingDetector(), new GridMotionAreaProcessing());
            Detector07 = new MotionDetector(new SimpleBackgroundModelingDetector(), new MotionAreaHighlighting());
            Detector08 = new MotionDetector(new SimpleBackgroundModelingDetector(), new MotionBorderHighlighting());

            Detector09 = new MotionDetector(new TwoFramesDifferenceDetector(), new BlobCountingObjectsProcessing());
            Detector10 = new MotionDetector(new TwoFramesDifferenceDetector(), new GridMotionAreaProcessing());
            Detector11 = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionAreaHighlighting());
            Detector12 = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionBorderHighlighting());;

            NivelDetenccion = 0;
            // Lista los dispositivos de entrada de vídeo.
            Dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            // Dispositivo tiene un array, con todos los dispositivos disponibles.
            foreach(FilterInfo i in Dispositivos)
            {
                cbCamara.Items.Add(i.Name);
            }
            cbCamara.SelectedIndex = 0;

            DispositivosColor = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo x in DispositivosColor)
            {
                cbCamaraColor.Items.Add(x.Name);
            }
            cbCamaraColor.SelectedIndex = 0;
        }
        
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // Establecer el dispositivo seleccionado como fuente de vídeo.
            FuenteDeVideo = new VideoCaptureDevice(Dispositivos[cbCamara.SelectedIndex].MonikerString);
            // Inicializar el control. vspCamara es un evento de AForge.
            vspCamara.VideoSource = FuenteDeVideo;
            // Inicializar la recepción de imagenes.
            vspCamara.Start();
            btnCapturar.Enabled = true;
            btnIniciar.Enabled = false;
            btnDetener.Enabled = true;
            gbTiposDetec.Enabled = true;
        }

        private void btnIniciarColor_Click(object sender, EventArgs e)
        {
            FuenteDeVideoColor = new VideoCaptureDevice(DispositivosColor[cbCamaraColor.SelectedIndex].MonikerString);
            FuenteDeVideoColor.NewFrame += new NewFrameEventHandler(vspCamaraColor_NewFrame);
            FuenteDeVideoColor.Start();
            btnIniciarColor.Enabled = false;
            btnCapturarColor.Enabled = true;
            btnDetenerColor.Enabled = true;
            btnColor.Enabled = true;
            btnSalirColor.Enabled = true;
            cbActivarColor.Enabled = false;
            gbTipoVision.Enabled = true;
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            // Detener la recepción de imagenes.
            vspCamara.SignalToStop();
            btnCapturar.Enabled = false;
            btnIniciar.Enabled = true;
            btnDetener.Enabled = false;
            gbTiposDetec.Enabled = false;
        }

        private void btnDetenerColor_Click(object sender, EventArgs e)
        {
            FuenteDeVideoColor.Stop();
            btnIniciarColor.Enabled = true;
            btnCapturarColor.Enabled = false;
            btnDetenerColor.Enabled = false;
            btnColor.Enabled = false;
            cbActivarColor.Enabled = true;
            gbTipoVision.Enabled = false;
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            // Dialogo para seleccionar la ruta para guardar.
            SaveFileDialog guardarFoto = new SaveFileDialog()
            {
                Filter = "Imagen jpg|*.jpg",
                InitialDirectory = @"C:\Users\Desktop"
            };

            // Genera la ventana para aguardar la imagen.
            if (guardarFoto.ShowDialog() == DialogResult.OK)
            {
                // Variable para la imagen.
                Bitmap img = vspCamara.GetCurrentVideoFrame();
                img.Save(guardarFoto.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                // Borrar Imagen de memoria.
                img.Dispose();
            }
        }

        private void btnCapturarColor_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarImagen = new SaveFileDialog()
            {
                Filter = "Imagen jpg|*.jpg",
                InitialDirectory = @"C:\Users\Desktop"
            };

            if (guardarImagen.ShowDialog() == DialogResult.OK)
            {
                pbCamaraColor.Image.Save(guardarImagen.FileName);
            }
        }

        private void vspCamara_NewFrame(object sender, ref Bitmap image)
        {
            // Procesa el movimiento en tiempo real.
            if (rbDetector1.Checked)
            {
                NivelDetenccion = Detector01.ProcessFrame(image);
            }
            else if (rbDetector2.Checked)
            {
                NivelDetenccion = Detector02.ProcessFrame(image);
            }
            else if (rbDetector3.Checked)
            {
                NivelDetenccion = Detector03.ProcessFrame(image);
            }
            else if (rbDetector4.Checked)
            {
                NivelDetenccion = Detector04.ProcessFrame(image);
            }
            else if (rbDetector5.Checked)
            {
                NivelDetenccion = Detector05.ProcessFrame(image);
            }
            else if (rbDetector6.Checked)
            {
                NivelDetenccion = Detector06.ProcessFrame(image);
            }
            else if (rbDetector7.Checked)
            {
                NivelDetenccion = Detector07.ProcessFrame(image);
            }
            else if (rbDetector8.Checked)
            {
                NivelDetenccion = Detector08.ProcessFrame(image);
            }
            else if (rbDetector9.Checked)
            {
                NivelDetenccion = Detector09.ProcessFrame(image);
            }
            else if (rbDetector10.Checked)
            {
                NivelDetenccion = Detector10.ProcessFrame(image);
            }
            else if (rbDetector11.Checked)
            {
                NivelDetenccion = Detector11.ProcessFrame(image);
            }
            else
            {
                NivelDetenccion = Detector12.ProcessFrame(image);
            }
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            // Nivel de detencción.
            txtDetcMov.Text = String.Format("{0:00.0000}", NivelDetenccion);
        }

        private void vspCamaraColor_NewFrame(object sender, NewFrameEventArgs e)
        {
            Bitmap video = (Bitmap)e.Frame.Clone();
            // Creo un vídeo clon.
            Bitmap temp = video.Clone() as Bitmap;
            // Creo filtro de color en el vídeo de dialogo.
            EuclideanColorFiltering filter = new EuclideanColorFiltering();
            // Doy valores con el cuadro de dialogo.
            filter.CenterColor = new AForge.Imaging.RGB(color.R, color.G, color.B);
            filter.Radius = 90;
            // Aplico el filtro.
            filter.ApplyInPlace(temp);

            // BlobCounter es una clase que se usa para distinguir objetos, colores, etc;
            BlobCounter objeto = new BlobCounter();
            objeto.MinWidth = 5; // Anchura.
            objeto.MinHeight = 5; // Altura.
            objeto.FilterBlobs = true; // Sombras.
            objeto.ObjectsOrder = ObjectsOrder.Size; // Tamaño.
            objeto.ProcessImage(temp);

            Rectangle[] rects = objeto.GetObjectsRectangles();
            foreach (Rectangle recs in rects)
            {
                if (rects.Length > 0)
                {
                    Rectangle objectRect = rects[0];
                    Graphics grafico = Graphics.FromImage(video);
                    using (Pen lapiz = new Pen(Color.FromArgb(160, 255, 160), 5))
                    {
                        grafico.DrawRectangle(lapiz, objectRect);
                    }
                    grafico.Dispose();
                }
            }
            if (rbOriginal.Checked)
            {
                pbCamaraColor.Image = video;
            }
            else
            {
                pbCamaraColor.Image = temp;
            }
        }

        public Rectangle objectRect { get; set; }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorD.ShowDialog();
            color = (Color)colorD.Color;
            matiz = color.GetHue();
        }

        private void cbActivarColor_CheckedChanged(object sender, EventArgs e)
        {
            if (cbActivarColor.Checked)
            {
                gbColor.Enabled = true;
                btnIniciar.Enabled = true;
                btnDetener.Enabled = false;
                btnCapturar.Enabled = false;
                btnSalirColor.Enabled = false;
                cbActivarColor.Enabled = false;
                gbTipoVision.Enabled = false;
                vspCamara.SignalToStop();
            }
            else
            {
                gbColor.Enabled = false;
                btnIniciarColor.Enabled = true;
                btnDetenerColor.Enabled = false;
                btnCapturarColor.Enabled = false;
                btnColor.Enabled = false;
                FuenteDeVideoColor.Stop();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("¿Desea salir de la aplicación?", "Salir de la aplicación", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resultado == System.Windows.Forms.DialogResult.Yes)
            {
                vspCamara.SignalToStop();
                this.Close();
            }
        }

        private void btnSalirColor_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("¿Desea salir de la aplicación?", "Salir de la aplicación",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                FuenteDeVideoColor.Stop();
                this.Close();
            }
        }
    }
}