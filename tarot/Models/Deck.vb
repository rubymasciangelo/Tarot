Public Class Deck
    Public Deck()
    {
    Cards = New List<Card>();

    For (int i = 0; i < 14; i++)
        {
            For (int j = 0; j < 4; j++)
            {
                Card card = New Card();
                Card.Face = (Face)i;
                Card.Suit = (Suit)i;
                Cards.Add(card);
            }
        }
    }
End Class
