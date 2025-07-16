using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void LoadScene(int indexScene)
   {
        SceneManager.LoadScene(indexScene);
   }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F3))
        {
            SceneManager.LoadScene(3);
        }

        if(Input.GetKeyDown(KeyCode.F4))
        {
            SceneManager.LoadScene(4);
        }

        if( Input.GetKeyDown(KeyCode.F1))
        {
            SceneManager.LoadScene(1);
        }

        if(Input.GetKeyDown (KeyCode.F10))
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            SceneManager.LoadScene(2);
        }

        if (Input.GetKeyDown(KeyCode.F5))
        {
            SceneManager.LoadScene(5);
        }

        if (Input.GetKeyDown(KeyCode.F6))
        {
            SceneManager.LoadScene(6);
        }
    }
}
