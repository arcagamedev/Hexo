using UnityEngine;

public class PlayerSelection : MonoBehaviour
{
    #region Variables
    private PlayerSelection _instance;
    public PlayerSelection instance
    {
        get { return _instance; }
        set { _instance = value; }
    }
    [SerializeField] private GameObject playerBlue;

    public bool _blueBall = true;
    public bool blueBall
    {
        get { return _blueBall; }
        set { _blueBall = value; }
    }

    public bool _greenBall = false;
    public bool greenBall
    {
        get { return _greenBall; }
        set { _greenBall = value; }
    }
    [SerializeField] private GameObject playerGreen;
    #endregion

    void Start()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void BlueBall()
    {
        this._blueBall = true;
        if (this._blueBall == true)
        {
            this._greenBall = false;
        }
    }

    public void GreenBall()
    {
        this._greenBall = true;

        if (this._greenBall == true)
        {
            this._blueBall = false;
        }
    }
}
