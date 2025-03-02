using AppTimer.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppTimer
{
    public partial class Form1 : Form
    {
        public abstract class ObjetoMovible
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int SpeedX { get; set; }
            public int SpeedY { get; set; }
            public PictureBox PictureBox { get; set; }

            public ObjetoMovible(int x, int y, int speedX, int speedY, PictureBox pictureBox)
            {
                X = x;
                Y = y;
                SpeedX = speedX;
                SpeedY = speedY;
                PictureBox = pictureBox;
            }

            // Método para mover el objeto
            public virtual void Mover(Form form)
            {
                X += SpeedX;
                Y += SpeedY;
                PictureBox.Location = new Point(X, Y); // Actualizar la posición del PictureBox
                form.Refresh(); // Forzar la actualización del formulario
                Console.WriteLine($"Posición de {PictureBox.Name}: X = {X}, Y = {Y}");
            }

            // Método para verificar colisiones con otro objeto
            public bool ColisionaCon(ObjetoMovible otro)
            {
                return PictureBox.Bounds.IntersectsWith(otro.PictureBox.Bounds);
            }
        }

        public class Lebron : ObjetoMovible
        {
            public Lebron(int x, int y, int speedX, PictureBox pictureBox)
                : base(x, y, speedX, 0, pictureBox)
            {
                pictureBox.Name = "picLebron"; // Asignar un nombre para depuración
            }

            public override void Mover(Form form)
            {
                base.Mover(form);

                // Rebotar en los bordes horizontales
                if (X <= 0 || X >= form.ClientSize.Width - PictureBox.Width)
                {
                    SpeedX = -SpeedX;
                }
            }
        }

        public class Jordan : ObjetoMovible
        {
            public Jordan(int x, int y, int speedY, PictureBox pictureBox)
                : base(x, y, 0, speedY, pictureBox)
            {
                pictureBox.Name = "picJordan"; // Asignar un nombre para depuración
            }

            public override void Mover(Form form)
            {
                base.Mover(form);

                // Detener el movimiento si llega a la parte superior
                if (Y <= 0)
                {
                    SpeedY = 0; // Detener el movimiento
                    form.Controls.Remove(PictureBox);
                    PictureBox.Dispose();
                }
            }
        }

        private Lebron lebron;
        private Jordan jordan;

        public Form1()
        {
            InitializeComponent();

            // Configurar el Timer
            tmrDesplazar.Interval = 50; // Intervalo en milisegundos

            // Crear el objeto Lebron
            PictureBox picLebron = new PictureBox
            {
                Image = Resources.imgLebron,
                SizeMode = PictureBoxSizeMode.AutoSize,
                Location = new Point(10, 20)
            };
            picLebron.BringToFront(); // Asegurar que esté al frente

            lebron = new Lebron(10, 20, 5, picLebron);

            // Crear el objeto Jordan
            PictureBox picJordan = new PictureBox
            {
                Image = Resources.imgJordan,
                SizeMode = PictureBoxSizeMode.AutoSize,
                Location = new Point(100, this.ClientSize.Height - 50)
            };
            picJordan.BringToFront(); // Asegurar que esté al frente

            jordan = new Jordan(100, this.ClientSize.Height - 50, -5, picJordan);
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            tmrDesplazar.Enabled = true; // Activar el Timer
        }

        private void tmrDesplazar_Tick(object sender, EventArgs e)
        {
            lebron.Mover(this);
            jordan.Mover(this);

            // Verificar colisión entre Lebron y Jordan
            if (lebron.ColisionaCon(jordan))
            {
                this.Controls.Remove(lebron.PictureBox);
                this.Controls.Remove(jordan.PictureBox);
                lebron.PictureBox.Dispose();
                jordan.PictureBox.Dispose();
                tmrDesplazar.Enabled = false; // Detener el Timer
            }
        }
    }
}