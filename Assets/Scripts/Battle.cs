using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private int strength1, agility1, intelligence1, strength2, agility2, intelligence2;
    private float player1Power, player2Power;

    // Initialize the player stats and calculate their initial power levels
    void Start()
    {
        // Generate random stats for player 1
        strength1 = Random.Range(1, 100);
        agility1 = Random.Range(1, 100);
        intelligence1 = Random.Range(1, 100);

        // Generate random stats for player 2
        strength2 = Random.Range(1, 100);
        agility2 = Random.Range(1, 100);
        intelligence2 = Random.Range(1, 100);

        // Calculate initial power levels
        player1Power = (int)(strength1 * 2 + agility1 * 1.5f + intelligence1);
        player2Power =(int)(strength2 * 2 + agility2 * 1.5f + intelligence2);
    }


    // Update is called once per frame
    void Update()
    {
        // Check for space bar press to trigger the battle
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Store the initial power levels
            int initialPlayer1Power = (int)player1Power;
            int initialPlayer2Power = (int)player2Power;

            // Increase player stats by 265.75%
            strength1 = (int)(strength1 * 2.6575f);
            agility1 = (int)(agility1 * 2.6575f);
            intelligence1 = (int)(intelligence1 * 2.6575f);

            strength2 = (int)(strength2 * 2.6575f);
            agility2 = (int)(agility2 * 2.6575f);
            intelligence2 = (int)(intelligence2 * 2.6575f);

            // Recalculate power levels
            player1Power = (int)(strength1 * 2 + agility1 * 1.5f + intelligence1);
            player2Power = (int)(strength2 * 2 + agility2 * 1.5f + intelligence2);

            // Determine the winner
            string winner;
            int winnerPower;

            if (player1Power > player2Power)
            {
                winner = "Player one";
                float player1Power1 = player1Power;
                winnerPower = (int)player1Power1;
            }
            else if (player2Power > player1Power)
            {
                winner = "Player two";
                winnerPower = (int)player2Power;
            }
            else
            {
                winner = "It's a tie!";
                winnerPower = (int)player1Power;
            }

            // Debug log the results
            Debug.Log("The winner is: " + winner);
            Debug.Log("Player one had: " + initialPlayer1Power + " power level");
            Debug.Log("Player two had: " + initialPlayer2Power + " power level");
            Debug.Log("Player's new stats are:");
            Debug.Log("Player one - Strength: " + strength1 + ", Agility: " + agility1 + ", Intelligence: " + intelligence1);
            Debug.Log("Player two - Strength: " + strength2 + ", Agility: " + agility2 + ", Intelligence: " + intelligence2);
        }
    }
}


