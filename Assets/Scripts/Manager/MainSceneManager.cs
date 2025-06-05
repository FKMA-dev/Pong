using TMPro;
using UnityEngine;

public class MainSceneManager : MonoBehaviour
{
    public TextMeshProUGUI uiWinner;

    void Start()
    {
        SaveController.Instance.Reset();
        string lastWinner = SaveController.Instance.GetLastWinner();

        if (lastWinner != "")
            uiWinner.text = "Vencedor da última partida: " + lastWinner;
        else
            uiWinner.text = ""; 
    }
}
