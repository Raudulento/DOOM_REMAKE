﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acido_script : MonoBehaviour
{
    public VidaJugador vidaJugador;
    private float tickAcido = 1f;

    private void OnTriggerStay(Collider other)
    {
        //Evitamos que al chocar con el suelo desaparezca el objeto, para que solo lo haga con el jugador
        if (other.gameObject.tag == "Player")
        {
            //Hace que los ticks sean cada 1 segundo en vez de cada frame
            if (Time.time >= tickAcido)
            {
                vidaJugador.recibirDaño(0.5f);
                ++tickAcido;
            }
            
        }
    }
}
