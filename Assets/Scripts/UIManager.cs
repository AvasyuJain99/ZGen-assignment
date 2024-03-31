using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Slider healthSlider;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI diamondCountText;

    private void Awake()
    {
        instance = this;
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
   
}
