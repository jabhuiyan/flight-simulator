using UnityEngine;
using UnityEngine.UI;

public class speed_scr : MonoBehaviour
{
    public Rigidbody ac1;
    public Rigidbody ac2;
    public Text speed;

    public GameObject aircraft1;
    public GameObject aircraft2;
    // Start is called before the first frame update
    void Start()
    {
        speed.text = "Speed: " + ((int) (Vector3.Dot(ac1.velocity, ac1.transform.forward))).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (aircraft1.activeSelf)
        {
            speed.text = "Speed: " + ((int)(Vector3.Dot(ac1.velocity, ac1.transform.forward))).ToString();
        }

        if (aircraft2.activeSelf)
        {
            speed.text = "Speed: " + ((int)(Vector3.Dot(ac2.velocity, ac2.transform.forward))).ToString();
        }
    }
}
