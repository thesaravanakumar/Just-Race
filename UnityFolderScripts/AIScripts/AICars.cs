using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICars : MonoBehaviour
{
    public float accelerator;
    public float turnpower = 1;
    public float turnspeed = 4;
    Rigidbody2D rb;
    internal bool isAIMovement;
    private float friction = 1.5f;
    private float currentSpeed;
    private Vector2 curSpeed;
    float currentAcc;
    private bool isMoving;

    public AudioSource engine;
    public float maxEngineSound;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentAcc = accelerator;
    }

    private void Update()
    {
        if (engine != null)
        {
            engine.pitch=1f+((rb.velocity.magnitude / maxEngineSound) * 3f) ;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isMoving)
        {
            rb.AddForce(transform.up * currentAcc);
        }
        if (!isMoving)
        {
            rb.drag = friction * 2;
        }
    }

    public void Movement(string turning,bool isPaddlePressed)
    {
        if (turning == "left")
        {
            transform.Rotate(Vector3.forward * (currentSpeed + currentSpeed));
        }
        else if (turning == "right")
        {
            transform.Rotate(Vector3.forward * -(currentSpeed + currentSpeed));
        }
        if (isPaddlePressed)
        {
            isMoving = true;
        }

        currentSpeed = curSpeed.magnitude / turnspeed;
        curSpeed = new Vector2(rb.velocity.x, rb.velocity.y);
    }
}
