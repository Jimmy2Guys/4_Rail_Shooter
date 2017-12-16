using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadFirstLevel : MonoBehaviour
{
    [SerializeField] float splashScreenTime = 5f;

    // Use this for initialization
    void Start()
    {
        StopSplashScreen();
    }

    void StopSplashScreen()
    {
        Invoke("LoadNextScene" , splashScreenTime);
    }

    private void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        int totalSceneNumber = SceneManager.sceneCountInBuildSettings;
        if ( currentSceneIndex >= totalSceneNumber - 1 )
        {
            nextSceneIndex = 0;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }

}
