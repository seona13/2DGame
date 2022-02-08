using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIManager : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI _scoreText;


	void OnEnable()
	{
		Player.onScoreChange += SetScoreText;
	}


	void OnDisable()
	{
		Player.onScoreChange -= SetScoreText;
	}


	void SetScoreText(int score)
	{
        _scoreText.text = score.ToString();
	}
}