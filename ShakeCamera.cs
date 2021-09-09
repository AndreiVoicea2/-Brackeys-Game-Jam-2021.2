using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class ShakeCamera : MonoBehaviour
{
    public float amplitudine;
    public NoiseSettings noise;
    public GameObject camera;
    public CinemachineVirtualCamera virtualCamera;
    
    public void ShakeTheScreen()
    {
         camera = GameObject.FindGameObjectWithTag("VirtualCamera");
         virtualCamera = camera.GetComponent<CinemachineVirtualCamera>();
        virtualCamera.AddCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        virtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_NoiseProfile = noise;
        virtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = amplitudine;


    }


    public void StopShaking()
    {
        
        camera = GameObject.FindGameObjectWithTag("VirtualCamera");
        virtualCamera = camera.GetComponent<CinemachineVirtualCamera>();
        virtualCamera.AddCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        virtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_NoiseProfile = null;


    }

}
