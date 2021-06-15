using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Speedometer : MonoBehaviour
{
    public Rigidbody2D target;
    public float maxSpeed;
    public float minSpeed,maxSpeedAngle;
    public Text speedLabel;
    public RectTransform arrow;
    private float speed;
    
    // Update is called once per frame
    void Update()
    {
        speed = target.velocity.magnitude * 3.6f;
        if (speedLabel != null)
        {
            speedLabel.text = ((int)speed) + "KM/H";
        }
        if (arrow != null)
        {
            arrow.localEulerAngles = new Vector3(0, 0, Mathf.Lerp(minSpeed, maxSpeedAngle, speed / maxSpeed));//Lerp is for smooth movement
        }
    }
}
