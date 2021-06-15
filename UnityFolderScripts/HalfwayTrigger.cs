using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfwayTrigger : MonoBehaviour
{
    public GameObject halfWayTrig;
    public GameObject lapCompleteTrig;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            lapCompleteTrig.SetActive(true); // Turn on the Trigger
            halfWayTrig.SetActive(false); // Turn off the Trigger
        }
    }
}
