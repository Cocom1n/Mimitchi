using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sleeping : MonoBehaviour
{
    private float tiempo;
    [SerializeField] private Image barraSueño;
    private float cantSueño;
    [SerializeField] private bool duerme;
    void Start()
    {
        tiempo = 2f;
        cantSueño = 100f;
        duerme = false;
    }

    void Update()
    {
        barraSueño.fillAmount = cantSueño / 100;
        if (tiempo > 0)
        {
            tiempo = tiempo - Time.deltaTime;
        }
        if (tiempo <= 0)
        {
            tiempo = 2f;
            if (cantSueño > 0 && duerme == false)
            {
                cantSueño -= 1f;
            }
        }
        if (duerme == true && cantSueño < 100)
        {
            cantSueño = cantSueño + Time.deltaTime*2;
        }
    }

    public float GetCantSueño()
    {
        return cantSueño;
    }

    public void RestarSueño(float sueño)
    {
        if (cantSueño < 5 && cantSueño > 0)
        {
            cantSueño = 0;
        }
        if (cantSueño >= 5)
        {
            cantSueño -= sueño;
        }
    }

    public void Dormir(bool dormir)
    {
        duerme = dormir;
    }

    public bool GetDormir()
    {
        return duerme;
    }
}
