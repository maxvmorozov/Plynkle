using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLauncher : MonoBehaviour
{
    public Launcher Launcher;
    public Sounds Sounds;
    
    void Update()
    {
     //   if (Game.isGameNotStarted())
      //     return;

      if (Ball.IsBallInPlay())
          return;
      
      if (Mouse.current == null)
            return;

      if (Mouse.current.leftButton.wasPressedThisFrame)
      {
          Launch();
      } 
    }

    private void Launch()
    {
        Vector2 aimDirection = GetAimDirection();

        Sounds.PlayCannonSound();
        
        Launcher.Launch(aimDirection);
    }

    private Vector2 GetAimDirection()
    {
        Vector3 mouseWorld = GetMouseWorldPosition();
        return (mouseWorld - transform.position).normalized;
    }

    private Vector3 GetMouseWorldPosition() {
        Vector2 mouseScreen = Mouse.current.position.ReadValue();
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(mouseScreen);
        mouseWorld.z = 0f;
        return mouseWorld;
    }
}
