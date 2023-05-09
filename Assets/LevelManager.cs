using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public TextMeshProUGUI uiText1;
    public TextMeshProUGUI uiText2;

    private void Start() 
    {
        uiText1.enabled = true;
        uiText2.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            uiText1.enabled = false;
            uiText2.enabled = true;
        }
    }
}
