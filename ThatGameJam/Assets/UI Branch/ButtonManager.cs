using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void OnPressPlay()
    {
        SceneManager.LoadScene(3);
    }
    public void OnPressLevels()
    {
        SceneManager.LoadScene(2);
    }
    public void OnPressLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
    public void OnPressSettings()
    {
        SceneManager.LoadScene(1);
    }
    public void OnPressMenu()
    {
        SceneManager.LoadScene(0);
    }
}
