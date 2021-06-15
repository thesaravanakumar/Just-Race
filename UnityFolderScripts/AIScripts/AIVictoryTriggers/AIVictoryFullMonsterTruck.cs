using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AIVictoryFullMonsterTruck : MonoBehaviour
{
    public int currentLap;
    public int maxLap;

    // Start is called before the first frame update
    void Start()
    {
        currentLap = maxLap;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "FullMonsterCar")
        {
            currentLap--;
            if (currentLap <= 0)
            {
                SceneManager.LoadScene("AIVictory");
            }
        }
    }


}
