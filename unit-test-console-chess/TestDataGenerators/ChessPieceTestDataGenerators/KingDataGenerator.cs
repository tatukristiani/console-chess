using console_chess.Board;
using console_chess.ChessPieces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_test_console_chess.TestDataGenerators
{
    public class KingDataGenerator : IEnumerable<object[]>
    {

        private readonly List<object[]> _data =
        [
              new object[] {new King(6), Position.E1, Position.E2, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new King(6), Position.E1, Position.D2, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new King(6), Position.E1, Position.D1, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new King(6), Position.E1, Position.F2, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new King(6), Position.E1, Position.F1, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },

            new object[] {new King(-6), Position.E8, Position.D8, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new King(-6), Position.E8, Position.D7, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new King(-6), Position.E8, Position.E7, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new King(-6), Position.E8, Position.F7, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new King(-6), Position.E8, Position.F8, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new King(6), Position.D5, Position.D6, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, new King(6)},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, null},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new King(6), Position.D5, Position.C6, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, new King(6)},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, null},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new King(6), Position.D5, Position.C5, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, new King(6)},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, null},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    true
                },
            new object[] {new King(6), Position.D5, Position.C4, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, new King(6)},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, null},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    true
                },
            new object[] {new King(6), Position.D5, Position.D4, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, new King(6)},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, null},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    true
                },
            new object[] {new King(6), Position.D5, Position.E4, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, new King(6)},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, null},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    true
                },
            new object[] {new King(6), Position.D5, Position.E5, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, new King(6)},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, null},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    true
                },
            new object[] {new King(6), Position.D5, Position.E6, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, new King(6)},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, null},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },

            new object[] {new King(-6), Position.D5, Position.D6, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, null},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, new King(-6)},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, null},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    true
                },
            new object[] {new King(-6), Position.D5, Position.C6, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, null},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, new King(-6)},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, null},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    true
                },
            new object[] {new King(-6), Position.D5, Position.C5, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, null},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, new King(-6)},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, null},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    true
                },
            new object[] {new King(-6), Position.D5, Position.C4, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, null},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, new King(-6)},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, null},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    true
                },
            new object[] {new King(-6), Position.D5, Position.D4, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, null},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, new King(-6)},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, null},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    true
                },
            new object[] {new King(-6), Position.D5, Position.E4, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, null},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, new King(-6)},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, null},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    true
                },
            new object[] {new King(-6), Position.D5, Position.E5, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, null},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, new King(-6)},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, null},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    true
                },
            new object[] {new King(-6), Position.D5, Position.E6, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, null},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, new King(-6)},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, null},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    true
                },
            new object[] {new King(-6), Position.A5, Position.H5, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, null},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, new King(-6) },           {Position.B5, null},            {Position.C5, null},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, new Pawn(1)},
                        {Position.A3, new King(6) },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, null},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, null},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
        ];


        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
