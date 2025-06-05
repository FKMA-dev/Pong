using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerNameInScene : MonoBehaviour
{
    public bool isPlayer01 = false;
    public bool isPlayer02 = false;
    public TextMeshProUGUI nameInScenePlayer01;
    public TextMeshProUGUI nameInScenePlayer02;

    void Start()
    {
        WrittingNameInScene();
    }

   public void WrittingNameInScene()
    {
        if (isPlayer01)
        {
            nameInScenePlayer01.text = SaveController.Instance.player01Name;
        }
        
        if (isPlayer02 == false)
        {
            nameInScenePlayer02.text = SaveController.Instance.player02Name;
        }
    }
   
}
