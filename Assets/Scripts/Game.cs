using UnityEngine;

public class Game : MonoBehaviour
{
    public CanvasGroup CanvasGroup;
    private static bool isGameStarted = false;
    
    void Start()
    {
        CanvasGroupDisplayer.Show(CanvasGroup);
    }

    public void OnStartButtonClicked()
    {
        CanvasGroupDisplayer.Hide(CanvasGroup);
        isGameStarted = true;
    }
    public static bool IsGameStarted()
    {
        return isGameStarted;
    }
}
