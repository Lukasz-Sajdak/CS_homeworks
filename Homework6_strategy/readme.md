# Prisoner's Dilemma Strategy Tournament

This C# project simulates a round-robin tournament between different strategies in the classic game theory scenario known as the Prisoner's Dilemma.

## Overview

Each player is assigned a strategy implementing the `IStrategy` interface. During the tournament, every strategy plays a fixed number of rounds against every other strategy (including itself). Scores are assigned based on the outcome of each round.

### Scoring Rules:
- **Both cooperate:** +10 points each
- **One cooperates, one betrays:** +15 for the betrayer, -10 for the cooperator
- **Both betray:** 0 points each

### Example Strategies:
- `AlwaysTrue` – always cooperates
- `AlwaysFalse` – always betrays
- `Follower` – mimics the opponent's last move
- `Grudger` – cooperates until betrayed, then always betrays
- `Random` – random behavior
- `Detective` – a more complex, probing strategy

## Output

The console output is a matrix showing the total scores of each strategy when matched with every other strategy. Rows represent the first player, and columns represent the opponent.
