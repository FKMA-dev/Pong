using UnityEngine;
using UnityEngine.UI;

public class ColorSelectionButton : MonoBehaviour
{
    public Button uiButton;
    public Image paddleReference;

    public bool isColorPlayer01 = false;

    public void OnButtonClick()
    {
        paddleReference.color = uiButton.colors.normalColor;

        if (isColorPlayer01)
        {
            SaveController.Instance.player01Color = paddleReference.color;
        }
        else
        {
            SaveController.Instance.player02Color = paddleReference.color;
        }

    }
}
