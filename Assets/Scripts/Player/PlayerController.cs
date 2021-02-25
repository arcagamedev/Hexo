using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Variables
    [SerializeField] private Player player;
    private GameManager gm;
    private SpriteRenderer newSkin;
    private float newSpeed;
    #endregion

    #region Mono
    private void Awake()
    {
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
        this.newSkin.sprite = this.player.skinPlayer;
        this.newSpeed = player.speed;
    }
    #endregion

    #region Movement Player
    private void MovementPlayer()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(Vector3.back * this.newSpeed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(Vector3.forward * this.newSpeed);
        }
    }
    #endregion
}