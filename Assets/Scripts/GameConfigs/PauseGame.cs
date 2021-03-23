using UnityEngine;

public class PauseGame : MonoBehaviour
{
    #region Variables
    [SerializeField] private GameObject pauseMenu = null;
    private GameManager gm;
    #endregion

    #region Mono
    private void Update()
    {
        StopGame();
    }
    #endregion

    #region Stop Game
    private void StopGame()
    {
        if (this.pauseMenu.activeSelf)
        {
            Time.timeScale = 0;
            Debug.Log("Pause is Active");
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    #endregion
}
