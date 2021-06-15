using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayStart : MonoBehaviour
{
    public GameObject start;
    public AudioSource go;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("StartUp");
    }

    IEnumerator StartUp()
    {
        Time.timeScale = 0;//freezes the screen
        float pauseTime = Time.realtimeSinceStartup + 3f;//for 3 sec
        go.Play();
        while (Time.realtimeSinceStartup < pauseTime)
        {
            yield return 0;
        }
        start.gameObject.SetActive(false);//animation off
        Time.timeScale = 1;
    }
}
