using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Image[] hearts;     
    public Sprite fullHeart;   
    public Sprite halfHeart;    
    public Sprite emptyHeart;   

   
    public void SetHealth(int currentHealth)
    {
        if (hearts == null || hearts.Length == 0)
            return;

        for (int i = 0; i < hearts.Length; i++)
        {
            int heartValue = currentHealth - (i * 2);

            if (heartValue >= 2)
            {
                hearts[i].sprite = fullHeart;
            }
            else if (heartValue == 1)
            {
                hearts[i].sprite = halfHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
        }
    }
}
