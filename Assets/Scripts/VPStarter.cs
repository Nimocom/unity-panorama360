using UnityEngine;
using UnityEngine.Video;

public class VPStarter : MonoBehaviour
{
    [SerializeField] VideoPlayer videoPlayer;

    void Start()
    {
        string url = Application.streamingAssetsPath + "/01_4K_H265_10MBit.mp4";
        videoPlayer.url = url;
        videoPlayer.Play();
    }
}
