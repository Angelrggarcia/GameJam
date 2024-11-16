using UnityEngine;

public class HackableNode : MonoBehaviour
{
    private bool isHacked = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isHacked)
        {
            isHacked = true;
            Debug.Log("Nodo hackeado!");
            GetComponent<Renderer>().material.color = Color.green; // Cambia el color al ser hackeado
        }
    }
}