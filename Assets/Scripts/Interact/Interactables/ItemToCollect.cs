using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ItemToCollect : MonoBehaviour, IInteractable
{
    [SerializeField] private ItemSO itemSO;
    [SerializeField] private bool _canDelete = false;

    private void Start()
    {
        if (itemSO.ItemCollected && _canDelete)
        {
            transform.DOKill();
            Destroy(this.gameObject);
        }

        transform.DOLocalRotate(new Vector3(0f, 360f, 0f), 2f, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear);

    }
    public void Interact()
    {
        if (!_canDelete)
            return;

        itemSO.SetItemCollected(true);
        SetUI();
        transform.DOKill();
        Destroy(this.gameObject);
    }

    private void SetUI()
    {
        ItensCollected.OnUpdateUI?.Invoke();
    }
}
