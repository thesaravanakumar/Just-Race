using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LapComplete : MonoBehaviour
{
    public GameObject trackComplete;
    public GameObject halfWay;
    public GameObject minBest;
    public GameObject secBest;
    public GameObject milliBest;


    public GameObject lapCounter;
    public int lapsCom;

    private void OnTriggerEnter2D(Collider2D other)
    {
        lapsCom += 1;
        if (LapTime.secCount <= 9)
        {
            secBest.GetComponent<Text>().text = "0" + LapTime.secCount + ".";
        }
        else
        {
            secBest.GetComponent<Text>().text = "" + LapTime.secCount + ".";
        }
        if (LapTime.minCount <= 9)
        {
            minBest.GetComponent<Text>().text = "0" + LapTime.minCount + ".";
        }
        else
        {
            minBest.GetComponent<Text>().text = "" + LapTime.minCount + ".";
        }
        milliBest.GetComponent<Text>().text = "" + LapTime.milliCount;
        LapTime.minCount = 0;
        LapTime.secCount = 0;
        LapTime.milliCount = 0;

        lapCounter.GetComponent<Text>().text = "" + lapsCom;
        halfWay.SetActive(true);
        trackComplete.SetActive(false);
    }
}
