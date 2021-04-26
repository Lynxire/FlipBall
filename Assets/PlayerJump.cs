using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    [SerializeField] private float _speedWild;
    [SerializeField] private Transform _target;
    [SerializeField] private float _speedTargetMove;
    
    private void Update()
    {
        //GetComponent<Rigidbody>().velocity = Vector3.left * _speedWild;
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 _targetDir;
            if (_target.transform.position.x > transform.position.x)
                _targetDir = Vector3.right;
            else
                _targetDir = Vector3.left;

            GetComponent<Rigidbody>().AddForce(Vector3.up * _speedWild + _targetDir * _speedTargetMove);

        }
    }

}
