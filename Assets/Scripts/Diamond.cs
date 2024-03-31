using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            player.diamondCount++;
            UIManager.instance.diamondCountText.text = player.diamondCount.ToString();
            PlayerPrefs.SetInt("Diamond", player.diamondCount);
        }
    }
}
