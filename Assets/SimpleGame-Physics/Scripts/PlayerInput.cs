using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleGame
{
  public class PlayerInput : MonoBehaviour
  {
    //TODO: Who needs to know about player input? Should this be a manager?

    public bool JumpButtonPressed ( )
    {
      return Input.GetKeyDown( KeyCode.Space );
    }

    //TODO: What other input should be handled?
  }
}