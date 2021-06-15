using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class AIPathway : MonoBehaviour
{
    public List<GameObject> route;
    public bool drawLine = true;
    private void Awake()
    {
        if (route == null)
        {
            route = new List<GameObject>();
        }
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR
        if (!EditorApplication.isPlaying)
        {
            if (route == null)
            {
                route = new List<GameObject>();
            }
            route.Clear();
            foreach (Transform node in transform)
            {
                route.Add(node.gameObject);
            }
        }
        if (route != null && route.Count > 1)
        {
            if (drawLine)//for checkbox
            {
                DrawLine();
            }
        }
#endif
    }
    private void DrawLine()
    {
        int index = 0;
        Vector3 lastPos = route[index].transform.position;
        for (int i = 0; i < route.Count; i++)
        {
            Debug.DrawLine(lastPos, route[index].transform.position);
            lastPos = route[index].transform.position;
            if (index == route.Count - 1)
            {
                Debug.DrawLine(lastPos, route[0].transform.position);
            }
            index++;
        }
    }
}
