using UnityEngine;

[CreateAssetMenu(fileName = "New Player", menuName = "Player/New Player")]
public class Player : ScriptableObject
{
    #region Name Player
    [SerializeField] private string _namePlayer;
    public string namePlayer
    {
        get { return _namePlayer; }
        set { _namePlayer = value; }
    }
    #endregion

    #region Skin Player
    [SerializeField] private Sprite _skinPlayer;
    public Sprite skinPlayer
    {
        get { return _skinPlayer; }
        set { _skinPlayer = value; }
    }
    #endregion

    #region Speed Player
    [SerializeField] private float _speed;
    public float speed
    {
        get { return _speed; }
        set { _speed = value; }
    }
    #endregion

}
