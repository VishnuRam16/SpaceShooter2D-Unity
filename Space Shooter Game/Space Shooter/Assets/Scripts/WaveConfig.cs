using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Wave config")]

public class WaveConfig : ScriptableObject
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject pathPrefab;
    [SerializeField] float timeBetweenSpawns = 1.5f;
    [SerializeField] float spwanRandomFactor = 0.3f;
    [SerializeField] int noOfEnemies = 5;
    [SerializeField] float moveSpeed = 1.5f;

    public GameObject GetEnemyPrefab()
    {
        return enemyPrefab;
    }

    public List<Transform> GetWayPoints()
    {
        var waveWayPoints = new List<Transform>();
        foreach (Transform child in pathPrefab.transform)
        {
            waveWayPoints.Add(child);
        }

        return waveWayPoints;
    }

    public float GetTimeBetweenSpawns()
    {
        return timeBetweenSpawns;
    }

    public float GetSpawnRandomFactor()
    {
        return spwanRandomFactor;
    }

    public int GetNoOfEnemies()
    {
        return noOfEnemies;
    }

    public float GetMoveSpeed()
    {
        return moveSpeed;
    }
}
