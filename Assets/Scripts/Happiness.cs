using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Happiness : MonoBehaviour
{
    [SerializeField] private Image barraFelicidad;
    [SerializeField] private float cantFelicidad;
    [SerializeField] private GameObject triste;
    [SerializeField] private GameObject normal;
    [SerializeField] private GameObject feliz;
    [SerializeField] private GameObject contento;
    void Start()
    {
        cantFelicidad = GetComponent<Feeding>().GetCantAlimento() + GetComponent<Cleaning>().GetCantAseo() + GetComponent<Sleeping>().GetCantSueño();
    }

    void Update()
    {
        barraFelicidad.fillAmount = cantFelicidad / 300;
        ActualizarCantFelicidad();
        ActualizarFelicidad();
    }

    public void ActualizarCantFelicidad()
    {
        cantFelicidad = GetComponent<Feeding>().GetCantAlimento() + GetComponent<Cleaning>().GetCantAseo() + GetComponent<Sleeping>().GetCantSueño();
    }

    public void ActualizarFelicidad()
    {
        float calcularFelicidad;
        calcularFelicidad = (cantFelicidad * 100) / 300;
        if (calcularFelicidad >= 75)
        {
            contento.SetActive(true);
            feliz.SetActive(false);
            normal.SetActive(false);
            triste.SetActive(false);
        }
        else if (calcularFelicidad >= 50 && calcularFelicidad < 75)
        {
            contento.SetActive(false);
            feliz.SetActive(true);
            normal.SetActive(false);
            triste.SetActive(false);
        }
        else if (calcularFelicidad >= 25 && calcularFelicidad < 50)
        {
            contento.SetActive(false);
            feliz.SetActive(false);
            normal.SetActive(true);
            triste.SetActive(false);
        }
        else if (calcularFelicidad >= 0 && calcularFelicidad < 25)
        {
            contento.SetActive(false);
            feliz.SetActive(false);
            normal.SetActive(false);
            triste.SetActive(true);
        }
    }
}
