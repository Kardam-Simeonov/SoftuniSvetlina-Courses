package com.example.recyclerviewexample;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.app.Person;
import android.os.Bundle;
import android.view.Menu;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    ArrayList<PersonModel> personModels = new ArrayList<>();
    String[] personFirstNames = {"Vasil", "Hristo", "Lyuben", "Georgi", "Ivan", "Volen", "Kostadin", "Boiko", "Delyan", "Ahmed"};
    String[] personLastNames = {"Levski", "Botev", "Karavelov", "Rakovski", "Vazov", "Siderov", "Kostadinov", "Borisov", "Peevski", "Dogan"};
    int[] personImages = {R.drawable.levski, R.drawable.botev, R.drawable.karavelov, R.drawable.rakovski, R.drawable.vazov, R.drawable.siderov, R.drawable.kostadinov, R.drawable.borisov, R.drawable.peevski, R.drawable.dogan};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        RecyclerView recyclerView = findViewById(R.id.RecyclerView);

        setupPersonModels();

        Person_RecyclerViewAdapter adapter = new Person_RecyclerViewAdapter(this, personModels);

        recyclerView.setAdapter(adapter);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));

        Toolbar toolbar = findViewById(R.id.Toolbar);
        setSupportActionBar(toolbar);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.options, menu);
        return true;
    }

    private void setupPersonModels(){
        for (int i = 0; i < personFirstNames.length; i++){
            personModels.add(new PersonModel(personFirstNames[i], personLastNames[i], personImages[i]));
        }
    }
}