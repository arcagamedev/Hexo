using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{
	#region Variables
	private Camera cam;
    private ScoreScript scoreScript;
    private SpawnEnemyScript spawnEnemyScript;
	#endregion

	#region Mono
	private void Awake()
    {
        this.cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        this.scoreScript = GetComponent<ScoreScript>();
        this.spawnEnemyScript = GameObject.FindGameObjectWithTag("SpawnEnemy").GetComponent<SpawnEnemyScript>();
    }

    private void Update()
    {
        QuestGame();
    }
	#endregion

	#region Quest Game
	/// <summary>
	/// This method is responsive for controller Difficulty in game.
	/// </summary>
	private void QuestGame()
	{
        if (this.scoreScript.instance.score >= 0)
        {
            this.cam.transform.Rotate(Vector3.forward * 0 * Time.deltaTime);
            this.spawnEnemyScript.instance.startTime = 2.0f;
        }
        if (this.scoreScript.instance.score >= 10 && this.scoreScript.instance.score <= 19)
        {
            this.cam.transform.Rotate(Vector3.forward * 20 * Time.deltaTime);
            this.spawnEnemyScript.instance.startTime = 1.7f;
        }
        if (this.scoreScript.instance.score >= 20 && this.scoreScript.instance.score <= 29)
        {
            this.cam.transform.Rotate(Vector3.forward * 0 * Time.deltaTime);
            this.cam.transform.Rotate(Vector3.forward * Random.Range(-40, 40) * Time.deltaTime);
            this.spawnEnemyScript.instance.startTime = 1.5f;
        }
        if (this.scoreScript.instance.score >= 30 && this.scoreScript.instance.score <= 39)
        {
            this.cam.transform.Rotate(Vector3.forward * 0 * Time.deltaTime);
            this.spawnEnemyScript.instance.startTime = 1.3f;
        }
        if (this.scoreScript.instance.score >= 45)
		{
            this.cam.transform.Rotate(Vector3.forward * 40 * Time.deltaTime);
            this.spawnEnemyScript.instance.startTime = 1.1f;
        }
        if (this.scoreScript.instance.score >= 60)
        {
            this.cam.transform.Rotate(Vector3.forward * 40 * Time.deltaTime);
            this.spawnEnemyScript.instance.startTime = 1.1f;
        }
    }
    #endregion
}