using UnityEngine;
using UnityEngine.UI;

public class coin_ui_scr : MonoBehaviour
{

    private int CoinsCollected = 0;
    public Text ui;
    // Start is called before the first frame update
    void Start()
    {
        ui.text = "Coin: " + CoinsCollected.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ui.text = "Coin: " + CoinsCollected.ToString();
    }

    public void AddCoin()
    {
        CoinsCollected++;
    }

}
