King whiteKing = new King("Petit roque : e1 -> g1. Grand roque : e1 -> c1");
King blackKing = new King("Petit roque : e8 -> c8. Grand roque : e8 -> g8");
Queen blackQueen = new Queen();
Queen whiteQueen = new Queen();


abstract class Piece // classe abstraite déclaré avec abstract
{
    public abstract string MovementDescription(); // méthode abstraite qui décrit le mouvement
}

interface ICastling // interface déclaré avec abstract
{
    string castling(); // La méthode castling sera implémenté pour décrire comment la pièce fait un roque.
}

class King : Piece, ICastling // classe King qui hérite de Piece et implémente ICastling
{
    public string Move { get; set; }
    public string CastlingDescription { get; set; } // à l'instanciation décrire comment s'effectue le rock selon si on fait un petit ou un grand roque et selon si on joue blanc ou noir.

    public King(string move, string castlingDescription )
    {
        move = "une case à la fois, dans toutes les directions.";
        CastlingDescription = castlingDescription;
    }

    public override string MovementDescription() // King implémente la méthode MovementDescription de Piece grâce au mot-clé override
    {
        return "Le roi se déplace ainsi : " + Move;
    }

    public string castling() // Implémente la méthode castling de l'interface ICastling
    {
        return CastlingDescription;
    }
}

class Queen : Piece // classe Queen qui hértie de Piece
{
    public string Move { get; set; }

    public Queen(string Move)
    {
        Move = "soit horizontalement, soit verticalement, soit diagonalement d'un nombre de cases indifférent.";
    }

    public override string MovementDescription() // Queen implémente la méthode MovementDescription de Piece grâce au mot-clé override
    {
        return "La reine se déplace ainsi : " + Move;
    }

    // On implémente pas l'interface car la reine ne peut pas roquer
}


