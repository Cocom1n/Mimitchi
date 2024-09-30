using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRoom : MonoBehaviour
{
    public List<GameObject> fondos = new List<GameObject>();
    public int indice;
    public Animaciones anim;

    void Start() {
        ActualizarFondo();
    }
    public void NextRoom(){
        if (GameObject.Find("Mimitchi").GetComponent<Sleeping>().GetDormir() == false)
        {
            fondos[indice].SetActive(false);
            indice = (indice + 1) % fondos.Count;
            ActualizarFondo();
        }
    }

    public void PreviousRoom(){
        if (GameObject.Find("Mimitchi").GetComponent<Sleeping>().GetDormir() == false)
        {
            fondos[indice].SetActive(false);
            indice = (indice - 1 + fondos.Count) % fondos.Count;
            ActualizarFondo();
        }
    }

    public void ActualizarFondo(){
        fondos[indice].SetActive(true);
        anim.Reset();
        GameObject.Find("TV").GetComponent<TvController>().ApagarTv();
    }
}
