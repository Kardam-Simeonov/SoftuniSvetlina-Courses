package com.example.travelplanner;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.os.Bundle;
import android.view.Menu;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    ArrayList<PlaceItemModel> placeItemModels = new ArrayList<>();
    String[] xIDArray = {
            "W260653250",
            "Q25484833",
            "R8311615",
            "N2907552977",
            "W287104635",
            "N7181741987",
            "Q12293249",
            "W162789700",
            "W171437780"
    };

    String[] nameArray = {
            "Church of St Petka of the Saddlers",
            "Античен културно - комуникационен комплекс Сердика",
            "Преториум",
            "Saint Sophia",
            "Serdika Metro Station",
            "Street Art",
            "Ascension of Jesus Church, Sofia",
            "Holy Nedelya Church",
            "Saint George Rotunda"
    };

    String[] kindsArray = {
            "religion,churches,interesting_places,other_churches",
            "museums,cultural,interesting_places,other_museums",
            "historic,archaeology,interesting_places,other_archaeological_sites",
            "historic,monuments_and_memorials,urban_environment,cultural,interesting_places,sculptures,monuments",
            "historic,archaeology,cultural,museums,interesting_places,other_museums,other_archaeological_sites",
            "wall_painting,cultural,urban_environment,interesting_places",
            "religion,churches,interesting_places,other_churches",
            "religion,cathedrals,churches,interesting_places,eastern_orthodox_churches",
            "religion,churches,interesting_places,eastern_orthodox_churches"
    };


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        RecyclerView recyclerView = findViewById(R.id.RecyclerView);

        setupPlaceItemModels();

        Place_RecyclerViewAdapter adapter = new Place_RecyclerViewAdapter(this, placeItemModels);

        recyclerView.setAdapter(adapter);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));
    }

    private void setupPlaceItemModels() {
        for (int i = 0; i < xIDArray.length; i++) {
            String[] kinds = kindsArray[i].split(",");
            String firstWord = kinds[0].trim();
            placeItemModels.add(new PlaceItemModel(xIDArray[i], nameArray[i], firstWord));
        }
    }

}