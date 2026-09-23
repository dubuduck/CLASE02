using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform player;

    [Header("Configuración")]
    public float distance = 5f;
    public float height = 2f;
    public float smoothSpeed = 10f;

    void LateUpdate()
    {
        if (player == null) return;

        // Posición deseada detrás y encima del jugador
        Vector3 desiredPosition =
            player.position
            - player.forward * distance
            + Vector3.up * height;

        // Movimiento suave de la cámara
        transform.position = Vector3.Lerp(
            transform.position,
            desiredPosition,
            smoothSpeed * Time.deltaTime
        );

        // La cámara mira al jugador
        Vector3 target = player.position + Vector3.up * 1.2f;
        transform.LookAt(target);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
