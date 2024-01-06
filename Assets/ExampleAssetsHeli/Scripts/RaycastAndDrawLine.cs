using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastAndDrawLine : MonoBehaviour
{
    public float maxDistance = 20f;
    private LineRenderer lineRenderer;

    void Start()
    {
        // Initialize LineRenderer component
        lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.startWidth = 0.02f;
        lineRenderer.endWidth = 0.02f;
    }

    void Update()
    {
        // Cast a ray from the object downwards
        Ray ray = new Ray(transform.position, Vector3.down);
        RaycastHit hit;
        lineRenderer.positionCount = 0;
        if (Physics.Raycast(ray, out hit, maxDistance))
        {
            
            DrawLine(transform.position, hit.point);
        }
        else
        {
            DrawLine(transform.position, transform.position + Vector3.down * maxDistance);
        }
    }

    void DrawLine(Vector3 start, Vector3 end)
    {
        // Draw a line using LineRenderer
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, start);
        lineRenderer.SetPosition(1, end);
    }
}
