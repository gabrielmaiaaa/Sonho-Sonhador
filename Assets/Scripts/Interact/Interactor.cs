using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    [SerializeField] private float _distance;
    [SerializeField] private LayerMask _interactableMask;

    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
           var colliders = Physics.OverlapSphere(transform.position, _distance, _interactableMask);

           foreach(var c in colliders)
           {
                c.GetComponent<IInteractable>()?.Interact();
           }

        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, _distance);
    }

}
