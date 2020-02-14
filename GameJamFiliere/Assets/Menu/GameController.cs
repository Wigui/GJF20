using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private static GameController _instance;
    public static GameController Instance { get { return _instance; } }

    private void Awake()
    {
        if (_instance != null && _instance != this)
            Destroy(this.gameObject);
        else
            _instance = this;
    }




    public void LoadFinish()
    {
        SceneManager.LoadScene("EndScene");
    }

    [SerializeField]
    private Transform m_spawnPosition = null;



}