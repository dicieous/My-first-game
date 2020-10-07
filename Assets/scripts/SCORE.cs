using UnityEngine.UI;
using UnityEngine;

public class SCORE : MonoBehaviour
{
    public Transform player;
    public Text scoretext;
    void Update()
    {
        scoretext.text = player.position.z.ToString("0");
    }
}
