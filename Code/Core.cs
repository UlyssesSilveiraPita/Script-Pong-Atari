using UnityEngine;

public class Core : MonoBehaviour
{
    public static Core Instance;
    [SerializeField] public GameManager _gameManager;
    [SerializeField] public ball _ball;
    [SerializeField] public PlayerController _playerController;
    [SerializeField] public Enemy _enemy;

    void Awake()
    {
        _gameManager.enabled = true;
        _ball.enabled = true;
        _playerController.enabled = true;
        _enemy.enabled = true;

    }

}
