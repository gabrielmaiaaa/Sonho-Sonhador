using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedestal : MonoBehaviour, IInteractable
{
    [SerializeField] private ItemSO itemSO;
    [SerializeField] private GameObject itemGO;
    [SerializeField] private Transform itemTransform;

    private void Start()
    {
        if (!itemSO.ItemPlaced)
            return;

        Instantiate(itemGO, itemTransform.position, itemTransform.rotation);
        itemSO.ItemPlaced = true;
        Destroy(this);
    }

    public void Interact()
    {
        if (!itemSO.ItemCollected)
            return;

        var clone = Instantiate(itemGO, itemTransform.position, itemTransform.rotation);
        itemSO.ItemPlaced = true;
        Destroy(this);

    }

}
