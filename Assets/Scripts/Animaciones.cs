using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animaciones : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("Alimentar", false);
        animator.SetBool("Dormir", false);
        animator.SetBool("Bañar", false);
        animator.SetBool("Jugar", false);
    }

    public void Animar(float aux)
    {
        switch (aux)
        {
            case 1:
                animator.SetBool("Alimentar", false);
                animator.SetBool("Dormir", false);
                animator.SetBool("Jugar", false);
                animator.SetBool("Bañar", true);
                break;
            case 2:
                animator.SetBool("Alimentar", true);
                animator.SetBool("Dormir", false);
                animator.SetBool("Jugar", false);
                animator.SetBool("Bañar", false);
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
                animator.SetBool("Jugar", true);
                animator.SetBool("Bañar", false);
                break;
            case 5:
                animator.SetBool("Dormir", false);
                break;
        }

    }

    public void Reset()
    {
        animator.SetBool("Alimentar", false);
        animator.SetBool("Dormir", false);
        animator.SetBool("Jugar", false);
        animator.SetBool("Bañar", false);
    }

}
