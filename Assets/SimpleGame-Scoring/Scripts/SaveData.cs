using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleGame
{
  public class SaveData : MonoBehaviour
  {
    public static SaveData m;

    private void Awake ( )
    {
      m = this;
    }

    public void SetInt ( string key, int i )
    {
      PlayerPrefs.SetInt( key, i );
    }

    //TODO: Impliment SETTING save data for all useful variable tyles

    public void GetInt ( string key, out int i )
    {
      i = PlayerPrefs.GetInt( key );
      
    }

    //TODO: Impliment GETTING save data for all useful variable tyles


    //TODO: When should we write the save data to the disk with PlayerPrefs.Save( ); ?

  }
}