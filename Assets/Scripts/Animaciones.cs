using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animaciones : MonoBehaviour
{
    public Animator animator;
    private float num;
    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

    public void Animar(float aux)
    {
        num=Random. Range(1f,3f);
        Debug.Log(num);
        switch (aux)
        {
            case 1:
                //BAÑAR
                Reset();
                if(num<=2f)
                {
                    animator.SetBool("Bañar", true);
                    animator.SetBool("Bañar2", false);
                    StartCoroutine(Esperar("Bañar", 3f));
                }
                if(num>2f)
                {
                    animator.SetBool("Bañar", false);
                    animator.SetBool("Bañar2", true);
                    StartCoroutine(Esperar("Bañar2", 3f));
                }
                
                break;
            case 2:
                //COMER
                Reset();
                if(num<=2f)
                {
                    animator.SetBool("Alimentar", true);
                    animator.SetBool("Alimentar2", false);
                    StartCoroutine(Esperar("Alimentar", 3f));
                }
                if(num>2f)
                {
                    animator.SetBool("Alimentar", false);
                    animator.SetBool("Alimentar2", true);
                    StartCoroutine(Esperar("Alimentar2", 3f));
                }
                break;
            case 3:
                //DORMIR
                Reset();
                animator.SetBool("Dormir", true);
                break;
            case 4:
                //JUEGOS
                Reset();
                if(num<=2f)
                {
                    animator.SetBool("Jugar", true);
                    animator.SetBool("Jugar2", false);
                    StartCoroutine(Esperar("Jugar", 5f));
                }
                if(num>2f)
                {
                    animator.SetBool("Jugar", false);
                    animator.SetBool("Jugar2", true);
                    StartCoroutine(Esperar("Jugar2", 5f));
                }
                break;
            case 5:
                //DESPERTAR
                animator.SetBool("Dormir", false);
                break;
            case 6:
                //NEGAR
                Reset();
                animator.SetBool("negar", true);
                StartCoroutine(Esperar("negar",3f));
                break;
            case 7:
                //HABLAR
                Reset();
                animator.SetBool("hablando", true);
                StartCoroutine(Esperar("hablando",3f));
                break;
        }

    }

    public void Reset()
    {
        animator.SetBool("Alimentar", false);
        animator.SetBool("Dormir", false);
        animator.SetBool("Bañar", false);
        animator.SetBool("Jugar", false);
        animator.SetBool("Alimentar2", false);
        animator.SetBool("Bañar2", false);
        animator.SetBool("Jugar2", false);
        animator.SetBool("hablando", false);
        animator.SetBool("negar", false);
    }

    IEnumerator Esperar(string nombre, float tiempo)
    {
        yield return new WaitForSeconds(tiempo);
        animator.SetBool(nombre, false);
    }

}
