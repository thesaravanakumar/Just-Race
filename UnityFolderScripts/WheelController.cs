using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    private Vector3 angle;
    public float wheelAngle, maxwheelAngle = 30f;

    // Update is called once per frame
    void Update()
    {
        wheelAngle = -Input.GetAxis("Horizontal") * maxwheelAngle; //- means left 
    }

    private void LateUpdate()
    {
        // Makes wheel turn left or right (next 3 lines)
        angle = transform.localEulerAngles; //freedimensional rotation in individual axis
        angle.z = wheelAngle;
        transform.localEulerAngles = angle;
    }
}
