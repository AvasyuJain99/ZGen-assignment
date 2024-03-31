using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Obstacle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            player.health -= 20;
            UIManager.instance.healthSlider.DOValue(player.health, 0.5f);
            UIManager.instance.healthText.text = player.health.ToString();
            if (player.health < 1)
            {
                Debug.Log("Player is Dead");
            }

        }
    }
}
