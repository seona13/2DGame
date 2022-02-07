using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndFlag : MonoBehaviour
{
	[SerializeField]
	bool _finalLevel;
	[SerializeField]
	string _nextSceneName;


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			if (_finalLevel)
			{
				SceneManager.LoadScene(0);
			}
			else
			{
				SceneManager.LoadScene(_nextSceneName);
			}
		}
	}
}