using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTest : MonoBehaviour, IInteractable
{
    [SerializeField] private ItemSO itemSO;

    private void Start()
    {
        if (itemSO.ItemCollected)
            Destroy(this.gameObject);
    }
    public void Interact()
    {
        itemSO.SetItemCollected(true);
        SetUI();
        Destroy(this.gameObject);
    }

    private void SetUI()
    {
        ItensCollected.OnUpdateUI?.Invoke();
    }
}
