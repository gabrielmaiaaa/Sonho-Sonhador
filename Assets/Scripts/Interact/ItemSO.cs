using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "New Item")]
public class ItemSO : ScriptableObject
{
    public string Name;
    public Sprite Sprite;
    public Sprite DefaultSprite;

    public bool ItemCollected = false;

    public void SetItemCollected(bool value) => ItemCollected = value;

    public void ResetSOValues() { ItemCollected = false; } //script no menu, foreach in Resources.


}
