using System.Collections.Generic;

namespace BoxeoPuñetazos
{
    public partial class Form1 : Form
    {
        // VARIABLES A DECLARAR EN ESTA CLASE.

        bool bloqueoJugador = false; // SI EL JUGADOR (Padalustro) UTILIZA O NO UN ESCUDO DE PROTECCIÓN CON AMBOS GUANTES.
        bool bloqueoEnemigo = false; // SI EL RIVAL (Mike Tyson) UTILIZA O NO UN ESCUDO DE PROTECCIÓN CON AMBOS GUANTES.
        Random rnd = new Random(); // VARIABLE ALEATORIA.
        int velocidadEnemigo = 5; // LA VELOCIDAD DEL ENEMIGO SE ACELERARÁ 5 VECES.
        int index = 0; // ÍNDICE INICIAL DEL JUEGO POR DEFECTO.
        int saludEnemigo = 275; // SALUD DEL ENEMIGO.
        int saludJugador = 275; // SALUD DEL JUGADOR.
        List<string> ataqueEnemigo = new List<string> { "izquierda", "derecha", "bloqueo" }; // TIENE QUE DEPENDER DE LOS ATAQUES EN QUE EL ENEMIGO PUEDE EFECTUARSE AUTOMÁTICAMENTE.

        public Form1()
        {
            InitializeComponent();
        }

        private void EventoTemporizadorAtaqueBoxeador(object sender, EventArgs e)
        {
            // ESTE ES UN EVENTO PARA EL ATAQUE DE UN BOXEADOR CUALQUIERA.

            // EN INSTANTES...
        }

        private void EventoTemporizadorMovimientoBoxeador(object sender, EventArgs e)
        {
            // ESTE ES UN EVENTO PARA EL MOVIMIENTO DE UN BOXEADOR CUALQUIERA.

            // EN INSTANTES...
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            // EVENTO EN CUANDO EL JUGADOR (Padalustro) PRESIONE CUALQUIER TECLA AL JUGAR.

            // EN INSTANTES...
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            // EVENTO EN CUANDO EL JUGADOR (Padalustro) SUELTA CUALQUIER TECLA AL JUGAR.

            // EN INSTANTES...
        }
    }
}