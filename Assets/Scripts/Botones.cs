using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour
{
    public GameObject BotonDormir;
    public GameObject BotonDespertar;
    public void AlimentarB()
    {
        if (GameObject.Find("cocina cosas") == null && GetComponent<Sleeping>().GetDormir() == false)
        {
            //WindowsVoice.speak("No puedo comer en este sitio");
            GetComponent<Animaciones>().Animar(6);
            GameObject.Find("TV").GetComponent<TvController>().ApagarTv();
        }
        else if(GameObject.Find("cocina cosas") != null)
        {
            GetComponent<Animaciones>().Animar(2);
            //Debug.Log("Come");
            GetComponent<Feeding>().AlimentarMimitchi(20);
            GetComponent<Sleeping>().RestarSueño(5);
            GetComponent<Cleaning>().RestarAseo(5);
        }

    }

    public void BañarB()
    {
        if (GameObject.Find("baño") == null && GetComponent<Sleeping>().GetDormir() == false)
        {
            GetComponent<Animaciones>().Animar(6);
            GameObject.Find("TV").GetComponent<TvController>().ApagarTv();
        }
        else if(GameObject.Find("baño") != null)
        {
            GetComponent<Animaciones>().Animar(1);
            GetComponent<Cleaning>().AseoMimitchi(20);
            GetComponent<Sleeping>().RestarSueño(5);
            GetComponent<Feeding>().RestarAlimento(5);
        }

    }

    public void DormirB()
    {
        if (GameObject.Find("habitacion paravideos") == null && GetComponent<Sleeping>().GetDormir() == false)
        {
            GetComponent<Animaciones>().Animar(6);
        }
        else if (GameObject.Find("habitacion paravideos") != null)
        {
            GetComponent<Animaciones>().Animar(3);
            GameObject.Find("TV").GetComponent<TvController>().ApagarTv();
            GetComponent<Sleeping>().Dormir(true);
            GetComponent<Feeding>().RestarAlimento(5);
            BotonDespertar.SetActive(true);
            BotonDormir.SetActive(false);
        }
    }

    public void DespertarB()
    {
        if (GameObject.Find("habitacion paravideos") == null && GetComponent<Sleeping>().GetDormir() == false)
        {
            GetComponent<Animaciones>().Animar(6);
            GameObject.Find("TV").GetComponent<TvController>().ApagarTv();
        }
        else if(GameObject.Find("habitacion paravideos") != null && GetComponent<Sleeping>().GetDormir() == true)
        {
            GetComponent<Animaciones>().Animar(5);
            GetComponent<Sleeping>().Dormir(false);
            BotonDespertar.SetActive(false);
            BotonDormir.SetActive(true);
        }

    }
}
