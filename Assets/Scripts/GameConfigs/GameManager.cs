using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Variables
    private GameManager instance;
    private GameObject playerObj;
    private GameObject player;
    #endregion
    
    #region Mono
    private void Awake() {
        this.player = GameObject.FindGameObjectWithTag("Player");
        DontDestroyOnLoad(this.gameObject);
        if(this.instance == null) {
            this.instance = this;
        } else{
            Destroy(this.gameObject);
        }
    }

    private void Update() {
        DetectSceneLoad();
    }
    #endregion

    #region Detect Scene Load
    private void DetectSceneLoad(){
        Scene sceneGame = SceneManager.GetSceneByName("Game");

        if (sceneGame.isLoaded)
        {
            this.player.SetActive(true);
        }
    }
    #endregion
}
