using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField]
    float _moveSpeed;
    [SerializeField]
    Rigidbody2D _rig;


    void Start()
    {
        
    }


	void FixedUpdate()
	{
        float xInput = Input.GetAxis("Horizontal");
        _rig.velocity = new Vector2(xInput * _moveSpeed, _rig.velocity.y);
	}


    void Update()
    {
        
    }
}