using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkManager : MonoBehaviour
{
    [Header("Elements")]
    [SerializeField] private Chunk[] chunkPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 chunkPosition = Vector3.zero;

        for (int i = 0; i < 5; i++)
        {
            Chunk newChunk = chunkPrefabs[Random.Range(0, chunkPrefabs.Length)];

            if (i > 0) chunkPosition.z += newChunk.GetLength() / 2;

            Chunk spawnedChunk = Instantiate(newChunk, chunkPosition, Quaternion.identity, transform);
            chunkPosition.z += spawnedChunk.GetLength() / 2;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
