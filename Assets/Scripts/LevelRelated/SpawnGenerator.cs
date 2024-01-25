using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGenerator : MonoBehaviour
{
    int rng;
    private GameObject player;
    void Awake()
    {
        rng = Random.Range(0, transform.childCount);
        player = FindObjectOfType<Movement>().gameObject;
    }

    private void Start()
    {
        player.transform.position = transform.GetChild(rng).position;
    }
}
