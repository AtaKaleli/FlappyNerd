using System;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class UI_Settings : MonoBehaviour
{


    [SerializeField] private AudioMixer audioMixer;

    [Header("SFX Settings")]
    [SerializeField] private Slider sfxSlider;
    [SerializeField] private TextMeshProUGUI sfxSliderText;
    [SerializeField] private string sfxParameter;

    [Header("BGM Settings")]
    [SerializeField] private Slider bgmSlider;
    [SerializeField] private TextMeshProUGUI bgmSliderText;
    [SerializeField] private string bgmParameter; //same as exposed parameter from tabs->audiomixer

    [SerializeField] private float mixerMultiplier = 25;


    

    public void SetUpSFXSlider()
    {
        sfxSlider.onValueChanged.AddListener(SFXSliderValue);
        sfxSlider.minValue = .001f;
        sfxSlider.value = PlayerPrefs.GetFloat("sfxParameter", 1.0f);
    }

    public void SetUpBGMSlider()
    {
        bgmSlider.onValueChanged.AddListener(BGMSliderValue);
        bgmSlider.minValue = .001f;
        bgmSlider.value = PlayerPrefs.GetFloat("bgmParameter", 1.0f);
    }


    public void SFXSliderValue(float value)
    {
        sfxSliderText.text = Mathf.RoundToInt(value * 100) + "%";
        float newValue = MathF.Log10(value) * mixerMultiplier;
        audioMixer.SetFloat(sfxParameter, newValue);
    }

    public void BGMSliderValue(float value)
    {
        bgmSliderText.text = Mathf.RoundToInt(value * 100) + "%";
        float newValue = MathF.Log10(value) * mixerMultiplier;
        audioMixer.SetFloat(bgmParameter, newValue);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat("sfxParameter", sfxSlider.value);
        PlayerPrefs.SetFloat("bgmParameter", bgmSlider.value);
    }




}
