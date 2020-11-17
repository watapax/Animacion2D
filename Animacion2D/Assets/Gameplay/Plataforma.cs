using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public float cantidadFuerza;
    public LayerMask plataformaLayer;
    public Rigidbody2D pelotaRb;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("pelota"))
        {
            RaycastHit2D hit;

            hit = Physics2D.Raycast(collision.transform.position, Vector3.down, 2, plataformaLayer);
            Vector2 fuerza = hit.normal;
            pelotaRb.velocity = Vector2.zero;
            pelotaRb.AddForce(fuerza * cantidadFuerza, ForceMode2D.Impulse);
            
        }
    }


}
