using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Happiness : MonoBehaviour
{
    [SerializeField] private Image barraFelicidad;
    [SerializeField] private float cantFelicidad;
    void Start()
    {
        cantFelicidad = GetComponent<Feeding>().GetCantAlimento() + GetComponent<Cleaning>().GetCantAseo() + GetComponent<Sleeping>().GetCantSueño();
    }

    void Update()
    {
        barraFelicidad.fillAmount = cantFelicidad / 300;
        ActualizarCantFelicidad();
    }

    public void ActualizarCantFelicidad()
    {
        cantFelicidad = GetComponent<Feeding>().GetCantAlimento() + GetComponent<Cleaning>().GetCantAseo() + GetComponent<Sleeping>().GetCantSueño();
    }
}
