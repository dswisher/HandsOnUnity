using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;

    [SerializeField]
    private GameObject shootPoint;


    public void OnFire()
    {
        var clone = Instantiate(prefab);

        clone.transform.position = shootPoint.transform.position;
        clone.transform.rotation = shootPoint.transform.rotation;
    }
}
