using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM00_GameMaster : MonoBehaviour
{
    public static GM00_GameMaster gameMaster;

    public delegate void SetupGameManager();

    public SetupGameManager SETUP_GAMEMANGER_DELAEGATE;

    private void Awake()
    {
        if (gameMaster != null || gameMaster != this)
        {
            Destroy(gameMaster);
        }
        else
        {
            gameMaster = this;

            if (SETUP_GAMEMANGER_DELAEGATE != null)
            {
                SETUP_GAMEMANGER_DELAEGATE();
            }
        }
    }
}
