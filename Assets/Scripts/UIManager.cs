using UnityEngine;

public class UIManager : MonoBehaviourSingleton<UIManager>
{
    public void Show(GameObject panel)
    {
        if (panel == null)
        {
            return;
        }

        panel.SetActive(true);
    }

    public void Hide(GameObject panel)
    {
        if (panel == null)
        {
            return;
        }

        panel.SetActive(false);
    }
}
