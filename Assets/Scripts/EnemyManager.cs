using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public Enemy currentEnemy;
    public Transform canvas;

    public static EnemyManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void CreateNewEnemy()
    {
        GameObject enemyToSpawn = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];

        GameObject obj = Instantiate(enemyToSpawn, canvas);

        currentEnemy = obj.GetComponent<Enemy>();
    }
}
