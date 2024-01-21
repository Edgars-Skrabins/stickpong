using UnityEngine;
using UnityEngine.UI;

public class LifeTextSc : MonoBehaviour
{
    public Text lifesText;

    public void UpdateLifes(int lifes)
    {
        lifesText.text = "lifes: " + lifes;
    }
}