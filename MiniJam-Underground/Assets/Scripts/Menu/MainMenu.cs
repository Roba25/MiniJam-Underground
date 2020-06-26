using UnityEngine;

namespace Menu
{
    public class MainMenu : MonoBehaviour
    {

        public void HandleExitEvent()
        {
            Application.Quit();
            Debug.Log("Exit");
        }


        public void HandlePlayEvent()
        {
            MenuManager.GoToMenu(MenuName.Game);
            
        }
    }
}
