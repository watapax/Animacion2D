using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootMotion : MonoBehaviour
{

    public float speed = 0.5f;
    private void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime ;
        transform.Translate(Vector2.right * x);
    }

}
