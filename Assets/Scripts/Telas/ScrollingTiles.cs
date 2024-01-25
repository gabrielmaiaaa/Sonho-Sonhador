using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingTiles : MonoBehaviour
{
    [SerializeField] private Vector2 uvAnimationRate = new Vector2(1.0f, 1.0f);

    private Renderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<Renderer>();
    }

    void LateUpdate()
    {
        meshRenderer.material.mainTextureOffset = uvAnimationRate * Time.realtimeSinceStartup;
    }
}
