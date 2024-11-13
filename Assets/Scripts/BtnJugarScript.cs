using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnJugarScript : MonoBehaviour
{
    public void Esperar()
    {
        Invoke("MostrarJuego",1.2f);
    }
    public void MostrarJuego(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
