using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToolsMenuController : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private GameObject toolsPanel;
    [SerializeField] private Image menuArtwork;
    [SerializeField] private Sprite titleImage;
    [SerializeField] private TMP_Text nowPlayingText;

    [Header("Audio (Artlist.io)")]
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioClip track1;
    [SerializeField] private AudioClip track2;
    [SerializeField] private AudioClip track3;

    private void Start()
    {
        if (toolsPanel != null) toolsPanel.SetActive(false);
        if (menuArtwork != null && titleImage != null) menuArtwork.sprite = titleImage;
        if (musicSource != null) musicSource.loop = true;
        SetNowPlaying("No music selected");
    }

    public void OpenToolsMenu()
    {
        if (toolsPanel != null) toolsPanel.SetActive(true);
        if (menuArtwork != null && titleImage != null) menuArtwork.sprite = titleImage;
    }

    public void CloseToolsMenu()
    {
        if (toolsPanel != null) toolsPanel.SetActive(false);
    }

    public void PlayTrack1() => PlayTrack(track1, "Artlist Track 1");
    public void PlayTrack2() => PlayTrack(track2, "Artlist Track 2");
    public void PlayTrack3() => PlayTrack(track3, "Artlist Track 3");

    public void StopMusic()
    {
        if (musicSource != null) musicSource.Stop();
        SetNowPlaying("Music stopped");
    }

    private void PlayTrack(AudioClip clip, string label)
    {
        if (musicSource == null || clip == null) return;
        musicSource.clip = clip;
        musicSource.Play();
        SetNowPlaying("Now Playing: " + label);
    }

    private void SetNowPlaying(string text)
    {
        if (nowPlayingText != null) nowPlayingText.text = text;
    }
}
