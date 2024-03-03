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
    public class BishopDataGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data =
        [
              new object[] {new Bishop(3), Position.C5, Position.C4, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, new Bishop(3)},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, null},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new Bishop(3), Position.C5, Position.C6, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, new Bishop(3)},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, null},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new Bishop(3), Position.C5, Position.B5, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, new Bishop(3)},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, null},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new Bishop(3), Position.C5, Position.D5, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, new Bishop(3)},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, null},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new Bishop(3), Position.C5, Position.B6, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, new Bishop(3)},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, null},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    true
                },
            new object[] {new Bishop(3), Position.C5, Position.A7, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, new Bishop(3)},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, null},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    true
                },
            new object[] {new Bishop(3), Position.C5, Position.D4, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, new Bishop(3)},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, null},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    true
                },
            new object[] {new Bishop(3), Position.C5, Position.F2, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, new Bishop(3)},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, null},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },

            new object[] {new Bishop(-3), Position.C5, Position.C4, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, new Bishop(-3)},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, null},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new Bishop(-3), Position.C5, Position.C6, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, new Bishop(-3)},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, null},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new Bishop(-3), Position.C5, Position.B5, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, new Bishop(-3)},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, null},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new Bishop(-3), Position.C5, Position.D5, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, new Bishop(-3)},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, null},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new Bishop(-3), Position.C5, Position.B6, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, new Bishop(-3)},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, null},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    true
                },
            new object[] {new Bishop(-3), Position.C5, Position.A7, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, new Bishop(-3)},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, null},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new Bishop(-3), Position.C5, Position.D4, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, new Bishop(-3)},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, null},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    true
                },
            new object[] {new Bishop(-3), Position.C5, Position.F2, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, new Bishop(-3)},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, null},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    true
                },
            new object[] {new Bishop(-3), Position.F8, Position.A4, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, new Bishop(-3)},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, new Tower(4) },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, null},   {Position.B1, new Knight(2)},   {Position.C1, null},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new Bishop(3), Position.C1, Position.H5, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, new Bishop(-3)},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, new Tower(4) },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, null},     {Position.D2, null},     {Position.E2, null},     {Position.F2, null},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, null},   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, null},    {Position.E1, null},     {Position.F1, null},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new Bishop(3), Position.C1, Position.G6, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, new Bishop(-3)},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, new Tower(4) },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, null},     {Position.D2, null},     {Position.E2, null},     {Position.F2, null},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, null},   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, null},    {Position.E1, null},     {Position.F1, null},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new Bishop(3), Position.C1, Position.F7, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, new Bishop(-3)},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, new Tower(4) },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, null},     {Position.D2, null},     {Position.E2, null},     {Position.F2, null},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, null},   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, null},    {Position.E1, null},     {Position.F1, null},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new Bishop(3), Position.A3, Position.H3, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, new Bishop(-3)},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, new Tower(4) },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, new Bishop(3) },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, null},     {Position.D2, null},     {Position.E2, null},     {Position.F2, null},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, null},   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, null},    {Position.E1, null},     {Position.F1, null},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new Bishop(3), Position.A3, Position.H5, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, new Bishop(-3)},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, new Tower(4) },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, new Bishop(3) },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, null},     {Position.D2, null},     {Position.E2, null},     {Position.F2, null},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, null},   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, null},    {Position.E1, null},     {Position.F1, null},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new Bishop(3), Position.A3, Position.G6, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, new Bishop(-3)},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, new Tower(4) },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, new Bishop(3) },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, null},     {Position.D2, null},     {Position.E2, null},     {Position.F2, null},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, null},   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, null},    {Position.E1, null},     {Position.F1, null},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new Bishop(3), Position.A3, Position.F7, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5, new Bishop(-3)},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, new Tower(4) },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, new Bishop(3) },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, null},     {Position.D2, null},     {Position.E2, null},     {Position.F2, null},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, null},   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, null},    {Position.E1, null},     {Position.F1, null},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new Bishop(-3), Position.C8, Position.G5, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, null},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, null},            {Position.C5,null},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, new Tower(4) },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, new Bishop(3) },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, new Pawn(1)},     {Position.C2, null},     {Position.D2, null},     {Position.E2, null},     {Position.F2, null},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, null},   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, null},    {Position.E1, null},     {Position.F1, null},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new Bishop(-3), Position.A6, Position.E3, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8,null},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, null},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6,  new Bishop(-3) },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, new Pawn(1)},            {Position.C5,null},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, new Tower(4) },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, new Bishop(3) },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, null},     {Position.C2, null},     {Position.D2, null},     {Position.E2, null},     {Position.F2, null},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, null},   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, null},    {Position.E1, null},     {Position.F1, null},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new Bishop(3), Position.C1, Position.G6, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8,null},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7, null},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6,  new Bishop(-3) },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, new Pawn(1)},            {Position.C5,null},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, new Tower(4) },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, null},     {Position.C2, null},     {Position.D2, null},     {Position.E2, null},     {Position.F2, null},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, null},   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, null},    {Position.E1, null},     {Position.F1, null},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                },
            new object[] {new Bishop(-3), Position.B7, Position.F4, new Dictionary<Position, AChessPiece?>()
                    {
                        {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8,null},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                        {Position.A7, new Pawn(-1) },   {Position.B7,  new Bishop(-3)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                        {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                        {Position.A5, null },           {Position.B5, new Pawn(1)},            {Position.C5,null},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                        {Position.A4, new Tower(4) },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                        {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                        {Position.A2, null },    {Position.B2, null},     {Position.C2, null},     {Position.D2, null},     {Position.E2, null},     {Position.F2, null},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                        {Position.A1, null},   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, null},    {Position.E1, null},     {Position.F1, null},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
                    },
                    false
                }



        ];


        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
