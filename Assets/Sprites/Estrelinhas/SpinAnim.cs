using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class SpinAnim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOLocalRotate(new Vector3(0f, 360f, 0f), 2f, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear);
    }

    
}
