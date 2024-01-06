using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBuildings : MonoBehaviour
{
    [SerializeField] ParticleSystem particles;
    private void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.CompareTag("Bomb"))
        {
            particles.transform.position = gameObject.transform.position;
            particles.Play();
            Destroy(gameObject);
        }
    }
}
