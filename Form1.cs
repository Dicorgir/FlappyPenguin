using System;
using System.Drawing;
using System.Windows.Forms;

namespace FlappyPenguin
{
    public partial class Form1 : Form
    {
        // Declaración de variables
        int ContadorMovimiento = 1;  // Contador para la animación del jugador
        bool VolarArriba = false;   // Bandera para controlar el vuelo hacia arriba del jugador
        int Distancia = 0;   // Distancia inicial de los tubos respecto al borde superior del formulario
        Random PosicionRandom = new Random();   // Generador de números aleatorios para posiciones de tubos
        int distanciaEntreTubos = 150; // Espacio vertical entre los tubos
        bool haPasadoElTubo = false; // Bandera para controlar si el jugador ha pasado completamente el tubo

        // Velocidad inicial y máxima del jugador
        int velocidadHorizontal = 3;
        int velocidadMaxima = 6;

        // Constructor de la clase Form1
        public Form1()
        {
            InitializeComponent();  // Inicializa los componentes del formulario
            this.KeyPreview = true;  // Permite que el formulario maneje los eventos de teclado directamente
            IniciarJuego();  // Inicia el juego configurando los componentes y variables

            // Configuración del formulario
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Borde del formulario fijo
            this.MaximizeBox = false; // Botón de maximizar deshabilitado
            this.MinimizeBox = false; // Botón de minimizar deshabilitado
        }

        // Método para inicializar el juego
        public void IniciarJuego()
        {
            Player.Location = new Point(19, 225); // Posición inicial del jugador
            // Genera un valor aleatorio para la posición vertical de los tubos
            Distancia = PosicionRandom.Next(50, this.ClientSize.Height - distanciaEntreTubos - 50);
            TuboArriba.Location = new Point(270, -173 - Distancia); // Posición inicial del tubo superior
            TuboAbajo.Location = new Point(270, TuboArriba.Location.Y + TuboArriba.Height + distanciaEntreTubos); // Posición inicial del tubo inferior
            Puntaje.Text = "0"; // Inicializa el puntaje en cero
            haPasadoElTubo = false; // Reinicia la bandera de control de paso de tubo al iniciar juego
            velocidadHorizontal = 3; // Reinicia la velocidad horizontal al inicio del juego
        }

        // Método que se ejecuta cada cierto intervalo de tiempo (timer1_Tick)
        private void timer1_Tick(object sender, EventArgs e)
        {
            int CantidadMovimientos = 5; // Número de imágenes en la animación del jugador

            // Lógica para cambiar la imagen del jugador según el contador de movimientos
            if (ContadorMovimiento <= CantidadMovimientos)
            {
                Player.Image = Properties.Resources.pinguino1;
                ContadorMovimiento++;
            }
            if ((ContadorMovimiento > CantidadMovimientos / 2) && (ContadorMovimiento <= CantidadMovimientos * 2))
            {
                Player.Image = Properties.Resources.pinguino1;
                ContadorMovimiento++;
            }
            ContadorMovimiento = (ContadorMovimiento > CantidadMovimientos * 2) ? 0 : ContadorMovimiento;

            int ly = Player.Location.Y; // Posición vertical actual del jugador

            // Lógica para el movimiento vertical del jugador
            if (VolarArriba)
            {
                ly = ly - 15; // Mueve hacia arriba cuando VolarArriba es true
                VolarArriba = false; // Reinicia la bandera después de mover hacia arriba
            }
            else
            {
                ly += 2; // Incremento de posición hacia abajo (gravedad simulada)
            }

            // Limita el movimiento del jugador dentro del formulario
            ly = Math.Max(0, Math.Min(this.ClientSize.Height - Player.Height, ly));
            Player.Location = new Point(Player.Location.X, ly);

            // Verifica colisiones con los elementos del juego y reinicia el juego si hay colisión
            if (Player.Bounds.IntersectsWith(Barrera.Bounds) || Player.Bounds.IntersectsWith(TuboArriba.Bounds) || Player.Bounds.IntersectsWith(TuboAbajo.Bounds))
            {
                IniciarJuego();
            }

            Puntaje.Location = new Point(Player.Location.X + 30, Player.Location.Y - 25); // Posición del texto de puntaje

            // Incrementa la puntuación si el jugador pasa completamente el tubo
            if (Player.Right >= TuboArriba.Left && Player.Left <= TuboArriba.Right)
            {
                if (!haPasadoElTubo)
                {
                    Puntaje.Text = (int.Parse(Puntaje.Text) + 1).ToString();
                    haPasadoElTubo = true;
                }
            }
            else
            {
                haPasadoElTubo = false;
            }

            // Aumenta la velocidad horizontal del juego progresivamente
            if (velocidadHorizontal < velocidadMaxima)
            {
                velocidadHorizontal += 1; // Ajustable según preferencia
            }
        }

        // Evento de tecla presionada en el formulario
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                VolarArriba = true; // Activa el vuelo hacia arriba cuando se presiona la tecla Espacio
            }
        }

        // Timer para mover los tubos horizontalmente
        private void timer2_Tick(object sender, EventArgs e)
        {
            // Mueve los tubos hacia la izquierda mientras estén dentro de los límites del formulario
            if (TuboAbajo.Location.X > -TuboAbajo.Width)
            {
                TuboAbajo.Location = new Point(TuboAbajo.Location.X - velocidadHorizontal, TuboAbajo.Location.Y);
                TuboArriba.Location = new Point(TuboArriba.Location.X - velocidadHorizontal, TuboArriba.Location.Y);
            }
            else
            {
                // Reposiciona los tubos y genera nueva posición vertical para el próximo paso
                Distancia = PosicionRandom.Next(50, this.ClientSize.Height - distanciaEntreTubos - 50);
                TuboArriba.Location = new Point(this.ClientSize.Width, -173 - Distancia);
                TuboAbajo.Location = new Point(this.ClientSize.Width, TuboArriba.Location.Y + TuboArriba.Height + distanciaEntreTubos);
            }
        }

        // Timer para mover la barrera horizontalmente (en caso de que haya una)
        private void timer3_Tick(object sender, EventArgs e)
        {
            // Mueve la barrera hacia la izquierda mientras esté dentro de los límites del formulario
            Barrera.Location = (Barrera.Location.X > -Barrera.Width) ? new Point(Barrera.Location.X - velocidadHorizontal, Barrera.Location.Y) : new Point(this.ClientSize.Width, Barrera.Location.Y);
        }
    }
}
