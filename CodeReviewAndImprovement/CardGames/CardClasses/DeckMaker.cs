using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClasses
{
    public static class DeckMaker
    {
        public static FiveSuitedCard[] GetAStandardJoker( )
        {
            FiveSuitedCard[] deckOfCards = new FiveSuitedCard[1] { new StandardPlayingCard(StandardSuitEnum.NotASuit, 16) };
             
            return deckOfCards;
        }
        public static FiveSuitedCard[] GetAStandardSuitOfCards(StandardSuitEnum suit)
        {
            FiveSuitedCard[] deckOfCards = new FiveSuitedCard[13];
            for (int i = 1; i <= deckOfCards.Length; i++)
            {
                deckOfCards[i] = new StandardPlayingCard(suit, i);
            }
            return deckOfCards;
        }
        public static FiveSuitedCard[] GetStandardDeck()
        {
            FiveSuitedCard[] deckOfCards = new FiveSuitedCard[52];
            deckOfCards.CopyTo(GetAStandardSuitOfCards(StandardSuitEnum.Clubs), 0);
            deckOfCards.CopyTo(GetAStandardSuitOfCards(StandardSuitEnum.Diamonds), 13);
            deckOfCards.CopyTo(GetAStandardSuitOfCards(StandardSuitEnum.Hearts), 26);
            deckOfCards.CopyTo(GetAStandardSuitOfCards(StandardSuitEnum.Spades), 39);
            return deckOfCards;
        }
        public static FiveSuitedCard[] GetStandardDeckWithJokers()
        {
            FiveSuitedCard[] deckOfCards = new FiveSuitedCard[54];
            deckOfCards.CopyTo(StandardPlayingCard.GetColorlessJoker(), 0);
            deckOfCards.CopyTo(GetStandardDeck(), 1);
            deckOfCards.CopyTo(GetStandardDeck(), 53);
            return deckOfCards;
        }
    }
}
