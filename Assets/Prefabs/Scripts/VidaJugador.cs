using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaJugador : MonoBehaviour
{
    public float armorAct;
    public float vidaAct;
    public BarraVida barraVida;
    public BarraArmadura barraArmor;
    public AudioSource damageSound;
    public Image img;
    public Sprite[] caras;
    public Text textomuerte;
    public Button reinicio;
    public Button menu;
    public Camera camara_muerte;
    // Start is called before the first frame update

    void Start()
    {
        vidaAct = 100.0f;
        armorAct = 100.0f;
        barraVida.SetMaxHealth(200);
        barraArmor.SetMaxArmor(200);
        cambioCara(vidaAct);
    }

    // Update is called once per frame
    void Update()
    {
        //Aqui ira los daños
    }
    //Función auxiliar
    private float maximo(float x, float y)
    {
        if (x < y) x = y;
        return x;
    }
    //Gestionamos el daño directo a la salud
    public void recibirDaño(float daño){

        float resguardo = vidaAct;        //por si acaso es botiquin o paquete de vida

        vidaAct -= daño;

        if (!damageSound.isPlaying && daño > 0 )
        {
            damageSound.Play();
        }
        
        if (daño < (-5.0f) && vidaAct > 100.0f) vidaAct = maximo(resguardo, 100.0f);
        int aux = Mathf.FloorToInt(vidaAct);
        barraVida.SetHealth(aux);
        cambioCara(vidaAct);
    }
    //Gestionamos el daño para la armadura
    public void recibirDañoArmor(float daño)
    {

        float resguardo = armorAct;        //por si acaso es botiquin o paquete de vida

        armorAct -= daño;
        float armorFinal = maximo(armorAct, 0.0f);
        int aux = Mathf.FloorToInt(armorAct);
        barraArmor.SetArmor(aux);

        if(armorAct < 0) recibirDaño((resguardo - armorFinal) * 0.66f - armorAct);
        
        else recibirDaño((resguardo - armorFinal) * 0.66f);

        armorAct = armorFinal;
    }
    //Aumentamos la armadura
    public void recibirArmor(float aux)
    {
        if (aux == 1.0f) armorAct = armorAct + aux;
        else armorAct = maximo(aux, armorAct);

        int subir = Mathf.FloorToInt(armorAct);
        barraArmor.SetArmor(subir);
    }
    //Hacemos los cambios de cara según cambie la vida
    public void cambioCara(float vida){
        if(vida == 100){
            img.sprite = caras[4];
        }else{
            if(vida < 75 && vida > 50){
                img.sprite = caras[2];
            }else{
                if(vida > 25 && vida < 50){
                    img.sprite = caras[2];
                }else{
                    if(vida > 0){
                        img.sprite = caras[3];
                    }else{
                        img.sprite = caras[0];
                        camara_muerte.gameObject.SetActive(true);
                        StartCoroutine(muerte_espera());
                    }
                }
            }
        }
    }
    //Con esta función mostramos los botones para reiniciar el nivel, volver al menú y el texto de muerte
    IEnumerator muerte_espera(){
        yield return new WaitForSeconds(3);
        textomuerte.gameObject.SetActive(true);
        reinicio.gameObject.SetActive(true);
        menu.gameObject.SetActive(true);
    }

}
