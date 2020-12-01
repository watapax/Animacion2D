using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPersonaje : MonoBehaviour
{

    public Animator animator;

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

        // si aprete el boton Salto, reproducir animacion ravenSalto
        if(Input.GetButtonDown("Jump"))
        {
            // acceder al animator y darle play a la animacion
            animator.Play("ravenSalto");
        }


        // si aprete el boton Fire1 ejecuta animacion accion1
        // si aprete el boton Fire2 ejecuta animacion accion2

        if(Input.GetButtonDown("Fire1"))
        {
            animator.Play("accion1");
        }

        if (Input.GetButtonDown("Fire2"))
        {
            animator.Play("accion2");
        }

    }

    private void FixedUpdate()
    {
        transform.Translate(direccion);
    }


}
