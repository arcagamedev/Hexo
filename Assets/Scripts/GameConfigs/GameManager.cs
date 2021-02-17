using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Variables
    private static GameManager instance;
    //private string nameSceneMenu = "01 - Menu";
    private string nameSceneGame = "02 - Game";
    [SerializeField] private GameObject player;
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
    }

    private void Update() {
        DetectSceneLoad();
    }
    #endregion

    #region Detect Scene Load
    private void DetectSceneLoad(){
        Scene sceneGame = SceneManager.GetSceneByName(nameSceneGame);

        if (sceneGame.isLoaded)
        {
            this.player.SetActive(true);
        }
    }
    #endregion
}
