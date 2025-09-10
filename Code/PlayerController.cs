using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D    player_rb;
    private Vector2 targetPosition; // posi��o do mouse em mundo


    void Update()
    {
        // Captura input do mouse (sempre no Update)
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }

    void FixedUpdate()
    {
        // Move a raquete de forma sincronizada com a f�sica
        player_rb.MovePosition(targetPosition);
    }


}
