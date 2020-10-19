using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleGame
{
  public class ManagerReportScore : MonoBehaviour
  {
    public static ManagerReportScore m;

    private void Awake ( )
    {
      m = this;
    }

    //TODO: What kind of score data should be stored?
    public void ReportScore ( int newScore )
    {
      SaveData.m.SetInt( "Score", newScore );
    }

    //TODO: Who needs to retrieve the score data and in what format will they need it?
  }
}