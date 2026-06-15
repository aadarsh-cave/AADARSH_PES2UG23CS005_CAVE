using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera entranceCam;
    public Camera stageCam;
    public Camera audienceCam;

    public void ShowEntrance()
    {
        entranceCam.enabled = true;
        stageCam.enabled = false;
        audienceCam.enabled = false;
    }

    public void ShowStage()
    {
        entranceCam.enabled = false;
        stageCam.enabled = true;
        audienceCam.enabled = false;
    }

    public void ShowAudience()
    {
        entranceCam.enabled = false;
        stageCam.enabled = false;
        audienceCam.enabled = true;
    }
}