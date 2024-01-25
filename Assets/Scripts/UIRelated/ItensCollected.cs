using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItensCollected : MonoBehaviour
{
    public static Action OnUpdateUI;

    public static ItemSO[] itensSO;

    private void Awake()
    {
        itensSO = Resources.LoadAll<ItemSO>("SOs");
    }

    private void OnEnable()
    {
        OnUpdateUI += UpdateUI;
    }

    private void OnDisable()
    {
        OnUpdateUI -= UpdateUI;
    }

    private void UpdateUI()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            var child = transform.GetChild(i);
            if (!itensSO[i].ItemCollected)
            {
                child.GetComponent<Image>().sprite = itensSO[i].DefaultSprite;
                continue;
            }

            child.GetComponent<Image>().sprite = itensSO[i].Sprite;
        }
    }

    private void Start()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            if (!itensSO[i].ItemCollected)
                continue;

            var child = transform.GetChild(i);
            child.GetComponent<Image>().sprite = itensSO[i].Sprite;
        }
    }

}
