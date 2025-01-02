using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // The name of the scene to load
    public string sceneName;

    // Function to call to change the scene
    public void ChangeSceneMethod()
    {
        // Check if sceneName is not empty
        if (!string.IsNullOrEmpty(sceneName))
        {
            // Load the scene with the specified name
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogWarning("Scene name is empty!");
        }
    }
}
