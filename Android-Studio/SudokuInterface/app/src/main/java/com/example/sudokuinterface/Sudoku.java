package com.example.sudokuinterface;


import android.widget.TextView;

public class Sudoku
{
    TextView[][] matrix;
    int N; // number of columns/rows.
    int squareOfN; // square root of N
    int missingDigitsCount; // No. Of missing digits

    // Constructor
    Sudoku(int N, int K)
    {
        this.N = N;
        this.missingDigitsCount = K;

        // Compute square root of N
        Double SRNd = Math.sqrt(N);
        squareOfN = SRNd.intValue();

        matrix = new TextView[9][9];
    }

    // Sudoku Generator
    public void fillValues()
    {
        // Fill the diagonal of SRN x SRN matrices
        fillDiagonal();

        // Fill remaining blocks
        fillRemaining(0, squareOfN);

        // Remove Randomly K digits to make game
        removeKDigits();
    }

    // Fill the diagonal SRN number of SRN x SRN matrices
    void fillDiagonal()
    {
        for (int i = 0; i < N; i = i + squareOfN) {
            // for diagonal box, start coordinates->i==j
            fillBox(i, i);
        }
    }

    // Returns false if given 3 x 3 block contains num.
    boolean unUsedInBox(int rowStart, int colStart, int num)
    {
        for (int i = 0; i< squareOfN; i++)
            for (int j = 0; j< squareOfN; j++)
                if (matrix[rowStart+i][colStart+j].getText().toString() == Integer.toString(num))
                    return false;

        return true;
    }

    // Fill a 3 x 3 matrix.
    void fillBox(int row,int col)
    {
        int num;
        for (int i = 0; i< squareOfN; i++)
        {
            for (int j = 0; j< squareOfN; j++)
            {
                do
                {
                    num = randomGenerator(N);
                }
                while (!unUsedInBox(row, col, num));

                matrix[row+i][col+j].setText(Integer.toString(num));
            }
        }
    }

    // Random generator
    int randomGenerator(int num)
    {
        return (int) Math.floor((Math.random()*num+1));
    }

    // Check if safe to put in cell
    boolean CheckIfSafe(int i,int j,int num)
    {
        return (unUsedInRow(i, num) &&
                unUsedInCol(j, num) &&
                unUsedInBox(i-i% squareOfN, j-j% squareOfN, num));
    }

    // check in the row for existence
    boolean unUsedInRow(int i,int num)
    {
        for (int j = 0; j<N; j++)
            if (matrix[i][j].getText().toString() == Integer.toString(num))
                return false;
        return true;
    }

    // check in the row for existence
    boolean unUsedInCol(int j,int num)
    {
        for (int i = 0; i<N; i++)
            if (matrix[i][j].getText().toString() == Integer.toString(num))
                return false;
        return true;
    }

    // A recursive function to fill remaining
    // matrix
    boolean fillRemaining(int i, int j)
    {
        // System.out.println(i+" "+j);
        if (j>=N && i<N-1)
        {
            i = i + 1;
            j = 0;
        }
        if (i>=N && j>=N)
            return true;

        if (i < squareOfN)
        {
            if (j < squareOfN)
                j = squareOfN;
        }
        else if (i < N- squareOfN)
        {
            if (j==(int)(i/ squareOfN)* squareOfN)
                j = j + squareOfN;
        }
        else
        {
            if (j == N- squareOfN)
            {
                i = i + 1;
                j = 0;
                if (i>=N)
                    return true;
            }
        }

        for (int num = 1; num<=N; num++)
        {
            if (CheckIfSafe(i, j, num))
            {
                matrix[i][j].setText(Integer.toString(num));
                if (fillRemaining(i, j+1))
                    return true;

                matrix[i][j].setText("");
            }
        }
        return false;
    }

    // Remove the K no. of digits to
    // complete game
    public void removeKDigits()
    {
        int count = missingDigitsCount;
        while (count != 0)
        {
            int cellId = randomGenerator(N*N)-1;

            // System.out.println(cellId);
            // extract coordinates i and j
            int i = (cellId/N);
            int j = cellId%9;
            if (j != 0)
                j = j - 1;

            // System.out.println(i+" "+j);
            if (matrix[i][j].getText().toString() != "")
            {
                count--;
                matrix[i][j].setText("");
            }
        }
    }
}