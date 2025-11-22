using UnityEngine;

public class RockPaperScissor5Rounds : MonoBehaviour
{
    public int rounds = 1;
    public int player1Score = 0;
    public int player2Score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        while (rounds <= 5)
        {
            int player1 = Random.Range(0, 3);
            int player2 = Random.Range(0, 3);
            if (player1 == player2)
            {
                Debug.Log("Round " + rounds + ": It's a tie!");
            }
            else if ((player1 == 0 && player2 == 2) || (player1 == 1 && player2 == 0) || (player1 == 2 && player2 == 1))
            {
                Debug.Log("Round " + rounds + ": Player 1 wins this round!");
                player1Score++;
            }
            else
            {
                Debug.Log("Round " + rounds + ": Player 2 wins this round!");
                player2Score++;
            }
            rounds++;
        }
        Debug.Log("Final Score - Player 1: " + player1Score + ", Player 2: " + player2Score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
