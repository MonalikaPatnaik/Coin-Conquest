using UnityEngine;
using Cinemachine;

public class CameraRecentre : MonoBehaviour
{
    private CinemachineFreeLook cinemachineCamera;
    private bool isCameraMovementLocked = false;

    void Start()
    {
       cinemachineCamera = GetComponent<CinemachineFreeLook>();
    }

    void Update()
    {
        if (!isCameraMovementLocked)
        {
            if (Input.GetAxis("CameraRecentre") == 1)
            {
                cinemachineCamera.m_RecenterToTargetHeading.m_enabled = true;
            }
        }
    }

    public void LockCameraMovement()
    {
        cinemachineCamera.m_RecenterToTargetHeading.m_enabled = false;
    }

    public void UnlockCameraMovement()
    {
        isCameraMovementLocked = false;
    }
}
