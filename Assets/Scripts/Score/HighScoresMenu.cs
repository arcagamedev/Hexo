using UnityEngine;
using UnityEngine.UI;

public class HighScoresMenu : MonoBehaviour
{
    #region Variables
    private GameManager gm;
    [SerializeField] private Text highScoresText = null;
    #endregion

    #region Mono
    private void Start()
    {
        this.gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        if (this.highScoresText.IsActive())
        {
            this.highScoresText = GetComponent<Text>();
        }
    }

    void Update()
    {
        this.highScoresText.text = this.gm.instance.highScores.ToString();
    }
    #endregion
}
