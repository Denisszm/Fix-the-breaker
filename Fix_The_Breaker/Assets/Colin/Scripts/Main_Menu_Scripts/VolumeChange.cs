using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeChange : MonoBehaviour
{
    public AudioMixer masterMixer;
    public float masterLevel;
    public Slider masterSlider;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMasterVolume()
    {
        masterLevel = masterSlider.value;
        masterMixer.SetFloat("MasterVolume", masterLevel);
    }
}
