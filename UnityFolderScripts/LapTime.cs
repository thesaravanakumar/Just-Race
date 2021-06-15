using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTime : MonoBehaviour
{
    public static int minCount;
    public static int secCount;
    public static float milliCount;
    public static string milliDisplay;
    public GameObject min;
    public GameObject sec;
    public GameObject milli;

    // Update is called once per frame
    void Update()
    {
        milliCount += Time.deltaTime * 10;
        milliDisplay = milliCount.ToString("F0");
        milli.GetComponent<Text>().text = "" + milliDisplay; //00+milliiDisplay
        if (milliCount >= 10)
        {
            milliCount = 0;
            secCount += 1;
        }
        if (secCount <= 9)
        {
            sec.GetComponent<Text>().text = "0" + secCount + ".";
        }
        else
        {
            sec.GetComponent<Text>().text = "" + secCount + ".";//For greater than 9
        }
        if (secCount >= 60)
        {
            secCount = 0;
            minCount += 1;
        }
        if (minCount <= 9)
        {
            min.GetComponent<Text>().text = "0" + minCount + ":";
        }
        else
        {
            min.GetComponent<Text>().text = "" + minCount + ":";
        }
    }
}
