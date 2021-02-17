using System;
using UnityEngine;
using UnityEngine.UI;

public class UiScript : MonoBehaviour
{
	private Text scoreText = null;
	[SerializeField] private Text[] highScores = null;
	private int scores = 0;

	void Update()
	{
		this.highScores[0] = GameObject.FindGameObjectWithTag("HighScoreMenu").GetComponent<Text>();

		if (this.highScores[0] != null)
		{
			this.highScores[0].text = this.scores.ToString();
		}
	}

	void UpScores()
	{
		this.scores++;
		this.scoreText.text = this.scores.ToString();
	}
}
