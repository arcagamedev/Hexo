using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{   
    #region Loader Scene
    public void LoaderScene(int _indexScene) {
        SceneManager.LoadSceneAsync(_indexScene);
    }
    #endregion
}
