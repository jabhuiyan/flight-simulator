using UnityEngine;

public class choice2 : MonoBehaviour
{
    public GameObject aircraft1;
    public GameObject aircraft2;

    void Start()
    {
        aircraft1.SetActive(false);
        aircraft2.SetActive(false);
    }

    public void OnSpaceShipSelectionChanged()
    {
        aircraft1.SetActive(false);
        aircraft2.SetActive(true);
    }

    // Update is called once per frame
    
}
