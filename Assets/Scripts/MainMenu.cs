using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
 public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void OnButtonScaleUp(Button button)
    {
        button.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
    }
    public void OnButtonScaleDown(Button button)
    {
        button.transform.localScale = Vector3.one;
    }
}
