using UnityEngine;

public class Game : MonoBehaviour
{
    public CanvasGroup CanvasGroup;
    private static bool IsGameStarted = false;
    
    void Start()
    {
        CanvasGroupDisplayer.Show(CanvasGroup);
    }

    public void OnStartButtonClicked()
    {
        CanvasGroupDisplayer.Hide(CanvasGroup);
        IsGameStarted = true;
    }
    void Awake()
    {
        IsGameStarted = false;
    }

    public static bool isGameNotStarted()
    {
        return !IsGameStarted;
    }
    
}
