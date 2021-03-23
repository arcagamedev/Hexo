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
    [SerializeField] private Text scoreGameOverText = null;
    [SerializeField] private Text highScoreGameOverText = null;
    private int _score = 0;
    public int score
    {
        get { return _score; }
        set { _score = value; }
    }
    
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

        TextsScores();
        if (this.gm.instance.gameOver == true && this._score > this.gm.instance.highScores)
        {
            PlayerPrefs.SetInt("Scores", _score);
        }
    }
    #endregion

    #region  Texts Scores
    private void TextsScores()
    {
        this.scoreText.text = _score.ToString();
        this.scoreGameOverText.text = "Atual: " + _score.ToString();
        this.highScoreGameOverText.text = "High Score: " + this.gm.instance.highScores.ToString();
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
        this._score += _scoreValue;
    }
    #endregion
}
