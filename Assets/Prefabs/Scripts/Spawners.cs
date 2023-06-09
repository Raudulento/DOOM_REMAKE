using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;

    public float dificultad;
    private bool creado = false;
    // Update is called once per frame
    void Update()
    {
        if (!creado)
        {
            if (Difficulty.Instance.dificultad >= dificultad)
            {
                if (Vector3.Distance(player.transform.position, transform.position) <= 20f)
                {
                    Instantiate(enemy, transform.position,transform.rotation);
                    creado = true;
                }
            }
            else
                Destroy(this.gameObject);
        }
        else Destroy(this.gameObject);
    }
}
