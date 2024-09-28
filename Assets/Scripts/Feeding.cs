using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Feeding : MonoBehaviour
{
    private float tiempo;
    [SerializeField] private Image barraAlimento;
    private float cantAlimento;
    void Start()
    {
        tiempo = 2f;
        cantAlimento = 100f;
    }

    void Update()
    {
        barraAlimento.fillAmount = cantAlimento / 100;
        if (tiempo > 0)
        {
            tiempo = tiempo - Time.deltaTime;
        }
        if (tiempo <= 0)
        {
            tiempo = 2f;
            if (cantAlimento > 0)
            {
                cantAlimento -= 1f;
            }
        }
    }

    public void AlimentarMimitchi (float comer)
    {
        if (cantAlimento < 100 && cantAlimento > 90)
        {
            cantAlimento = 100f;
        }
        if (cantAlimento <= 90)
        {
            cantAlimento += comer;
        }
    }

    public float GetCantAlimento()
    {
        return cantAlimento;
    }

    public void RestarAlimento(float alimento)
    {
        if (cantAlimento < 5 && cantAlimento > 0)
        {
            cantAlimento = 0;
        }
        if (cantAlimento >= 5)
        {
            cantAlimento -= alimento;
        }
    }
}
