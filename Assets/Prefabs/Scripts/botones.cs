using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class botones : MonoBehaviour
{
    public Button reinicio;
    public Button menu;
    //Hacemos que según pulse un botón u otro cargue la escena correspondiente
    void Start()
    {
        reinicio.onClick.AddListener(CargaMapa);
        menu.onClick.AddListener(CargaMenu);
    }
    //Mapa en el que nos encontramos
    void CargaMapa()
    {
        SceneManager.LoadScene("E1M1");
    }
    //Menú principal
    void CargaMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
