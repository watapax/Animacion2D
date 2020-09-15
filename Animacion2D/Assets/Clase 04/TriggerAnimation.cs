using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("espada"))
        {
            GetComponent<Animator>().SetTrigger("golpe");
        }
    }

}
