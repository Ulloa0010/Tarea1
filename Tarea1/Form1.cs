
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class Form1 : Form
    {
        Random azar = new Random();

        int modo = 0;
        int jugador = 0;
        int nivel = 1;
        int vidas = 3;
        int turnos = 0;

        int numero1, numero2, resultado;
        char operador;

        string[] nombres = new string[2];
        int[] aciertos = new int[2];
        int[] fallos = new int[2];

        string[] historialNombres = new string[100];
        int[] historialPuntos = new int[100];
        int cantidad = 0;

        Label tituloClasificacion;
        DataGridView tabla;

        public Form1()
        {
            InitializeComponent();

            pjuego.Location = pconfiguracion.Location;
            presultados.Location = pconfiguracion.Location;
            pjuego.Size = pconfiguracion.Size;
            presultados.Size = pconfiguracion.Size;

            pconfiguracion.Visible = true;
            pjuego.Visible = false;
            presultados.Visible = false;

            bindividual.Click -= bindividual_Click;
            bindividual.Click += bindividual_Click;

            bdosjugadores.Click -= bdosjugadores_Click;
            bdosjugadores.Click += bdosjugadores_Click;

            biniciar.Click -= biniciar_Click;
            biniciar.Click += biniciar_Click;

            bcomprobar.Click -= bcomprobar_Click;
            bcomprobar.Click += bcomprobar_Click;

            lnivel.Text = "0";
            laciertos.Text = "0";
            lfallos.Text = "0";
            lvidas.Text = "3";

            lnombre2.Visible = false;
            tnombre2.Visible = false;

            CrearTabla();
        }

        private void bindividual_Click(object sender, EventArgs e)
        {
            modo = 1;

            lnombre2.Visible = false;
            tnombre2.Visible = false;
        }

        private void bdosjugadores_Click(object sender, EventArgs e)
        {
            modo = 2;

            lnombre2.Visible = true;
            tnombre2.Visible = true;
        }

        private void biniciar_Click(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                MessageBox.Show("Seleccioná un modo de juego.");
                return;
            }

            if (tnombre1.Text.Trim() == "")
            {
                MessageBox.Show("Escribí el nombre del jugador 1.");
                tnombre1.Focus();
                return;
            }

            nombres[0] = tnombre1.Text.Trim();
            nombres[1] = "";

            if (modo == 2)
            {
                if (tnombre2.Text.Trim() == "")
                {
                    MessageBox.Show("Escribí el nombre del jugador 2.");
                    tnombre2.Focus();
                    return;
                }

                if (tnombre1.Text.Trim().ToLower() ==
                    tnombre2.Text.Trim().ToLower())
                {
                    MessageBox.Show("Los nombres deben ser diferentes.");
                    return;
                }

                nombres[1] = tnombre2.Text.Trim();
            }

            aciertos[0] = 0;
            aciertos[1] = 0;
            fallos[0] = 0;
            fallos[1] = 0;

            vidas = 3;
            jugador = 0;
            nivel = 1;
            turnos = 0;

            laciertos.Text = "0";
            lfallos.Text = "0";
            lnivel.Text = "1";
            lvidas.Text = "3";

            lturno.Visible = modo == 2;
            lnombreturno.Visible = modo == 2;

            labelvidas.Visible = modo == 1;
            lvidas.Visible = modo == 1;

            pconfiguracion.Visible = false;
            presultados.Visible = false;
            pjuego.Visible = true;

            MostrarTurno();
            NuevaOperacion();
        }

        private void NuevaOperacion()
        {
            int maximo = 10 + (nivel - 1) * 5;

            if (maximo > 100)
            {
                maximo = 100;
            }

            int tipo = azar.Next(1, 5);

            numero1 = azar.Next(1, maximo + 1);
            numero2 = azar.Next(1, maximo + 1);

            if (nivel < 3 && tipo == 4)
            {
                tipo = 1;
            }

            if (tipo == 1)
            {
                operador = '+';
                resultado = numero1 + numero2;
            }
            else if (tipo == 2)
            {
                operador = '-';
                resultado = numero1 - numero2;
            }
            else if (tipo == 3)
            {
                operador = '*';
                resultado = numero1 * numero2;
            }
            else
            {
                operador = '/';
                resultado = azar.Next(1, maximo + 1);
                numero1 = numero2 * resultado;
            }

            lnum1.Text = numero1.ToString();
            lop.Text = operador.ToString();
            lnum2.Text = numero2.ToString();

            tresultado.Text = "";
            tresultado.Focus();
        }

        private void bcomprobar_Click(object sender, EventArgs e)
        {
            int respuesta;

            if (!int.TryParse(tresultado.Text, out respuesta))
            {
                MessageBox.Show("Escribí una respuesta numérica válida.");
                tresultado.Focus();
                return;
            }

            if (respuesta == resultado)
            {
                aciertos[jugador]++;
                MessageBox.Show("¡Correcto!");

                if (aciertos[jugador] % 3 == 0)
                {
                    nivel++;
                    lnivel.Text = nivel.ToString();

                    MessageBox.Show("¡Subiste al nivel " + nivel + "!");
                }
            }
            else
            {
                fallos[jugador]++;

                MessageBox.Show(
                    "Incorrecto. La respuesta era " + resultado + ".");

                if (modo == 1)
                {
                    vidas--;
                    lvidas.Text = vidas.ToString();
                }
            }

            if (modo == 1 && vidas <= 0)
            {
                FinalizarPartida();
                return;
            }

            if (modo == 2)
            {
                turnos++;

                if (turnos >= 10)
                {
                    FinalizarPartida();
                    return;
                }

                jugador = 1 - jugador;
                MostrarTurno();
            }

            laciertos.Text = aciertos[jugador].ToString();
            lfallos.Text = fallos[jugador].ToString();

            NuevaOperacion();
        }

        private void MostrarTurno()
        {
            if (modo == 2)
            {
                lnombreturno.Text = nombres[jugador];
            }

            laciertos.Text = aciertos[jugador].ToString();
            lfallos.Text = fallos[jugador].ToString();
        }

        private void FinalizarPartida()
        {
            pjuego.Visible = false;
            pconfiguracion.Visible = false;
            presultados.Visible = true;

            GuardarPuntos();
            MostrarClasificacion();
        }

        private void GuardarPuntos()
        {
            int cantidadJugadores = 1;

            if (modo == 2)
            {
                cantidadJugadores = 2;
            }

            for (int i = 0; i < cantidadJugadores; i++)
            {
                if (cantidad < 100)
                {
                    historialNombres[cantidad] = nombres[i];
                    historialPuntos[cantidad] = aciertos[i];
                    cantidad++;
                }
            }
        }

        private void CrearTabla()
        {
            tituloClasificacion = new Label();

            tituloClasificacion.Text = "CLASIFICACIÓN";
            tituloClasificacion.AutoSize = true;
            tituloClasificacion.Location = new Point(10, 50);

            tabla = new DataGridView();

            tabla.Location = new Point(10, 80);
            tabla.Size = new Size(
                Math.Max(200, presultados.Width - 20), 150);

            tabla.ReadOnly = true;
            tabla.AllowUserToAddRows = false;
            tabla.AllowUserToDeleteRows = false;
            tabla.RowHeadersVisible = false;
            tabla.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            tabla.Columns.Add("posicion", "Posición");
            tabla.Columns.Add("nombre", "Jugador");
            tabla.Columns.Add("puntos", "Aciertos");

            presultados.Controls.Add(tituloClasificacion);
            presultados.Controls.Add(tabla);
        }

        private void MostrarClasificacion()
        {
            string[] nombresOrdenados = new string[cantidad];
            int[] puntosOrdenados = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                nombresOrdenados[i] = historialNombres[i];
                puntosOrdenados[i] = historialPuntos[i];
            }

            for (int i = 0; i < cantidad - 1; i++)
            {
                for (int j = 0; j < cantidad - 1 - i; j++)
                {
                    if (puntosOrdenados[j] < puntosOrdenados[j + 1])
                    {
                        int puntos = puntosOrdenados[j];
                        puntosOrdenados[j] = puntosOrdenados[j + 1];
                        puntosOrdenados[j + 1] = puntos;

                        string nombre = nombresOrdenados[j];
                        nombresOrdenados[j] = nombresOrdenados[j + 1];
                        nombresOrdenados[j + 1] = nombre;
                    }
                }
            }

            tabla.Rows.Clear();

            for (int i = 0; i < cantidad; i++)
            {
                tabla.Rows.Add(
                    i + 1,
                    nombresOrdenados[i],
                    puntosOrdenados[i]);
            }
        }
    }
}
