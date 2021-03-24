using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
	#region Variables
	private GameManager gm;
    [SerializeField] private GameObject gameOver;
	#endregion

	#region Mono
	private void Awake()
    {
        this.gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void Update()
    {
        if (this.gm.instance.gameOver == true)
        {
            this.gameOver.SetActive(true);
        }
    }
	#endregion

	#region Restart Game
	public void RestartGame()
    {
        this.gm.instance.gameRestart = true;
        if (this.gm.instance.gameRestart == true)
        {
            this.gm.instance.gameStart = true;
            this.gm.instance.gameOver = false;
            SceneManager.LoadScene(sceneName: "Game");
        }
    }
	#endregion
}
