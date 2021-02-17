using UnityEngine;

public class SpawnEnemyScript : MonoBehaviour
{
	private byte startTime = 2;
	[SerializeField]private float timeCount;
	[SerializeField] private GameObject hexagonToSpawn = null;

	private void Update()
	{
		var positionHexagon = (transform.position = new Vector2(0.0f, 0.0f));
		timeCount -= Time.deltaTime;

		if (timeCount <= 0.0f)
		{
			Instantiate(hexagonToSpawn, positionHexagon, Quaternion.identity);
			timeCount = startTime;
		}
	}
}
