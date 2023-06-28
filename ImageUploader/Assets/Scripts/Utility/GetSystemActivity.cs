using UnityEngine;
using UnityEngine.SceneManagement;

public class GetSystemActivity : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            int numberScene = SceneManager.GetActiveScene().buildIndex - 1;
            Debug.Log(numberScene);

            if (numberScene >= 0) SceneManager.LoadScene(numberScene);
            else Application.Quit();
        }
    }
}
