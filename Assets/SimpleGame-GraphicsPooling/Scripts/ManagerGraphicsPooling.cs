using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleGame
{
  public class ManagerGraphicsPooling : MonoBehaviour
  {
    public static ManagerGraphicsPooling m;

    private void Awake ( )
    {
      m = this;
    }


    //TODO: What kinds of graphics will we need to pool?
    public SFXPool _SFXPool;
  }
}