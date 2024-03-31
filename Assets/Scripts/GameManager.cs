using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        Player player = GameObject.Find("Player").GetComponent<Player>();
       player.diamondCount =PlayerPrefs.GetInt("Diamond");
        Debug.Log("Diamond Loaded"+PlayerPrefs.GetInt("Diamond"));
        UIManager.instance.diamondCountText.text = player.diamondCount.ToString();
    }
    public void MenuScreen()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;
    }
}
