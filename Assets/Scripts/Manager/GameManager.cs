using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Transform playerPaddle01;
    public Transform playerPaddle02;

    public PlayerNameInScene playerNameInScene;

    public int player01Score;
    public int player02Score;
    public int winPoint;

    public TextMeshProUGUI player01PointsText;
    public TextMeshProUGUI player02PointsText;
    public TextMeshProUGUI textEndGame;

    public BallController ballController;

    public GameObject screenEndGame;

       public void Awake()
    {
        ResetGame();  
    }

    public void ResetGame()
    {
        playerPaddle01.position = new Vector3(8.5f, 1f, 0f);
        playerPaddle02.position = new Vector3(-8.5f, 1f, 0f);

        player01Score = 0;
        player02Score = 0;

        player01PointsText.text = player01Score.ToString();
        player02PointsText.text = player02Score.ToString();

        playerNameInScene.nameInScenePlayer01.text = "";
        playerNameInScene.nameInScenePlayer02.text = "";

        ballController.ResetBall();

        screenEndGame.SetActive(false);
    }

    //Contagem de pontuações dos Players e verificação de quem é o vencedor.
    public void Player01EarnScore()
    {
        player01Score++;
        player01PointsText.text = player01Score.ToString();
        CheckWin();
    }

    public void Player02EarnScore()
    {
        player02Score++;
        player02PointsText.text = player02Score.ToString();
        CheckWin();
    }

    public void CheckWin()
    {
        if (player01Score >= winPoint || player02Score >= winPoint)
        {
            EndGame();
        }

    }

    public void EndGame()
    {
        screenEndGame.SetActive(true);
        string winner = SaveController.Instance.GetName(player01Score > player02Score);
        textEndGame.text = "Vitória " + winner;
        SaveController.Instance.SaveWinner(winner);

        Invoke("LoadScene", 2f);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("Menu");
    }
    
}
