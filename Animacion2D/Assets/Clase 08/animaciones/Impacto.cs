using UnityEngine;

public class Impacto : MonoBehaviour
{
    public GameObject impactFxPrefab;
    public Transform impactFxTransform;

    public void MostrarImpacto()
    {
        Instantiate(impactFxPrefab, impactFxTransform.position, impactFxTransform.rotation);
  
    }


    public void Sonido()
    {
        // reproducir un sonido;
    }

    public void Ejemplo()
    {
        Debug.Log("Aca el evento!!");
    }
}
