using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Variable Instance
    //Instance this
    private static GameManager _instance;
    public GameManager instance
    {
        get { return _instance; }
        set { _instance = value; }
    }
    #endregion

    #region Variables Player Instance
    [SerializeField] private GameObject playerPrefab = null;
    private bool _isInstance = true;
    public bool isInstance
    {
        get { return _isInstance; }
        set { _isInstance = value; }
    }
    #endregion
    #region Variables Player Selection
    private PlayerSelection playerSelection;
    #endregion
    #region Variables Scene Names
    private string nameSceneMenu = "Menu";
    private string nameSceneGame = "Game";
    #endregion

    #region Variables for High Score
    private int valueHighScores;
    private int _highScores = 0;
    public int highScores
    {
        get { return _highScores; }
        set { _highScores = value; }
    }
    #endregion

    #region Variable Game States
    [SerializeField] private bool _gameOver;
    public bool gameOver
    {
        get { return _gameOver; }
        set { _gameOver = value; }
    }

    [SerializeField] private bool _gameStart;
    public bool gameStart
    {
        get { return _gameStart; }
        set { _gameStart = value; }
    }

    private bool _gameRestart;
    public bool gameRestart
    {
        get { return _gameRestart; }
        set { _gameRestart = value; }
    }
    #endregion

    #region Mono
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
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
        LoadPlayerInGame();
        HighScores();
    }
    #endregion

    #region  Load Player in Game
    private void LoadPlayerInGame()
    {
        if (SceneManager.GetSceneByName(this.nameSceneGame).isLoaded && this._isInstance == true)
        {
            Instantiate(this.playerPrefab, Vector3.zero, Quaternion.identity);
            this._isInstance = false;
            this._gameStart = true;
            this._gameOver = false;
        }
        else if (SceneManager.GetSceneByName(this.nameSceneMenu).isLoaded && this._isInstance == false)
        {
            this._isInstance = true;
        }
        else if (this._gameRestart == true)
        {
            this._isInstance = true;
            this._gameRestart = false;
        }
    }
    #endregion

    #region High Scores
    private void HighScores()
    {
        this._highScores = PlayerPrefs.GetInt("Scores", this.valueHighScores);
    }
    #endregion
}
