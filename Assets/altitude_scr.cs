using UnityEngine;
using UnityEngine.UI;

public class altitude_scr : MonoBehaviour
{
    public Text altitudeText;
    public Transform planeTransform;
    public Transform spaceshipTransform;

    public GameObject aircraft1;
    public GameObject aircraft2;

    void Start() {
        
    }

    void Update() {

        if (aircraft1.activeSelf)
        {
            float altitudep = planeTransform.position.y;
            string altitudeString = altitudep.ToString("F0");
            altitudeText.text = "Altitude: " + altitudeString + "m";
        }

        if (aircraft2.activeSelf)
        {
            float altitudes = spaceshipTransform.position.y;
            string altitudeString = altitudes.ToString("F0");
            altitudeText.text = "Altitude: " + altitudeString + "m";
        }
    }
}
