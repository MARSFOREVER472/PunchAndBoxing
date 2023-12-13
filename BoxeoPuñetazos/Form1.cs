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

            // AHORA PROCEDEREMOS A QUE EL BOXEADOR CONSTE DE BARRA DE SALUD AL MOVERSE.

            // PARA EL JUGADOR Y EL ENEMIGO LO AJUSTAREMOS A LA BARRA DE SALUD MAYORES QUE 1.

            // PARA EL JUGADOR:

            if (saludJugador > 1)
            {
                energiaJugador.Value = saludJugador;
            }

            // PARA EL ENEMIGO:

            if (saludEnemigo > 1)
            {
                energiaCPU.Value = saludEnemigo;
            }

            // EL BOXEADOR SE MUEVE DE MANERA DINÁMICA EN EL CASO DEL ENEMIGO (mikeTyson).

            mikeTyson.Left += velocidadEnemigo;

            // DEPENDIENDO DE LA POSICIÓN HORIZONTAL DEL ENEMIGO SU VELOCIDAD VA A VARIAR DE IZQUIERDA A DERECHA.

            if (mikeTyson.Left > 430)
            {
                velocidadEnemigo = -5;
            }

            if (mikeTyson.Left < 220)
            {
                velocidadEnemigo = 5;
            }

            // LOS MENSAJES DEL FIN DE LA PARTIDA SE MUESTRAN EN MEDIO DEL ESCENARIO DEL JUEGO (ENVIAR AL FONDO PARA EL JUGADOR Y EL ENEMIGO).

            if (saludEnemigo < 1) // SI LA SALUD DEL ENEMIGO ES MÍNIMO EN 0.
            {
                ataqueBoxeador.Stop(); // PARALIZA EL TEMPORIZADOR DE LOS ATAQUES DE UN BOXEADOR CUALQUIERA.
                movimientoBoxeador.Stop(); // PARALIZA EL TEMPORIZADOR DE LOS MOVIMIENTOS DE UN BOXEADOR CUALQUIERA.
                MessageBox.Show("HAS GANADO LA PARTIDA, FELICITACIONES!!!!! :)");
                ReiniciarJuego();
            }

            if (saludJugador < 1) // SI LA SALUD DEL Jugador ES MÍNIMO EN 0.
            {
                ataqueBoxeador.Stop(); // PARALIZA EL TEMPORIZADOR DE LOS ATAQUES DE UN BOXEADOR CUALQUIERA.
                movimientoBoxeador.Stop(); // PARALIZA EL TEMPORIZADOR DE LOS MOVIMIENTOS DE UN BOXEADOR CUALQUIERA.
                MessageBox.Show("HAS PERDIDO LA PARTIDA, INTÉNTALO NUEVAMENTE!!!!! :(");
                ReiniciarJuego();
            }
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

        private void ReiniciarJuego()
        {
            // EVENTO PARA QUE EL JUGADOR REINICIE UNA PARTIDA.

            // EN INSTANTES...
        }
    }
}