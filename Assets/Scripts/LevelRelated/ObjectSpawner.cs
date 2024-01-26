using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    int rng;
    [SerializeField] private GameObject itemPrefab;
    private GameObject clone;

    void Awake()
    {
        rng = Random.Range(0, transform.childCount);
    }

    private void Start()
    {
        clone = Instantiate(itemPrefab, transform.GetChild(rng).position, Quaternion.identity);
        clone.GetComponent<ItemToCollect>().SetCanDelete(true);
        clone.transform.parent = null;
    }
}
