using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour {

    public enum EndingType
    {
        noLuckyPoint,
        neverHelpInnovation,
        helpInnovation,
        buyAllMagazine
    }

    [HideInInspector] public static bool isGameOver = false;
    [HideInInspector] private static bool hasHelpInnovationParty=false;

    private static EndingType m_endingType = EndingType.noLuckyPoint;

    private void Update()
    {
        if (isGameOver)
        {
            UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync("Scene 3");
            UnityEngine.SceneManagement.SceneManager.LoadScene("EndingScene");
        }
    }

    public static void IHelpInnovationParty()
    {
        hasHelpInnovationParty = true;

    }
}
