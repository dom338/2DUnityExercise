using UnityEngine;

public class GameManager_66 : MonoBehaviour
{
    private string RedSceneName = "EX_66_Scene_Red";
    private string BlueSceneName = "EX_66_Scene_Blue";
    private string GreenSceneName = "EX_66_Scene_Red";
    private float secondToChange = 10.0f;
    private float timer = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(RedSceneName);
        }

        if (Input.anyKeyDown)
        {
            timer = Time.time;

        }
        if (Time.time - timer > secondToChange)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(GreenSceneName);
        }

    }

    public void loadBlue()
    {        
        UnityEngine.SceneManagement.SceneManager.LoadScene(BlueSceneName);
    }
}
