using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Health : MonoBehaviour
{
    [SerializeField]
    private SpawnManager spawnManager; 
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        spawnManager = GameObject.Find("Spawn Manager").GetComponent<SpawnManager>();
        if (other.gameObject.tag == "Player")
        {
            if (player.health == 100)
            {
                Debug.Log("Your Health is already at Max");
            }
            else
            {
            player.health += 20;
            UIManager.instance.healthSlider.DOValue(player.health, 0.5f);
            UIManager.instance.healthText.text = player.health.ToString();
                Destroy(gameObject);
                spawnManager.StartCoroutine(spawnManager.SpawnHealth());
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
