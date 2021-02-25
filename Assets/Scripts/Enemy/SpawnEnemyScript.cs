using UnityEngine;

public class SpawnEnemyScript : MonoBehaviour
{
    private byte startTime = 2;
    private GameManager gm;
    [SerializeField] private float timeCount;
    [SerializeField] private GameObject hexagonToSpawn = null;

    private void Awake()
    {
        this.gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void Update()
    {
        if (this.gm.instance.gameStart == true)
        {
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        var positionHexagon = (transform.position = new Vector2(0.0f, 0.0f));
        timeCount -= Time.deltaTime;

        if (timeCount <= 0.0f)
        {
            Instantiate(hexagonToSpawn, positionHexagon, Quaternion.identity);
            timeCount = startTime;
        }
    }
}
