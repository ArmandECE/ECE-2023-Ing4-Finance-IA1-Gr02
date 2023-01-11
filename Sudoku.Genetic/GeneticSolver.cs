﻿using Sudoku.Shared;

namespace Sudoku.Genetic;
public class GeneticSolver: ISudokuSolver
    {
        public SudokuGrid Solve(SudokuGrid s)
        {
            return s.CloneSudoku();
        }

    }
