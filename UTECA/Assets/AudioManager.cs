// learn.unity.com/tutorial/working-with-audio-components-2019-3W
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum AudioClips_Soundtrack
{
  NONE,
  SONG_1,
  SONG_2,
}

public enum Audiclips_SFX
{
  NONE,
  WALK,
  PUNCH,
  BULLET,
}

public class AudioManager : MonoBehaviour
{
  public static AudioManager instance;

  public AudioSource audioSource; // Background Music / Soundtrack / Songs
  public AudioSource audioSourceEffectRef; // VFX / UI

  public AudioClip[] audioClipsSoundtrack;
  public AudioClip[] audioClipsSFX;

  public float SoundtrackVolume = 0.3f;
  public float SFXVolume = 0.3f;

  public Slider volumeRef;
  private void Awake()
  {
    if (instance != null)
    {
      return;
    }
    else
    {
      instance = this;
    }
  }

  public void SetAudioClipSoundtrack(AudioClips_Soundtrack audioClips_Soundtrack)
  {
    audioSource.Stop(); // Detener el audio anterior existente.
    audioSource.PlayDelayed(0.3f);
    audioSource.PlayOneShot(audioClipsSoundtrack[(int)audioClips_Soundtrack], SoundtrackVolume);
  }

  public void SetAudioClipSFX(AudioSource _audioSource, Audiclips_SFX audioclips_SFX)
  {
    _audioSource.PlayOneShot(audioClipsSFX[(int)audioclips_SFX], SFXVolume);
    audioSourceEffectRef = _audioSource;
  }

  public void ModifyCurrentVolume()
  {
    audioSource.volume = volumeRef.value / 1;
    audioSourceEffectRef.volume = volumeRef.value / 1;
  }

  private void Update()
  {
    ModifyCurrentVolume();
  }
}
