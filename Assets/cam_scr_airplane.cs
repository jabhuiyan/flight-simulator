
using UnityEngine;

public class cam_scr_airplane : MonoBehaviour
{
    public Transform ac1;
    public Transform ac2;
    private char view = 'o';// overhead view

    public GameObject aircraft1;
    public GameObject aircraft2;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = ac1.position + new Vector3(0, 2, -7);
        transform.forward = (ac1.position - transform.position);
    }

    private void setView()
    {
        if (aircraft1.activeSelf)
        {
            if(view == 'o')
            {
                transform.position = ac1.position - ac1.forward.normalized * 7 + new Vector3(0,2,0);
                transform.forward = (ac1.position - transform.position);
                transform.up.Set(0, 1, 0);
            }
            
            if(view == 'f') // first person
            {
                transform.position = ac1.position;
                if (Input.GetKey(KeyCode.R))
                {
                    transform.forward = ac1.right;
                    transform.up = ac1.up;
                }
                else if (Input.GetKey(KeyCode.L))
                {
                    transform.forward = -ac1.right;
                    transform.up = ac1.up;
                }
                else if (Input.GetKey(KeyCode.U))
                {
                    transform.forward = ac1.up;
                    transform.up = -ac1.forward;
                }
                else
                {
                    transform.forward = ac1.forward;
                    transform.up = ac1.up;
                }
            }
        }

        if (aircraft2.activeSelf)
        {
            if(view == 'o')
            {
                transform.position = ac2.position - ac2.forward.normalized * 7 + new Vector3(0,2,0);
                transform.forward = (ac2.position - transform.position);
                transform.up.Set(0, 1, 0);
            }
            
            if(view == 'f') // first person
            {
                transform.position = ac2.position;
                if (Input.GetKey(KeyCode.R))
                {
                    transform.forward = ac2.right;
                    transform.up = ac2.up;
                }
                else if (Input.GetKey(KeyCode.L))
                {
                    transform.forward = -ac2.right;
                    transform.up = ac2.up;
                }
                else if (Input.GetKey(KeyCode.U))
                {
                    transform.forward = ac2.up;
                    transform.up = -ac2.forward;
                }
                else
                {
                    transform.forward = ac2.forward;
                    transform.up = ac2.up;
                }
            }
        }
    }

    private void changeView()
    {
        if(view == 'o')
        {
            view = 'f';
        }
        else if(view == 'f')
        {
            view = 'o';
        }
    } 
    // Update is called once per frame
    void FixedUpdate()
    {
       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            changeView();
        }
        setView();
        
    }
}
