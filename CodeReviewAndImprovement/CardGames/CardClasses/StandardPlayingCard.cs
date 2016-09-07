using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClasses
{
    public class StandardPlayingCard : Card
    {
        private string m_faceValue = "";

        public StandardPlayingCard(StandardSuitEnum suitType, int pointValue)
        {
            m_suit = suitType;
            PointValue = pointValue;
            SuitName = suitType.ToString();

            m_faceValue = GetFaceValue(pointValue);

        }

        public string FaceValue
        {
            get { return m_faceValue; }
            set { m_faceValue = value; }
        }
        private StandardSuitEnum m_suit = StandardSuitEnum.NotASuit;
        public StandardSuitEnum StandardSuit
        {
            get { return m_suit; }
            set { m_suit = value; }
        }
        public static StandardPlayingCard GetColorlessJoker()
        {
            return new StandardPlayingCard(StandardSuitEnum.NotASuit, 15)
            {
                SuitName = "Colorless"
            };
        }
        public static StandardPlayingCard GetColorJoker()
        {
            return new StandardPlayingCard(StandardSuitEnum.NotASuit, 16)
            {
                SuitName = "Color"
            };
        }
        public static string GetFaceValue(int pointValue)
        {
            string m_faceValue = "";
            switch (pointValue)
            {
                case 0:
                case 16:
                case 17:
                    m_faceValue = "Joker";
                    break;
                case 11:
                    m_faceValue = "J";
                    break;
                case 12:
                    m_faceValue = "Q";
                    break;
                case 14:
                    m_faceValue = "K";
                    break;
                case 1:
                case 15:
                    m_faceValue = "A";
                    break;
                default:
                    m_faceValue = pointValue.ToString();
                    break;
            }
            return m_faceValue;
        }
    }
}
