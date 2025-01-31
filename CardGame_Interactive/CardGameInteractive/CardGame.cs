namespace CardGameInteractive;
/// <summary>
/// Defines the card game that im
/// </summary>
public class CardGame
{
    /// <summary>
    /// the card deck
    /// </summary>
    private CardDeck _cardDeck;
    
    /// <summary>
    /// the score of the game
    /// </summary>
    private Score _score;
    
    /// <summary>
    /// the last card played by the user
    /// </summary>
    private Card _playerCard;
    
    /// <summary>
    /// The last card player by the house
    /// </summary>
    private Card _houseCard;
}