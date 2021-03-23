using UnityEngine;

public class SpawnEnemyScript : MonoBehaviour
{
    private SpawnEnemyScript _instance;
    public SpawnEnemyScript instance
    {
        get { return _instance; }
        set { _instance = value; }
    }

    private float _startTime = 2.0f;
    public float startTime
    {
        get { return _startTime; }
        set { _startTime = value; }
    }

    private GameManager gm;
    [SerializeField] private float timeCount;
    [SerializeField] private GameObject hexagonToSpawn = null;

    private void Awake()
    {
        this.gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
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
            timeCount = _startTime;
        }
    }
}
