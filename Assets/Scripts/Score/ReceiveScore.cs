using UnityEngine;

public class ReceiveScore : MonoBehaviour
{
    private ScoreScript uiScore;

    private void Update()
    {
        this.uiScore = GameObject.Find("--ScriptsThisScene--").GetComponent<ScoreScript>();
    }

    #region On Trigger Enter 2D
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ScoreTrigger"))
        {
            uiScore.instance.UpScore(1);
        }
    }
    #endregion
}
