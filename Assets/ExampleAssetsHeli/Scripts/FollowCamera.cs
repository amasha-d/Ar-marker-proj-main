using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    private Transform arCameraTransform;

    void Start()
    {
      
        arCameraTransform = Camera.main.transform;
    }

    void Update()
    {
        
        transform.position = arCameraTransform.position;
        transform.rotation = arCameraTransform.rotation;

       
    }
}
