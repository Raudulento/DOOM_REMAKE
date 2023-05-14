﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acido_script : MonoBehaviour
{
    public VidaJugador vidaJugador;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        //Evitamos que al chocar con el suelo desaparezca el objeto, para que solo lo haga con el jugador
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Estas tocando acido");
            vidaJugador.recibirDaño(0.1f);
        }
    }
}