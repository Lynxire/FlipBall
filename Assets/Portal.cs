using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{

    [SerializeField] private Transform _transform;
    public bool _isPlayerState;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerJump>()) 
        {
            if (!_isPlayerState)
            {
                _transform.GetComponent<Portal>()._isPlayerState = true;
                other.transform.position = new Vector3(_transform.position.x, other.transform.position.y, other.transform.position.z);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerJump>())
        {
            _isPlayerState = false;
        }
    }

}
