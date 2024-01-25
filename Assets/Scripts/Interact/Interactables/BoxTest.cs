using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTest : MonoBehaviour, IInteractable
{
    [SerializeField] private ItemSO itemSO;
    [SerializeField] private bool _canDelete = false;

    private void Start()
    {
        if (itemSO.ItemCollected && _canDelete)
            Destroy(this.gameObject);
    }
    public void Interact()
    {
        if (!_canDelete)
            return;

        itemSO.SetItemCollected(true);
        SetUI();
        Destroy(this.gameObject);
    }

    private void SetUI()
    {
        ItensCollected.OnUpdateUI?.Invoke();
    }
}
