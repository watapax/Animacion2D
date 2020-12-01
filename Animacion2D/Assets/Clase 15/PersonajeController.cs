using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeController : MonoBehaviour
{
    public Animator animator;
    public float speed;
    float inputHorizontal;
    Vector2 direccion;
    // detectar si aprete las flechas
    // almacenar en un valor la direccion
    // trasladar al gameObject segun la direccion

    private void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        direccion.x = inputHorizontal;

        animator.SetBool("caminando",  inputHorizontal != 0  );


        if(Input.GetButtonDown("Jump"))
        {
            // reproduce animacion accion1
            animator.Play("accion1");
        }

        if (Input.GetButtonDown("Fire1"))
        {
            // reproduce animacion accion1
            animator.Play("accion2");
        }


    }

    private void FixedUpdate()
    {
        transform.Translate(direccion);
    }
}
