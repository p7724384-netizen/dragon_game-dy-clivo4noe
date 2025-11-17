using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class HeartsBar : MonoBehaviour
{
    public heart PlayerHeart;
    public Image totalHeart;
    public Image currentHeart;
    // Start is called before the first frame update
    void Start()
    {
        totalHeart.fillAmound = PlayerHeart.currentHealth / 10;
    }

    // Update is called once per frame
    void Update()
    {
        currentHeart.fillAmound = PlayerHeart.currentHealth / 10;
    }
}
