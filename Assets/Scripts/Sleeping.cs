using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sleeping : MonoBehaviour
{
    private float tiempo;
    [SerializeField] private Image barraSueño;
    private float cantSueño;
    void Start()
    {
        tiempo = 5f;
        cantSueño = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        barraSueño.fillAmount = cantSueño / 100;
        if (tiempo > 0)
        {
            tiempo = tiempo - Time.deltaTime;
        }
        if (tiempo <= 0)
        {
            tiempo = 5f;
            if (cantSueño > 0)
            {
                cantSueño -= 10f;
            }
        }
    }

    public void DescansarMimitchi(float dormir)
    {
        if (cantSueño < 100 && cantSueño > 90)
        {
            cantSueño = 100;
        }
        if (cantSueño <= 90)
        {
            cantSueño += dormir;
        }
    }

    public float GetCantSueño()
    {
        return cantSueño;
    }
}
