package com.example.recyclerviewexample;

import androidx.appcompat.app.AppCompatActivity;

import android.app.Person;
import android.os.Bundle;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    ArrayList<PersonModel> personModels = new ArrayList<>();
    String[] personFirstNames = {"Vasil", "Hristo", "Lyuben", "Georgi", "Ivan", "Volen", "Kostadin", "Boiko", "Delyan", "Ahmed"};
    String[] personLastNames = {"Levski", "Botev", "Karavelov", "Rakovski", "Vazov", "Siderov", "Kostadinov", "Borisov", "Peevski", "Dogan"};
    int[] personImages = {R.drawable.Levski, R.drawable.Botev, R.drawable.Karavelov, R.drawable.Rakovski, R.drawable.Vazov, R.drawable.Siderov, R.drawable.Kostadinov, R.drawable.Borisov, R.drawable.Peevski, R.drawable.Dogan};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    private void setupPersonModels(){
        for (int i = 0; i < personFirstNames.length; i++){
            personModels.add(new PersonModel(personFirstNames[i], personLastNames[i], personImages[i]));
        }
    }
}