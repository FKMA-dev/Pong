using UnityEngine;
using TMPro;

public class InputName : MonoBehaviour
{
    public bool isPlayer01;


    public TMP_InputField inputField;

    private void Start()
    {
        inputField.onValueChanged.AddListener(UpdateName);
    }

    public void UpdateName(string name)
    {
        if (isPlayer01)
            SaveController.Instance.player01Name = name;
        else
            SaveController.Instance.player02Name = name;
    }

    
    
}
