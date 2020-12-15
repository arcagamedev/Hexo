using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    #region Variables
    [SerializeField] private Player player;
    private SpriteRenderer newSkin;
    private float newSpeed;
    #endregion
    
    #region Mono
    private void Awake() {
        this.newSkin = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update() {
        ConfigsPlayer();
        MovementPlayer();
        Scene sceneGame = SceneManager.GetSceneByName("Game");
        Scene sceneMenu = SceneManager.GetSceneByName("Menu");
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