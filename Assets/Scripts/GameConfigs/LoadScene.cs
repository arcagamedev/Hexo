using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    #region Loader Scene
    /// <summary>
    /// This Method is responsive for Loader Scene for the next area in project
    /// </summary>
    /// <param name="_indexScene"></param>
    public void LoaderScene(int _indexScene)
    {
        SceneManager.LoadSceneAsync(_indexScene);
    }
    #endregion
}
