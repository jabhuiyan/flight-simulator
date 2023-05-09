using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class coin_scr : MonoBehaviour
{

    public MeshRenderer mr;
    public CapsuleCollider cc;
    public Text coinUi;
    public Text endmessageUi;

    public int coinsToCollect = 1;
    private int coinsCollected = 0;
    private float nextLevelDelay = 3f;
    private int currentLevel;

    // Start is called before the first frame update
    void Start()
    {
        currentLevel = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadNextLevel()
    {
        
        SceneManager.LoadScene(currentLevel + 1);
    }

    private void OnCollisionEnter(Collision collision)
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        mr.enabled = false;
        cc.enabled = false;
        coinUi.SendMessage("AddCoin");
        GetComponent<AudioSource>().Play();

        coinsCollected++;

        if (coinsCollected == coinsToCollect)
        {
            if (currentLevel < 4) {
                endmessageUi.text = "Level Complete";
                Invoke("LoadNextLevel", nextLevelDelay);
            } else {
                endmessageUi.text = "Finished All Levels";
            }
        };
    }
}
