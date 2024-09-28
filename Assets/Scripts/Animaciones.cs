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
        animator.SetBool("Alimentar", false);
        animator.SetBool("Dormir", false);
        animator.SetBool("Bañar", false);
        animator.SetBool("Jugar", false);
        animator.SetBool("Alimentar2", false);
        animator.SetBool("Bañar2", false);
        animator.SetBool("Jugar2", false);
    }

    public void Animar(float aux)
    {
        num=Random. Range(1f,3f);
        Debug.Log(num);
        switch (aux)
        {
            case 1:
                animator.SetBool("Alimentar", false);
                animator.SetBool("Dormir", false);
                animator.SetBool("Jugar", false);
                animator.SetBool("Alimentar2", false);
                animator.SetBool("Jugar2", false);
                if(num<=2f)
                {
                    animator.SetBool("Bañar", true);
                    animator.SetBool("Bañar2", false);
                }
                if(num>2f)
                {
                    animator.SetBool("Bañar", false);
                    animator.SetBool("Bañar2", true);
                }
                
                break;
            case 2:
                animator.SetBool("Dormir", false);
                animator.SetBool("Jugar", false);
                animator.SetBool("Jugar2", false);
                animator.SetBool("Bañar", false);
                animator.SetBool("Bañar2", false);
                if(num<=2f)
                {
                    animator.SetBool("Alimentar", true);
                    animator.SetBool("Alimentar2", false);
                }
                if(num>2f)
                {
                    animator.SetBool("Alimentar", false);
                    animator.SetBool("Alimentar2", true);
                }
                break;
            case 3:
                animator.SetBool("Alimentar", false);
                animator.SetBool("Dormir", true);
                animator.SetBool("Jugar", false);
                animator.SetBool("Bañar", false);
                break;
            case 4:
                animator.SetBool("Alimentar", false);
                animator.SetBool("Dormir", false);
                animator.SetBool("Bañar", false);
                animator.SetBool("Bañar2", false);
                animator.SetBool("Alimentar2", false);
                if(num<=2f)
                {
                    animator.SetBool("Jugar", true);
                    animator.SetBool("Jugar2", false);
                }
                if(num>2f)
                {
                    animator.SetBool("Jugar", false);
                    animator.SetBool("Jugar2", true);
                }
                break;
            case 5:
                animator.SetBool("Dormir", false);
                break;
        }

    }

    public void Reset()
    {
        animator.SetBool("Alimentar", false);
        animator.SetBool("Alimentar2", false);
        animator.SetBool("Dormir", false);
        animator.SetBool("Jugar", false);
        animator.SetBool("Jugar2", false);
        animator.SetBool("Bañar", false);
        animator.SetBool("Bañar2", false);
    }

}
