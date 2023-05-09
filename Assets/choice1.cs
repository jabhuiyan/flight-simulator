using UnityEngine;

public class choice1 : MonoBehaviour
{
    public GameObject aircraft1;
    public GameObject aircraft2;

    void Start()
    {
        aircraft1.SetActive(false);
        aircraft2.SetActive(false);
    }

    public void OnAircraftSelectionChanged()
    {
        aircraft1.SetActive(true);
        aircraft2.SetActive(false);
    }

    // Update is called once per frame
    
}
