using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;

    [SerializeField]
    private float startTime;

    [SerializeField]
    private float endTime;

    [SerializeField]
    private float spawnRate;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Spawn), startTime, spawnRate);
        Invoke(nameof(CancelInvoke), endTime);
    }


    private void Spawn()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
