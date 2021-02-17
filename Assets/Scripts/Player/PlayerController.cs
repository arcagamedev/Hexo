using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    #region Variables
    [SerializeField] private Player player;
    private static PlayerController instance;
    private SpriteRenderer newSkin;
    private float newSpeed;

    private string nameSceneMenu = "01 - Menu";
    private string nameSceneGame = "02 - Game";
    #endregion

    #region Mono
    private void Awake() {
        DontDestroyOnLoad(gameObject);
        if (instance == null)
		{
            instance = this;
        }
		else
		{
            Destroy(gameObject);
		}
        
        this.newSkin = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update() {
        ConfigsPlayer();
        MovementPlayer();
        Scene sceneGame = SceneManager.GetSceneByName(nameSceneGame);
        Scene sceneMenu = SceneManager.GetSceneByName(nameSceneMenu);
        if (sceneGame.isLoaded)
        {
            this.gameObject.SetActive(true);
        }

        if (sceneMenu.isLoaded)
        {
            this.gameObject.SetActive(false);
        }
    }
    #endregion

    #region Configs Player
    private void ConfigsPlayer() {
        this.newSkin.sprite = this.player.skinPlayer;
        this.newSpeed = player.speed;
    }
    #endregion

    #region Movement Player
    private void MovementPlayer() {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.RotateAround(this.gameObject.transform.position, Vector3.back, this.newSpeed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.RotateAround(this.gameObject.transform.position, Vector3.forward, this.newSpeed);
        }
    }
    #endregion
}