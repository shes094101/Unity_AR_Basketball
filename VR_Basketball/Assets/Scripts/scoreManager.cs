using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text textScore;
    [Header("分數")]
    public int score = 0;
    [Header("投進的分數")]
    public int scoreIn = 2;
    [Header("進球音效")]
    public AudioClip sounIn;

    private AudioSource aud;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ball" && other.transform.position.y > 2.5f) {
            AddScore();
        }
        if (other.transform.root.name == "Player")
        {
            scoreIn = 3;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.root.name == "Player")
        {
            scoreIn = 2;
        }
    }

    private void AddScore() {
        score += scoreIn;
        textScore.text = "SCORE:" + score;
        aud.PlayOneShot(sounIn, Random.Range(1f, 3f));
    }
}
