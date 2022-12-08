King whiteKing = new King("Petit roque : e1 -> g1. Grand roque : e1 -> c1");
King blackKing = new King("Petit roque : e8 -> c8. Grand roque : e8 -> g8");
Queen blackQueen = new Queen();
Queen whiteQueen = new Queen();


abstract class Piece // classe abstraite d�clar� avec abstract
{
    public abstract string MovementDescription(); // m�thode abstraite qui d�crit le mouvement
}

interface ICastling // interface d�clar� avec abstract
{
    string castling(); // La m�thode castling sera impl�ment� pour d�crire comment la pi�ce fait un roque.
}

class King : Piece, ICastling // classe King qui h�rite de Piece et impl�mente ICastling
{
    public string Move { get; set; }
    public string CastlingDescription { get; set; } // � l'instanciation d�crire comment s'effectue le rock selon si on fait un petit ou un grand roque et selon si on joue blanc ou noir.

    public King(string move, string castlingDescription )
    {
        move = "une case � la fois, dans toutes les directions.";
        CastlingDescription = castlingDescription;
    }

    public override string MovementDescription() // King impl�mente la m�thode MovementDescription de Piece gr�ce au mot-cl� override
    {
        return "Le roi se d�place ainsi : " + Move;
    }

    public string castling() // Impl�mente la m�thode castling de l'interface ICastling
    {
        return CastlingDescription;
    }
}

class Queen : Piece // classe Queen qui h�rtie de Piece
{
    public string Move { get; set; }

    public Queen(string Move)
    {
        Move = "soit horizontalement, soit verticalement, soit diagonalement d'un nombre de cases indiff�rent.";
    }

    public override string MovementDescription() // Queen impl�mente la m�thode MovementDescription de Piece gr�ce au mot-cl� override
    {
        return "La reine se d�place ainsi : " + Move;
    }

    // On impl�mente pas l'interface car la reine ne peut pas roquer
}


