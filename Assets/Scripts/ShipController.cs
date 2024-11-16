using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float maxSpeed = 10f; // Velocidad máxima
    public float acceleration = 2f; // Tasa de aceleración
    public float deceleration = 1f; // Tasa de desaceleración
    public float rotationSpeed = 100f; // Velocidad de rotación

    private float currentSpeed = 0f; // Velocidad actual

    void Update()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        // Control de aceleración
        if (Input.GetKey(KeyCode.W)) // Adelante
        {
            currentSpeed += acceleration * Time.deltaTime;
        }
        else
        {
            // Desaceleración gradual si no hay entrada
            currentSpeed -= deceleration * Time.deltaTime;
        }

        // Limitar la velocidad entre 0 y la máxima
        currentSpeed = Mathf.Clamp(currentSpeed, 0f, maxSpeed);

        // Mover el barco hacia adelante
        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);

        // Rotación del barco
        float rotate = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotate, 0);
    }
}