using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raygun : MonoBehaviour
{
    private LineRenderer beam;

    private Camera cam;

    private Vector3 origin;
    private Vector3 endPoint;
    private Vector3 mousePos;

    void Start()
    {
        // Grabbed our laser.
        beam = this.gameObject.AddComponent<LineRenderer>();
        beam.startWidth = 10f;
        beam.endWidth = 10f;

        // Grab the main camera.
        cam = Camera.main;
    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            checkLaser();
        }
        else beam.enabled = false;
    }


    void checkLaser()
    {

        // Finding the origin and end point of laser.
        origin = this.transform.position +
            this.transform.forward * 0.5f * this.transform.lossyScale.z;

        // Finding mouse pos in 3D space.
        mousePos = Input.mousePosition;
        mousePos.y = -500f;
        endPoint = cam.ScreenToWorldPoint(mousePos);
        Debug.Log(cam.ScreenToWorldPoint(Input.mousePosition));
        // Find direction of beam.
        Vector3 dir = endPoint - origin;
        dir.Normalize();

        // Are we hitting any colliders?
        RaycastHit hit;
        if (Physics.Raycast(origin, dir, out hit, -500f))
        {
            // If yes, then set endpoint to hit-point.
            endPoint = hit.point;

            // Has this hit object got a rigidbody? 
            if (hit.transform.GetComponent<Rigidbody>() != null)
            {
                hit.transform.GetComponent<Rigidbody>().
                    AddForce(dir, ForceMode.Impulse);
            }
        }

        // Set end point of laser.
        beam.SetPosition(0, origin);
        beam.SetPosition(1, endPoint);
        // Draw the laser!
        beam.enabled = true;

    }
}
