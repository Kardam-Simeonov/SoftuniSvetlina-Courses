package com.example.sudokuinterface;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.widget.ImageViewCompat;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import org.w3c.dom.Text;

import java.util.HashSet;
import java.util.List;

public class MainActivity extends AppCompatActivity {
    Sudoku sudoku = new Sudoku(9, 40);
    TextView[] keypadButtons = new TextView[9];
    TextView lives;
    int livesValue = 3;
    TextView startNewGame;
    boolean isGameOver = false;
    boolean hasCurrentlySelected = false;
    TextView currentlySelected = null;
    int currentTextRow = 0;
    int currentTextCol = 0;
    String currentTextStorage = "";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        View keypad = findViewById(getResources().getIdentifier(String.format("keypad"), "id", getPackageName()));
        lives = findViewById(getResources().getIdentifier(String.format("lives"), "id", getPackageName()));

        for (int row = 0; row < 9; row++){
            for (int col = 0; col < 9; col++){
                int id = getResources().getIdentifier(String.format("txt_%d_%d", row, col), "id", getPackageName());
                TextView current = findViewById(id);
                int finalCol = col;
                int finalRow = row;
                current.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View view) {
                        if (!hasCurrentlySelected && !isGameOver){
                            currentlySelected = current;
                            currentTextCol = finalCol;
                            currentTextRow = finalRow;
                            currentTextStorage = current.getText().toString();
                            current.setBackgroundResource(R.drawable.borderselected);
                            keypad.setVisibility(View.VISIBLE);
                            hasCurrentlySelected = true;
                        }
                    }
                });

                sudoku.matrix[row][col] = current;
            }
        }

        for (int i = 1; i <= 9; i++){
            int id = getResources().getIdentifier(String.format("keyNum%d", i), "id", getPackageName());
            TextView current = findViewById(id);

            current.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View view) {
                    if (hasCurrentlySelected){
                        currentlySelected.setText(current.getText());
                    }
                }
            });
            keypadButtons[i - 1] = current;
        }
        View editKey = findViewById(getResources().getIdentifier(String.format("keyEdit"), "id", getPackageName()));
        editKey.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (hasCurrentlySelected){
                    if (sudoku.CheckIfSafe(currentTextRow, currentTextCol, Integer.parseInt(currentlySelected.getText().toString()))) {
                        currentlySelected.setBackgroundResource(R.drawable.borderlight);
                        keypad.setVisibility(View.INVISIBLE);
                        hasCurrentlySelected = false;
                        if (sudoku.isMatrixFilled() == true){
                            lives.setText("You won!");
                            isGameOver = true;
                        }
                    }
                    else{
                        if (livesValue == 1){
                            lives.setText("You lost!");
                            isGameOver = true;
                        }
                        else {
                            livesValue--;
                            lives.setText("Lives: " + livesValue);
                        }

                        currentlySelected.setText(currentTextStorage);
                        currentlySelected.setBackgroundResource(R.drawable.borderlight);
                        keypad.setVisibility(View.INVISIBLE);
                        hasCurrentlySelected = false;
                    }
                }
            }
        });
        View deleteKey = findViewById(getResources().getIdentifier(String.format("keyDelete"), "id", getPackageName()));
        deleteKey.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (hasCurrentlySelected) {
                    currentlySelected.setText(currentTextStorage);
                    currentlySelected.setBackgroundResource(R.drawable.borderlight);
                    keypad.setVisibility(View.INVISIBLE);
                    hasCurrentlySelected = false;
                }
            }
        });

        sudoku.fillValues();

        startNewGame = findViewById(getResources().getIdentifier(String.format("startNewGame"), "id", getPackageName()));

        startNewGame.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (!hasCurrentlySelected) {
                    isGameOver = false;
                    livesValue = 3;
                    lives.setText("Lives: " + livesValue);
                    sudoku.clearMatrix();
                    sudoku.fillValues();
                }
            }
        });
    }
}