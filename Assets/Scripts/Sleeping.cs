using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sleeping : MonoBehaviour
{
    private float tiempo;
    [SerializeField] private Image barraSue�o;
    private float cantSue�o;
    void Start()
    {
        tiempo = 5f;
        cantSue�o = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        barraSue�o.fillAmount = cantSue�o / 100;
        if (tiempo > 0)
        {
            tiempo = tiempo - Time.deltaTime;
        }
        if (tiempo <= 0)
        {
            tiempo = 5f;
            if (cantSue�o > 0)
            {
                cantSue�o -= 10f;
            }
        }
    }

    public void DescansarMimitchi(float dormir)
    {
        if (cantSue�o < 100 && cantSue�o > 90)
        {
            cantSue�o = 100;
        }
        if (cantSue�o <= 90)
        {
            cantSue�o += dormir;
        }
    }

    public float GetCantSue�o()
    {
        return cantSue�o;
    }
}
