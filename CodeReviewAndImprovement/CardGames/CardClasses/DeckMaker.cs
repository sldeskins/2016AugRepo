using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClasses
{
    public static class DeckMaker
    {
        public static Card[] GetAStandardJoker( )
        {
            Card[] deckOfCards = new Card[1] { new StandardPlayingCard(StandardSuitEnum.NotASuit, 16) };
             
            return deckOfCards;
        }
        public static Card[] GetAStandardSuitOfCards(StandardSuitEnum suit)
        {
            Card[] deckOfCards = new Card[13];
            for (int i = 1; i <= deckOfCards.Length; i++)
            {
                deckOfCards[i] = new StandardPlayingCard(suit, i);
            }
            return deckOfCards;
        }
        public static Card[] GetStandardDeck()
        {
            Card[] deckOfCards = new Card[52];
            deckOfCards.CopyTo(GetAStandardSuitOfCards(StandardSuitEnum.Clubs), 0);
            deckOfCards.CopyTo(GetAStandardSuitOfCards(StandardSuitEnum.Diamonds), 13);
            deckOfCards.CopyTo(GetAStandardSuitOfCards(StandardSuitEnum.Hearts), 26);
            deckOfCards.CopyTo(GetAStandardSuitOfCards(StandardSuitEnum.Spades), 39);
            return deckOfCards;
        }
        public static Card[] GetStandardDeckWithJokers()
        {
            Card[] deckOfCards = new Card[54];
            deckOfCards.CopyTo(StandardPlayingCard.GetColorlessJoker(), 0);
            deckOfCards.CopyTo(GetStandardDeck(), 1);
            deckOfCards.CopyTo(GetStandardDeck(), 53);
            return deckOfCards;
        }
    }
}
