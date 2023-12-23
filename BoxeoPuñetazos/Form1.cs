using System.Collections.Generic;
using System.Media;

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
        int saludEnemigo = 100; // SALUD DEL ENEMIGO.
        int saludJugador = 100; // SALUD DEL JUGADOR.
        List<string> ataqueEnemigo = new List<string> { "izquierda", "derecha", "bloqueo" }; // TIENE QUE DEPENDER DE LOS ATAQUES EN QUE EL ENEMIGO PUEDE EFECTUARSE AUTOMÁTICAMENTE.

        public Form1()
        {
            InitializeComponent();
        }

        private void EventoTemporizadorAtaqueBoxeador(object sender, EventArgs e)
        {
            // ESTE ES UN EVENTO PARA EL ATAQUE DE UN BOXEADOR CUALQUIERA.

            // PARA QUE UN BOXEADOR CUALQUIERA PUEDA ATACAR HACIA LA IZQUIERDA, HACIA LA DERECHA, O BLOQUEA COMO UN ESCUDO PROTECTOR, USAREMOS LA ITERACIÓN "switch".

            index = rnd.Next(0, ataqueEnemigo.Count); // EL CONTEO DE ATAQUES DEL ENEMIGO HACIA EL JUGADOR PUEDE VARIAR.

            // PROCEDEREMOS A LOS ATAQUES DEL ENEMIGO HACIA EL JUGADOR.

            switch (ataqueEnemigo[index].ToString())
            {
                case "izquierda": // EN CASO DE QUE EL ENEMIGO PUEDA ATACAR AL JUGADOR HACIA LA IZQUIERDA.
                    mikeTyson.Image = Properties.Resources.enemy_punch1; // EL ENEMIGO ATACA HACIA LA IZQUIERDA.
                    bloqueoEnemigo = false; // POR EL MOMENTO ESTE ENEMIGO NO BLOQUEA, SINO QUE GENERA ATAQUES AL JUGADOR.

                    // EL ENEMIGO DETECTA AL JUGADOR MIENTRAS ATACA HACIA LA IZQUIERDA Y DISMINUYE LA BARRA DE ENERGÍA EN 5.

                    if (mikeTyson.Bounds.IntersectsWith(padalustro.Bounds) && bloqueoJugador == false)
                    {
                        saludJugador -= 5;
                    }
                    break;

                case "derecha": // EN CASO DE QUE EL ENEMIGO PUEDA ATACAR AL JUGADOR HACIA LA DERECHA.
                    mikeTyson.Image = Properties.Resources.enemy_punch2; // EL ENEMIGO ATACA HACIA LA DERECHA.
                    bloqueoEnemigo = false; // POR EL MOMENTO ESTE ENEMIGO NO BLOQUEA, SINO QUE GENERA ATAQUES AL JUGADOR.

                    // EL ENEMIGO DETECTA AL JUGADOR MIENTRAS ATACA HACIA LA DERECHA Y DISMINUYE LA BARRA DE ENERGÍA EN 5.

                    if (mikeTyson.Bounds.IntersectsWith(padalustro.Bounds) && bloqueoJugador == false)
                    {
                        saludJugador -= 5;
                    }
                    break;

                case "bloqueo": // SI EL ENEMIGO BLOQUEA AL JUGADOR ENTONCES SE ACTIVARÁ EL PODER DE BLOQUEO.
                    mikeTyson.Image = Properties.Resources.enemy_block; // EL ENEMIGO SE BLOQUEA DE LOS ATAQUES DEL JUGADOR.
                    bloqueoEnemigo = true;

                break;
            }
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

            // SI EL JUGADOR PRESIONA LA TECLA IZQUIERDA DEL TECLADO...

            if (e.KeyCode == Keys.Left)
            {
                padalustro.Image = Properties.Resources.boxer_left_punch; // EL JUGADOR GOLPEA HACIA LA IZQUIERDA.
                bloqueoJugador = false; // EL JUGADOR NO BLOQUEA MIENTRAS REALIZA ESTA ACCIÓN.

                // AL MOMENTO DE QUE EL JUGADOR REALICE ESTA ACCIÓN, SE DETECTA MEDIANTE LÍMITES DE COLISIÓN HACIA AL ENEMIGO (mikeTyson).

                if (padalustro.Bounds.IntersectsWith(mikeTyson.Bounds) && bloqueoEnemigo == false)
                {
                    saludEnemigo -= 5; // LA SALUD DEL ENEMIGO RESTA A -5.
                }
            }

            // SI EL JUGADOR PRESIONA LA TECLA DERECHA DEL TECLADO...

            if (e.KeyCode == Keys.Right)
            {
                padalustro.Image = Properties.Resources.boxer_right_punch; // EL JUGADOR GOLPEA HACIA LA DERECHA.
                bloqueoJugador = false; // EL JUGADOR NO BLOQUEA MIENTRAS REALIZA ESTA ACCIÓN.

                // AL MOMENTO DE QUE EL JUGADOR REALICE ESTA ACCIÓN, SE DETECTA MEDIANTE LÍMITES DE COLISIÓN HACIA AL ENEMIGO (mikeTyson).

                if (padalustro.Bounds.IntersectsWith(mikeTyson.Bounds) && bloqueoEnemigo == false)
                {
                    saludEnemigo -= 5; // LA SALUD DEL ENEMIGO RESTA A -5.
                }
            }

            // SIN EMBARGO, SI SE PRESIONA LA TECLA DE ABAJO, SE UTILIZARÁ UN ESCUDO PROTECTOR CUANDO SE BLOQUEA Y PROTEGE DE LOS ATAQUES DEL ENEMIGO.

            if (e.KeyCode == Keys.Down)
            {
                padalustro.Image = Properties.Resources.boxer_block; // EL JUGADOR BLOQUEA DE LOS GOLPES DEL ENEMIGO.
                bloqueoJugador = true; // EN ESTA ACCIÓN SÍ PERMITE PROTEGERTE DE LOS ATAQUES DEL ENEMIGO.
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            // EVENTO EN CUANDO EL JUGADOR (Padalustro) SUELTA CUALQUIER TECLA AL JUGAR.

            // ES SÚPER CORTITO CUANDO DEJA DE EFECTUAR MOVIMIENTOS EL JUGADOR.

            padalustro.Image = Properties.Resources.boxer_stand; // SE MANTIENE EN ESA POSICIÓN.
            bloqueoJugador = false; // NO BLOQUEA DE LOS ATAQUES DEL ENEMIGO.
        }

        private void ReiniciarJuego()
        {
            // EVENTO PARA QUE EL JUGADOR REINICIE UNA PARTIDA.

            // EN INSTANTES...
        }
    }
}