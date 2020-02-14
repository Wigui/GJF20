using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class IntroductionManager : MonoBehaviour
{
    private VideoPlayer vp = null;

    private void Start()
    {
        vp = GetComponent<VideoPlayer>();
        InvokeRepeating("checkOver", .1f, .1f);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
    }

    private void checkOver()
    {
        long playerCurrentFrame = vp.GetComponent<VideoPlayer>().frame;

        if (playerCurrentFrame > 1500)
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
            CancelInvoke("checkOver");
        }
    }
}