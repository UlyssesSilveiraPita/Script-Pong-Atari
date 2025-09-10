using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Rigidbody2D enemy_rb;
    [SerializeField] private Transform ball;
    [SerializeField] private float speed;


    // Update is called once per frame
    void Update()
    {
        Vector2 targetPos = ball.position + (Vector3)Random.insideUnitCircle * 1f;
        Vector2 direction = (targetPos - (Vector2)transform.position).normalized;

        Vector2 target = new Vector2(enemy_rb.position.x, Mathf.MoveTowards(enemy_rb.position.y, ball.position.y, speed * Time.fixedDeltaTime));
        enemy_rb.MovePosition(target);

    }
}
