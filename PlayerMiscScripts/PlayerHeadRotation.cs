using EasyCharacterMovement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeadRotation : MonoBehaviour
{
    
    public Transform headRotation;

    // Update is called once per frame
    void LateUpdate()
    {       
        headRotation.rotation = Camera.main.transform.rotation;
    }
}
