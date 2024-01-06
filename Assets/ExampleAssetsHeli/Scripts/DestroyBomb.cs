using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBomb : MonoBehaviour
{
    [SerializeField] ParticleSystem particles;
  
    private void OnCollisionEnter(Collision collision)
    {
        particles.transform.position = gameObject.transform.position;
        particles.Play();
        Destroy(gameObject);
    }
}
