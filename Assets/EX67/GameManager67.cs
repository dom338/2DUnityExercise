using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager67 : MonoBehaviour
{
    private string RedSceneName = "EX_67_SceneRed";
    private string BlueSceneName = "EX_67_SceneBlue";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadSceneMode();
        }


    }
    public void LoadSceneMode()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(RedSceneName);
    }
}
