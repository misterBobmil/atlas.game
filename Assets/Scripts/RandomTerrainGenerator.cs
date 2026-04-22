using UnityEngine;
using System.Collections;

public class RandomTerrainGenerator : MonoBehaviour
{
    public GameObject treePrefab;
    public GameObject rockPrefab;
    public int numberOfTrees = 100;
    public int numberOfRocks = 50;
    public float terrainWidth = 100f;
    public float terrainLength = 100f;

    void Start()
    {
        GenerateTerrain();
    }

    void GenerateTerrain()
    {
        for (int i = 0; i < numberOfTrees; i++)
        {
            Vector3 position = new Vector3(Random.Range(0, terrainWidth), 0, Random.Range(0, terrainLength));
            Instantiate(treePrefab, position, Quaternion.identity);
        }

        for (int i = 0; i < numberOfRocks; i++)
        {
            Vector3 position = new Vector3(Random.Range(0, terrainWidth), 0, Random.Range(0, terrainLength));
            Instantiate(rockPrefab, position, Quaternion.identity);
        }
    }
}