using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Gem : MonoBehaviour
{
    public static event Action<int> onGemCollected;

    [SerializeField]
    int _value = 1;


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			onGemCollected?.Invoke(_value);
			Destroy(gameObject);
		}
	}
}