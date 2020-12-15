using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPersonaje : MonoBehaviour
{

    public Animator animator;
    public string accion1, accion2, accion3;
    // Detectar input de teclado (flechas)
    // Mover al gameObject segun la direccion de la flecha
    // almacenar en variable la direccion
    public float velocidad;
    float inputX;
    Vector2 direccion;

    private void Update()
    {
        // direccion sera igual al input Horizontal
        inputX = Input.GetAxisRaw("Horizontal") * velocidad * Time.deltaTime;
        direccion.x = inputX;

        // el parametro caminando es verdadero cuando inputX no es cero
        animator.SetBool("caminando", inputX != 0);

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            animator.Play(accion1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            animator.Play(accion2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            animator.Play(accion3);
        }

    }

    private void FixedUpdate()
    {
        transform.Translate(direccion);
    }


}
