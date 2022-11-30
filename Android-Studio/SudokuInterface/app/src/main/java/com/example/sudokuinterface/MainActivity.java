package com.example.sudokuinterface;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import org.w3c.dom.Text;

import java.util.HashSet;
import java.util.List;

public class MainActivity extends AppCompatActivity {
    TextView[][] sudokuMatrix = new TextView[9][9];
    TextView[] keypadButtons = new TextView[11];
    boolean hasCurrentlySelected = false;
    TextView currentlySelected = null;
    String currentTextStorage = "";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        for (int row = 0; row < 9; row++){
            for (int col = 0; col < 9; col++){
                int id = getResources().getIdentifier(String.format("txt_%d_%d", row, col), "id", getPackageName());
                TextView current = findViewById(id);
                current.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View view) {
                        if (!hasCurrentlySelected){
                            currentlySelected = current;
                            currentTextStorage = current.getText().toString();
                            hasCurrentlySelected = true;
                        }
                    }
                });

                sudokuMatrix[row][col] = current;
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
        keypadButtons[9] = findViewById(getResources().getIdentifier(String.format("keyEdit"), "id", getPackageName()));
        keypadButtons[9].setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (hasCurrentlySelected){
                    hasCurrentlySelected = false;
                }
            }
        });
        keypadButtons[10] = findViewById(getResources().getIdentifier(String.format("keyDelete"), "id", getPackageName()));
        keypadButtons[10].setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (hasCurrentlySelected) {
                    currentlySelected.setText(currentTextStorage);
                    hasCurrentlySelected = false;
                }
            }
        });
    }
}