using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intento_escopeta : MonoBehaviour
{

    private float proximoDisparo;
    private float tiempoDisparo;
    private float tiempoesperas;
    private float cantidadmovida;
    private float divisor;
    private Transform salida;
    public GameObject Atras_Arma;
    public GameObject Posicion_Arma;
    public GameObject bala;
    public AudioSource disparoSFX;
    public add_ammo municion;

    // Start is called before the first frame update
    void Start()
    {
        proximoDisparo = 0.0f;
        if (gameObject.CompareTag("pistola")) tiempoDisparo = 0.8f;
        else tiempoDisparo = 1.5f;
        tiempoesperas = 0.0035f;
        divisor = 20.0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log(Time.time);
        if(Input.GetMouseButton(0))
        if (Time.time >= proximoDisparo && (gameObject.CompareTag("pistola") || (gameObject.CompareTag("escopeta") && municion.CogerMunicion())))
        {
            proximoDisparo = Time.time + tiempoDisparo;
            disparoSFX.Play();
            Debug.Log("Supuestamente se ha disparado");
            divisor = 20.0f;
            StartCoroutine(WaitMultipleTimes());
        }
    }

    private void MoverAtras()
    {
        Vector3 posicionActual = transform.position;
        Vector3 posicionCubo = Atras_Arma.transform.position;

        float X = (posicionCubo.x - posicionActual.x) / divisor;
        float Y = (posicionCubo.y - posicionActual.y) / divisor;
        float Z = (posicionCubo.z - posicionActual.z) / divisor;

        transform.position = posicionActual + new Vector3(X, Y, Z);
        divisor = divisor - 1;
    }

    private void MoverAlante()
    {
        Vector3 posicionActual = transform.position;
        Vector3 posicionInicial = Posicion_Arma.transform.position;

        float X = (posicionInicial.x - posicionActual.x) / divisor;
        float Y = (posicionInicial.y - posicionActual.y) / divisor;
        float Z = (posicionInicial.z - posicionActual.z) / divisor;

        transform.position = posicionActual + new Vector3(X, Y, Z);
        divisor = divisor - 1;
    }

    private IEnumerator WaitMultipleTimes()
    {
        Quaternion currentRotation = transform.rotation;

        salida = gameObject.transform.GetChild(0).transform;
        GameObject nuevabala = Instantiate(bala, salida.position, salida.rotation);
        if (gameObject.CompareTag("escopeta"))
        {
            GameObject nuevabala2 = Instantiate(bala, salida.position, salida.rotation);
            GameObject nuevabala3 = Instantiate(bala, salida.position, salida.rotation);
            GameObject nuevabala4 = Instantiate(bala, salida.position, salida.rotation);
        }

        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x - 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAtras();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x - 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAtras();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x - 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAtras();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x - 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAtras();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x - 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAtras();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x - 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAtras();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x - 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAtras();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x - 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAtras();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x - 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAtras();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x - 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAtras();
        //mitad de movimiento hacia arriba
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x - 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAtras();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x - 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAtras();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x - 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAtras();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x - 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAtras();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x - 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAtras();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x - 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAtras();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x - 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAtras();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x - 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAtras();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x - 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAtras();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x - 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAtras();
        //
        //estos son todos hacia arriba      ahora mismo hay 40 movimientos de rotacion
        //
        divisor = 20.0f;
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x + 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAlante();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x + 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAlante();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x + 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAlante();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x + 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAlante();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x + 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAlante();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x + 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAlante();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x + 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAlante();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x + 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAlante();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x + 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAlante();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x + 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAlante();
        //Mitad de movimiento hacia abajo
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x + 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAlante();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x + 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAlante();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x + 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAlante();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x + 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAlante();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x + 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAlante();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x + 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAlante();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x + 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAlante();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x + 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAlante();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x + 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        transform.rotation = currentRotation;
        yield return new WaitForSeconds(tiempoesperas);
        currentRotation = transform.rotation;
        MoverAlante();
        currentRotation.eulerAngles = new Vector3(currentRotation.eulerAngles.x + 0.4f, currentRotation.eulerAngles.y, currentRotation.eulerAngles.z);
        yield return new WaitForSeconds(tiempoesperas);
        transform.rotation = currentRotation;
        MoverAlante();
    }
}
