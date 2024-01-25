using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedestal : MonoBehaviour, IInteractable
{
    [SerializeField] private ItemSO itemSO;
    [SerializeField] private GameObject itemGO;
    [SerializeField] private Transform itemTransform;
    public void Interact()
    {
        if (!itemSO.ItemCollected)
            return;

        Debug.Log("test");
        Instantiate(itemGO, transform.position, Quaternion.identity);

    }

}
