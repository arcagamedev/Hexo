using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    #region Variables
    private ScoreScript _instance = null;
    public ScoreScript instance
    {
        get { return _instance; }
        set { _instance = value; }
    }
    private GameManager gm;

    [SerializeField] private Text scoreText = null;
    private int score = 0;
    #endregion

    #region Mono Unity
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
        FindGameObject();
        this.scoreText.text = score.ToString();
        if (this.gm.instance.gameOver == true && this.score > this.gm.instance.highScores)
        {
            PlayerPrefs.SetInt("Scores", score);
        }
    }
    #endregion

    #region Find Game Object
    private void FindGameObject()
    {
        this.scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
    }
    #endregion

    #region Up Score
    public void UpScore(int _scoreValue)
    {
        this.score += _scoreValue;
    }
    #endregion
}
