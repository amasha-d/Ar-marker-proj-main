using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBuildings : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.CompareTag("Bomb"))
        {
            Destroy(gameObject);
        }
    }
}
