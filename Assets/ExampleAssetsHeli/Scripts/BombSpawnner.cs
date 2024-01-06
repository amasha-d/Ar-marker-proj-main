using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class BombSpawnner : MonoBehaviour
{
    public ARRaycastManager raycastManager;
    public GameObject objectToPlace;
    private GameObject placedObject;
    [SerializeField] 
    private GameObject spawningPosition;
    //private Rigidbody rb;
    private bool flag = true;

    public Camera arCamera;

    private List<ARRaycastHit> hits = new List<ARRaycastHit>();

    // Update is called once per frame
     void Start()
    {
        
    }
    void Update()
    {
        Ray ray = arCamera.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButton(0) && flag)
        {
            flag = false;
            placedObject = Instantiate(objectToPlace, spawningPosition.transform.position, spawningPosition.transform.rotation);
            StartCoroutine(WaitAndExecute());

        }
    }
    IEnumerator WaitAndExecute()
    {
        Debug.Log("Start waiting...");

        // Wait for 2 seconds
        yield return new WaitForSeconds(2f);
        flag = true;
        Debug.Log("Waited for 2 seconds. This code will execute after the wait.");
    }
    

}
