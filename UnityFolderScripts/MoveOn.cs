using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveOn : MonoBehaviour
{
    public int moveOnwards;
    public string Scene;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SceneChange());
    }

    IEnumerator SceneChange()
    {
        yield return new WaitForSeconds(moveOnwards);
        SceneManager.LoadScene(Scene);
    }
}
