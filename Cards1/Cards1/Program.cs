﻿using System;
using System.Collections.Generic;

namespace Karts
{
    class Program
    {
        static void Main()
        {
            Game game = new Game(6);
            while (game.playersTurn())
            {

            }
        }
    }

    public class Game
    {
        public List<Card> cardDeck;
        public List<Player> players;

        private Random _random;
        private int _cardsAmount = 36;
        public Game(int playersCount = 2)
        {
            _random = new Random();

            players = new List<Player>();
            for (int i = 0; i < playersCount; i++)
            {
                players.Add(new Player());
            }

            cardDeck = createCardDeck();
            shuffleCards(cardDeck);

            dealCardsToPlayers(players, cardDeck);
        }

        public List<Card> createCardDeck()
        {
            cardDeck = new List<Card>();
            int suitCount = _cardsAmount / 4;

            for (int i = 0; i < suitCount; i++)
            {
                cardDeck.Add(new Card((CardValue)i, (CardSuit)0));
                cardDeck.Add(new Card((CardValue)i, (CardSuit)1));
                cardDeck.Add(new Card((CardValue)i, (CardSuit)2));
                cardDeck.Add(new Card((CardValue)i, (CardSuit)3));
            }

            return cardDeck;
        }

        public void shuffleCards(List<Card> cards)
        {
            cards.Sort((a, b) => _random.Next(-2, 2));
        }

        public void dealCardsToPlayers(List<Player> players, List<Card> cards)
        {
            int currentPlayer = 0;

            for (int i = 0; i < cards.Count; i++)
            {
                players[currentPlayer].cards.Add(cards[i]);

                currentPlayer++;
                currentPlayer %= players.Count;
            }
        }

        public bool playersTurn()
        {
            Console.WriteLine("Ход игроков:");
            Console.WriteLine("игрок\tкол-во карт\tход картой");

            int maxValue = -1;
            Player playerWithMaxValue = null;
            Stack<Card> cardStack = new Stack<Card>();

            for (int i = 0; i < players.Count; i++)
            {
                Player player = players[i];

                if (player.cards.Count > 0)
                {
                    Card card = player.cards[_random.Next(player.cards.Count)];

                    Console.WriteLine($"{i}\t{player.cards.Count}\t\t{card}");
                    player.cards.Remove(card);

                    if ((int)card.value > maxValue)
                    {
                        maxValue = (int)card.value;
                        playerWithMaxValue = player;
                    }

                    cardStack.Push(card);

                }
            }

            playerWithMaxValue.cards.AddRange(cardStack);
            Console.WriteLine($"Забрал игрок {players.IndexOf(playerWithMaxValue)}.");
            Console.WriteLine("------------------------------------------------");

            if (playerWithMaxValue.cards.Count == _cardsAmount)
            {
                Console.WriteLine($"Победил игрок номер {players.IndexOf(playerWithMaxValue)}");
                return false;
            }

            return true;
        }
    }

    public class Player
    {
        public List<Card> cards = new List<Card>();
    }

    public enum CardValue
    {
        SIX = 0, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE
    }

    public enum CardSuit
    {
        HEARTS = 0, DIAMONDS, CLUBS, SPADES
    }
    public class Card
    {

        public readonly CardValue value;
        public readonly CardSuit suit;

        public Card(CardValue value, CardSuit suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public override string ToString()
        {
            return $"{value} {suit}";
        }
    }
}
