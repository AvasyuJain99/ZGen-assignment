using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private List<Transform> spawnPositions = new List<Transform>();
    [SerializeField]
    private GameObject diamondPrefab;
    [SerializeField]
    private GameObject healthPrefab;
    
    void Start()
    {
        StartCoroutine(SpawnDiamond());
    }
    private IEnumerator SpawnDiamond()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
          
            int pos = Random.Range(0,5);
            Instantiate(diamondPrefab, spawnPositions[pos].transform.position, Quaternion.identity);
        }
    }
    public IEnumerator SpawnHealth()
    {
        yield return new WaitForSeconds(10f);
        int pos = Random.Range(6, 7);
        Instantiate(healthPrefab, spawnPositions[pos].transform.position, Quaternion.identity);
    }
}
