using TMPro;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playerScore_txt;
    [SerializeField] private TextMeshProUGUI computerScore_txt;
    [SerializeField] private Core _core;

    void Start()
    {
        UnityEngine.Cursor.visible = false; // deixando o mouse invisivel ao comecar a partida
    }

    // Update is called once per frame
    void Update()
    {
        scorePoint();
    }

    void scorePoint()
    {
        playerScore_txt.text = _core._ball.pointPlayer.ToString();
        computerScore_txt.text = _core._ball.pointEnemy.ToString();
    }

}
