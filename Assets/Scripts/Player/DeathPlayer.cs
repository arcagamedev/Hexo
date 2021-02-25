using UnityEngine;

public class DeathPlayer : MonoBehaviour
{
    private GameManager gm;
    [SerializeField] private GameObject gameOverMenu;

    private void Awake()
    {
        this.gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Hexagon"))
        {
            this.gameObject.SetActive(false);
            this.gm.instance.gameOver = true;
            this.gm.instance.gameStart = false;
        }
    }
}
