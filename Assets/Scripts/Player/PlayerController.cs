using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Variables
    [SerializeField] private Player _player;
    public Player player
    {
        get { return _player; }
        set { _player = value; }
    }
    private PlayerController _instance;
    public PlayerController instance
    {
        get { return _instance; }
        set { _instance = value; }
    }

    private bool _isRight;
    public bool isRight
    {
        get { return _isRight; }
        set { _isRight = value; }
    }

    private bool _isLeft;
    public bool isLeft
    {
        get { return _isLeft; }
        set { _isLeft = value; }
    }
    

    private GameManager gm;
    private SpriteRenderer newSkin;
    private float newSpeed;
    #endregion

    #region Mono
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        this.gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        this.newSkin = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        ConfigsPlayer();
        if (this.gm.instance.gameStart == true)
        {
            MovementPlayer();
        }
    }
    #endregion

    #region Configs Player
    private void ConfigsPlayer()
    {
        this.newSkin.sprite = this._player.skinPlayer;
        this.newSpeed = _player.speed;
    }
    #endregion

    #region Movement Player
    private void MovementPlayer()
    {
        if (Input.GetKey(KeyCode.RightArrow) || this._isRight)
        {
            this.transform.Rotate(Vector3.back * this.newSpeed);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || this._isLeft)
        {
            this.transform.Rotate(Vector3.forward * this.newSpeed);
        }
    }
    #endregion
}