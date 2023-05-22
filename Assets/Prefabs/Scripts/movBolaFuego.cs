﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movBolaFuego : MonoBehaviour
{
    private GameObject jugador;
    public float velocidad;
    private VidaJugador vidaJugador;

    private float dificultad = Difficulty.Instance.dificultad;
    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindWithTag("Player");
        velocidad = 20.0f;
        vidaJugador = jugador.GetComponent<VidaJugador>();
    }

    void Update()
    {
        float movDistancia = Time.deltaTime * velocidad;
        transform.Translate(Vector3.right * movDistancia);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("he chocado con el jugador");
            vidaJugador.recibirDañoArmor(20.0f * dificultad);
        }
    }
}
