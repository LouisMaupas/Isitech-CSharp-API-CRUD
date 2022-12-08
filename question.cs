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
    public string MovementDescription { get; set; }
    public string CastlingDescription { get; set; } // � l'instanciation d�crire comment s'effectue le rock selon si on fait un petit ou un grand roque et selon si on joue blanc ou noir.

    public King(string Move)
    {
        Move = "une case � la fois, dans toutes les directions.";
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
    public string MovementDescription { get; set; }

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

