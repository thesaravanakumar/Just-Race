using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static MainMenu instance;
    private string trackToLoad;
    public GameObject trackSelect;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        LapTime.minCount = 0;//calling laptime
        LapTime.secCount = 0;
        LapTime.milliCount = 0;
    }

    public void LevelSelect(string trackName)
    {
        trackToLoad = trackName;
        SceneManager.LoadScene(trackToLoad);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }

    public void OpenTrackSelect()
    {
        trackSelect.SetActive(true);
    }
    public void CloseTrackSelect()
    {
        trackSelect.SetActive(false);
    }
}
