using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    List<GameObject> routes;
    private Vector3 nextPoint;
    public GameObject AIPathHolder;
    private bool isAccPressed = false;
    AICars driver;
    int totalWayPoints;
    int currentIndex;
    private bool nextPos;
    private string turning;
    AIPathway wayPoint;
    internal Transform currentWayPoint;

    // Start is called before the first frame update
    void Start()
    {
        driver = GetComponent<AICars>();
        if (AIPathHolder != null)
        {
            driver.isAIMovement = true;
            wayPoint = AIPathHolder.GetComponent<AIPathway>();
            routes = wayPoint.route;
            currentIndex = 0;
            totalWayPoints = routes.Count;
            currentWayPoint = routes[0].transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!nextPos)
        {
            nextPoint = currentWayPoint.position;
            nextPos = true;
        }
        Vector3 relativeVector = transform.InverseTransformPoint(nextPoint);
        turning = null;

        if (relativeVector.x > 0.5f)
        {
            turning = "right";
        }
        else if (relativeVector.x < -0.5f)
        {
            turning = "left";
        }
        float dist = Vector2.Distance(transform.position, nextPoint);
        isAccPressed = true;
        if (dist < 2)
        {
            currentIndex++;
            if (currentIndex >= totalWayPoints)
            {
                currentIndex = 0;
            }
            currentWayPoint = routes[currentIndex].transform;
            nextPos = false;
        }
    }

    private void FixedUpdate()
    {
        if (driver.isAIMovement)
        {
            driver.Movement(turning, isAccPressed);
        }
    }
}
