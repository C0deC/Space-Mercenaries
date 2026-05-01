using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}
    private int score;
    private float time;


    private void Awake()
    {
        Instance = this;    
    }

    private void Update()
    {
        time += Time.deltaTime;
    }

    private void Start()
    {
        Lander.Instance.OnCoinPickup += Lander_OnCoinPickup;
        Lander.Instance.OnLanded += Lander_OnLanded;
    }

    private void Lander_OnCoinPickup(object sender, System.EventArgs e)
    {
        AddScore(500);
        Debug.Log(score);
    }

    private void Lander_OnLanded(object sender, Lander.OnLandedEventArgs e)
    {
        AddScore(e.score);
    }

    public void AddScore(int addScoreAmount)
    {
        score += addScoreAmount;
        Debug.Log(score);
    }

    public int GetScore()
    {
        return score;
    }

    public float GetTime()
    {
        return time;
    }
}
