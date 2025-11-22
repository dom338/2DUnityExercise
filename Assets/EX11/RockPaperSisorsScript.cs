using UnityEngine;

public class RockPaperSisorsScript : MonoBehaviour
{
    public int player1;
    public int player2;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player2 = Random.Range(1, 4);
        if (player1 == 1 && player2 == 2)
        {
            Debug.Log("Player 2 Wins! (Paper covers Rock)");
        }
        else if (player1 == 1 && player2 == 3)
        {
            Debug.Log("player 1 wins (rock break scissors)");
        }
        else if (player1 == 2 && player2 == 1)
        {
            Debug.Log("player 1 wins (paper covers rock)");
        }
        else if (player1 == 2 && player2 == 3)
        {
            Debug.Log("player 2 wins (scissors cut paper)");
        }
        else if (player1 == 3 && player2 == 1)
        {
            Debug.Log("player 2 wins (rock break scissors)");
        }
        else if (player1 == 3 && player2 == 2)
        {
            Debug.Log("player 1 wins (scissors cut paper)");
        }
        else
        {
            Debug.Log("It's a tie!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
