using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AudioManager
{
  private static bool initialized = false;
  private static AudioSource _audioSouce;
  static Dictionary<AudioClipName ,AudioClip> _audioClips = new Dictionary<AudioClipName, AudioClip>();

  public static bool Initialized => initialized;


  public static void Initialize(AudioSource source)
  {
    initialized = true;
    _audioSouce = source;
    //_audioClips.Add(AudioClipName.GetKey, Resources.Load<AudioClip>("GetKey");
    // and other audio clips added this way
    
    
  }


  public static void Play(AudioClipName name)
  {
    _audioSouce.PlayOneShot(_audioClips[name]);
  }
}
