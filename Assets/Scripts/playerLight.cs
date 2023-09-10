using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLight : MonoBehaviour
{
    public GameObject PlayerLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("f"))
        {
            PlayerLight.SetActive(true);
        }
        else if(Input.GetKeyDown("f"))
        {
            PlayerLight.SetActive(false);
        }
    }
}
