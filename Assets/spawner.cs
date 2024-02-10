using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] private float maxtime = 1.5f;

    [SerializeField] private float heightrange = 0.45f;

    [SerializeField] private GameObject pipe;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    private void update()
    {
        if (timer > maxtime)
        {
            SpawnPipe();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(heightrange, heightrange));
        GameObject pipe = Instantiate(this.pipe, spawnPos, Quaternion.identity);
        Destroy(pipe,10f);
    }
}
