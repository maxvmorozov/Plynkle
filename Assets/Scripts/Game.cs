using UnityEngine;

public class Game : MonoBehaviour
{
    public UI Ui;
    private static bool IsGameStarted = false;
    
    void Start()
    {
        Ui.ShowStartScreen();
        Ui.HideGui();
    }

    public void OnStartButtonClicked()
    {
        Ui.HideStartScreen();
        Ui.ShowGui();
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
