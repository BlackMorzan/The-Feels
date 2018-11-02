using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSounds : MonoBehaviour 
{

  public AudioClip Humpf;
  public AudioClip Step;
  
  public AudioSource Head;
  public AudioSource Foot;
  
  
  
  void Humpfing()
  {
    Head.PlayOneShot(Humpf);
  }
  
  void Steps()
  {
    Foot.PlayOneShot(Step);
  }
}
