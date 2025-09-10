using System.Collections;
using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField] private Rigidbody2D ball_rb;
    [SerializeField] private float speedBall;
    [SerializeField] private Vector2 ballPosition;
    [SerializeField] public int pointPlayer;
    [SerializeField] public int pointEnemy;

    void Start()
    {
        ball_rb = GetComponent<Rigidbody2D>();
        ballPosition = new Vector2(0,0);

        resetPosition();

    }

    private void FixedUpdate()
    {
        // Velocidade da bolinha em relacao a fisica aplicada
        ball_rb.linearVelocity = ball_rb.linearVelocity.normalized * speedBall;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            StartCoroutine("IEnextTimeGame");
        }
    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        float y = (transform.position.y - col.transform.position.y) / col.collider.bounds.size.y; // colisao da bolinha em relacao a raquete

        Vector2 direcao = new Vector2(ball_rb.linearVelocity.x >= 0 ? 1 : -1, y).normalized; // direcao que a bolinha recebe depois de colidir com a raquete

        if (col.gameObject.CompareTag("Racket"))
        {
           
            // Aplica nova velocidade
            ball_rb.linearVelocity = direcao * speedBall;

        }
        if (col.gameObject.CompareTag("Wall"))
        {
            // Mantém velocidade constante na sua direcao
            ball_rb.linearVelocity = direcao;
        }


    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.tag)
        {
            case "Pointer_Player":
                pointPlayer += 1;
                break;
            case "Pointer_Computer":
                pointEnemy += 1;
                break;

        }
        StartCoroutine("IEnextTimeGame");
    }

    void resetPosition()
    {
        // reseta posição
        transform.position = ballPosition;

        switch (Random.Range(0,100))
        {
            case > 75:
                ball_rb.linearVelocity = new Vector2(-1, 1).normalized * speedBall;
                break;
            case > 50:
                ball_rb.linearVelocity = new Vector2(-1, -1).normalized * speedBall;
                break;
            case > 25:
                ball_rb.linearVelocity = new Vector2(1, -1).normalized * speedBall; 
                break;
            case >= 0:
                ball_rb.linearVelocity = new Vector2(1, 1).normalized * speedBall;
                break;
        
        }
    }

    IEnumerator IEnextTimeGame()
    {
        yield return new WaitForSeconds(2);
        resetPosition();
        StopAllCoroutines();
        
    }

}
