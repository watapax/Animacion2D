using UnityEngine;

public class ReproducirAnimacionesConTeclado : MonoBehaviour
{
    Animator animator;
    public string animacion1, animacion2, animacion3, animacion4;

    private void Awake()
    {
        if(GetComponent<Animator>()!= null)
        {
            animator = GetComponent<Animator>();
        }
    }

    private void Update()
    {
        Animaciones();
    }

    void Animaciones()
    {
        if (animator == null) return;

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            animator.Play(animacion1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            animator.Play(animacion2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            animator.Play(animacion3);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            animator.Play(animacion4);
        }
    }
}
