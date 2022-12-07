module Domain

type Suit = 
    | Heart
    | Spade
    | Club
    | Diamond

type Face = 
    | Ace
    | King
    | Queen
    | Jack
    | Number of int

type Card = {
    Face : Face
    Suit : Suit
}

type Money = Money of int
type Bet = Bet of Money
type Pot = Pot of Money

type Deck = Card list
type Hand = Card list
