using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour {
    public Transform player;
    public Text scoretext;
    private void Update()
    {
        //Debug.Log(player.position.z);
        scoretext.text = player.position.z.ToString("0");

    }
}
