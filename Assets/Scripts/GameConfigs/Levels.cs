using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private ScoreScript scoreScript;
    [SerializeField] private SpawnEnemyScript spawnEnemyScript;

    private void Awake()
    {
        this.cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        this.scoreScript = GetComponent<ScoreScript>();
        this.spawnEnemyScript = GameObject.FindGameObjectWithTag("SpawnEnemy").GetComponent<SpawnEnemyScript>();
    }

    private void Update()
    {
        if (this.scoreScript.instance.score >= 0)
        {
            this.cam.transform.Rotate(Vector3.forward * 0 * Time.deltaTime);
            this.spawnEnemyScript.instance.startTime = 2.0f;
            Debug.Log("0");
        }
        if (this.scoreScript.instance.score >= 10)
        {
            this.cam.transform.Rotate(Vector3.forward * 20 * Time.deltaTime);
            this.spawnEnemyScript.instance.startTime = 1.7f;
            Debug.Log("10");
        }
        if (this.scoreScript.instance.score >= 20)
        {
            this.cam.transform.Rotate(Vector3.forward * -20 * Time.deltaTime);
            this.spawnEnemyScript.instance.startTime = 1.5f;
            Debug.Log("20");
        }
        if (this.scoreScript.instance.score >= 30)
        {
            this.cam.transform.Rotate(Vector3.forward * 40 * Time.deltaTime);
            this.spawnEnemyScript.instance.startTime = 1.3f;
            Debug.Log("20");
        }
        if (this.scoreScript.instance.score >= 40)
        {
            this.cam.transform.Rotate(Vector3.forward * -40 * Time.deltaTime);
            this.spawnEnemyScript.instance.startTime = 1.3f;
            Debug.Log("20");
        }
    }
}
