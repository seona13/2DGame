using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    [SerializeField]
    Vector3 _targetPos;
    Vector3 _startPos;
    [SerializeField]
    float _moveSpeed;
    bool _movingToTargetPos;


    void Start()
    {
        _startPos = transform.position;
        _movingToTargetPos = true;
    }


    void Update()
    {
        if (_movingToTargetPos)
		{
            transform.position = Vector3.MoveTowards(transform.position, _targetPos, _moveSpeed * Time.deltaTime);

            if (transform.position == _targetPos)
			{
                _movingToTargetPos = false;
			}
		}
        else
		{
            transform.position = Vector3.MoveTowards(transform.position, _startPos, _moveSpeed * Time.deltaTime);

            if (transform.position == _startPos)
			{
                _movingToTargetPos = true;
			}
        }
    }
}