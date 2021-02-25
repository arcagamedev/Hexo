using UnityEngine;

public class EnemyController : MonoBehaviour
{
    #region Variables
    private float scaleValue = 5.0f;
    #endregion

    #region Mono Unity
    void Awake()
    {
        this.transform.localScale = new Vector2(this.scaleValue, this.scaleValue);
        this.transform.Rotate(new Vector3(0, 0, Random.Range(0.0f, 360.0f)));
    }

    void Update()
    {
        ScaleEnemyMovement();
    }
    #endregion

    #region Scale Enemy Movement
    private void ScaleEnemyMovement()
    {
        //Scale
        this.scaleValue -= Time.deltaTime;
        this.transform.localScale = new Vector2(this.scaleValue, this.scaleValue);

        if (this.scaleValue <= 0.0f)
        {
            Destroy(this.gameObject);
        }
    }
    #endregion
}
