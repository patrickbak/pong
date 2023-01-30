using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    public string sceneToLoad;

    public int secTillSceneLoad;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("OpenNextScene", secTillSceneLoad);
    }

    // Update is called once per frame
    void OpenNextScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
