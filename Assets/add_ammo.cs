using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class add_ammo : MonoBehaviour
{
    private int municion;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("municion"))
        {
            //Mensaje original del juego al coger esta armadura
            Debug.Log("municion de escopeta");
            municion++;
        }
    }

    public bool CogerMunicion()
    {
        if (municion > 0)
        {
            municion--;
            return true;
        }
        else return false;
    }
}
