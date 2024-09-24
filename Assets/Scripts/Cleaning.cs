using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

public class Cleaning : MonoBehaviour
{
    private float tiempo;
    [SerializeField] private Image barraAseo;
    private float cantAseo;
    void Start()
    {
        tiempo = 5f;
        cantAseo = 100f;
    }

    void Update()
    {
        barraAseo.fillAmount = cantAseo / 100;
        if (tiempo > 0)
        {
            tiempo = tiempo - Time.deltaTime;
        }
        if (tiempo <= 0)
        {
            tiempo = 5f;
            if (cantAseo > 0)
            {
                cantAseo -= 10f;
            }
        }
    }

    public void AseoMimitchi (float bañar)
    {
        if (cantAseo < 100 && cantAseo > 90)
        {
            cantAseo = 100;
        }
        if (cantAseo <= 90)
        {
            cantAseo += bañar;
        }
    }

    public float GetCantAseo()
    {
        return cantAseo;
    }
}
