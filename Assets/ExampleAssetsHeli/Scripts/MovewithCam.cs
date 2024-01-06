using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovewithCam : MonoBehaviour
{
    public float moveSpeed = 0.1f; // Adjust the speed of movement

    void Update()
    {
        // Find the AR camera in the scene
        Camera arCamera = Camera.main;

        if (arCamera != null)
        {
            // Get the local camera position relative to the object
            Vector3 localCameraPosition = transform.InverseTransformPoint(arCamera.transform.position);

            // Calculate the new local position for the object (move slowly towards the camera)
            Vector3 newLocalPosition = Vector3.Lerp(Vector3.zero, localCameraPosition, moveSpeed * Time.deltaTime);

            // Set the object's local position to the new local position
            transform.localPosition = newLocalPosition;
        }
    }
}
