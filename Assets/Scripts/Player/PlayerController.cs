using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Variables
    [SerializeField] private Player player;
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
    private PlayerSelection selection;
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
        this.selection = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PlayerSelection>();
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
        // Player Selection
        if (this.gm.instance.gameObject.GetComponent<PlayerSelection>().blueBall == true)
        {
            this.player = this.gm.instance.playerBlueSelect;
        }
        else if (this.gm.instance.gameObject.GetComponent<PlayerSelection>().greenBall == true)
        {
            this.player = this.gm.instance.playerGreenSelect;
        }

        this.newSkin.sprite = this.player.skinPlayer;
        this.newSpeed = this.player.speed;
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